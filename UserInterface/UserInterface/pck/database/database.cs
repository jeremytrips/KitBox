using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace userInterface
{

    public class Database
    {
        private static string connectionString = @"server=localhost;port=3306;user=root;database=kitbox;password=Mgbgt1979";

        private static MySqlDataReader Fetch(string query)
        {
            MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            try
            {
                dataBaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                Console.WriteLine(ex);
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return null;
            }
        }

        internal static Dictionary<string, int> FetchClearedBill(int id)
        {
            Dictionary<string, int> clearedBill = new Dictionary<string, int> { };
            MySqlDataReader rdr = Fetch(string.Format("SELECT code, quantity FROM client_order_component WHERE id_order = {0} ", id));
            while (rdr.Read())
            {
                clearedBill.Add(rdr.GetString(0), rdr.GetInt16(1));
            }
            return clearedBill;
        }

        internal static List<object> FetchUserData(string oldOrderName)
        {
            List<object> userData = new List<object> { };
            MySqlDataReader rdr = Fetch(string.Format("SELECT id_order, order_name FROM client_order WHERE order_name LIKE '{0}';", oldOrderName));
            while (rdr.Read())
            {
                userData.Add(rdr.GetInt16(0));
                userData.Add(rdr.GetString(1));
            }
            return userData;
        }

        internal static List<int> FetchAvailableAngleHeight()
        {
            List<int> list = new List<int> { };
            MySqlDataReader rdr = Fetch(" select distinct height from kitbox.component where reference like 'Corni %';");
            while (rdr.Read())
            {
                list.Add(rdr.GetInt16(0));
            }
            return list;
        }

        public static List<List<int>> FetchAvailableDimension()
        {
            List<int> depth = new List<int>();
            List<int> doorWidth = new List<int>();
            List<int> width = new List<int>();
            List<int> height = new List<int>();

            MySqlDataReader rdr = Fetch("select height from kitbox.component where reference like 'Tasseau';");         // Read height
            height = ReadInt(rdr);
            rdr = Fetch("select distinct width from kitbox.component where reference like 'Porte%';");                // Read widthwithdoor
            doorWidth = ReadInt(rdr);
            rdr = Fetch("select distinct width from kitbox.component where reference like 'Pann%';");                  // Read width without door
            width = ReadInt(rdr);
            rdr = Fetch("select distinct depth from kitbox.component where reference like 'Pann%';");                 // Read depth
            depth = ReadInt(rdr);

            return new List<List<int>> { depth, height, doorWidth, width };
        }

        public static List<int> ReadInt(MySqlDataReader reader)
        {
            List<int> readedData = new List<int>();
            try
            {
                while (reader.Read())
                {
                    readedData.Add(reader.GetInt16(0));
                }
                readedData.Remove(0);
            }
            catch
            {

            }
            return readedData;
        }

        public static List<string> FetchAngleAvailableColor()
        {
            MySqlDataReader rdr = Fetch("SELECT DISTINCT color FROM component WHERE reference='Cornieres';");
            List<string> colorList = new List<string>();
            try
            {
                while (rdr.Read())
                {
                    colorList.Add(rdr.GetString(0));
                }
            }
            catch (Exception e)
            {
                colorList.Add("No color");
                return colorList;
            }
            return colorList;
        }

        public static List<string> FetchPanelAvailableColor()
        {
            MySqlDataReader rdr = Fetch("SELECT DISTINCT color FROM kitbox.component WHERE reference LIKE '%Panneau%';");
            List<string> colorList = new List<string>();
            try
            {
                while (rdr.Read())
                {
                    colorList.Add(rdr.GetString(0));
                }
            }
            catch (Exception e)
            {
                colorList.Add("No color");
                return colorList;
            }
            return colorList;
        }

        internal static void HandleOrder()
        {
            throw new NotImplementedException();
        }

        internal static List<string> FetchDoorPanelAvailableColor()
        {
            MySqlDataReader rdr = Fetch("SELECT DISTINCT color FROM component WHERE code LIKE 'POR%';");
            List<string> colorList = new List<string>();
            try
            {
                while (rdr.Read())
                {
                    colorList.Add(rdr.GetString(0));
                }
            }
            catch (Exception e)
            {
                colorList.Add("No color");
                return colorList;
            }
            return colorList;
        }

        public static List<List<object>> HandleOrder(Dictionary<string, int> data)
        {
            List<List<object>> a = new List<List<object>> { };
            // List(code, reference, disponibilité, prix/u, qté, prix total
            foreach (string component in data.Keys)
            {
                MySqlDataReader rdr = Fetch(String.Format("SELECT reference, stock_min_required, number_by_box, stock, price FROM kitbox.component WHERE code LIKE '{0}';", component));
                List<object> orderEntry = new List<object> { };
                while (rdr.Read())
                {
                    orderEntry.Add(component);                                                 // Code
                    orderEntry.Add(rdr.GetString(0));                                          // Reference
                    orderEntry.Add(data[component] * rdr.GetInt16(2) < rdr.GetInt16(3));       // Availability
                    orderEntry.Add(rdr.GetFloat(4));                                           // Unit price
                    orderEntry.Add(data[component] * rdr.GetInt16(2));                         // Unit needed
                    orderEntry.Add(data[component] * rdr.GetInt16(2) * rdr.GetFloat(4));       // Total price
                }
                a.Add(orderEntry);
            }
            test(data);
            return a;
        }

        public static short GetNumberOfOrder()
        {
            short i = 0;
            MySqlDataReader rdr = Fetch("SELECT COUNT(*) FROM kitbox.client_order;");
            while (rdr.Read())
            {
                i = rdr.GetInt16(0);
            }
            return i;
        }

        public static void CreateOrder(int id, DateTime date, double price, double alreadyPaid, string orderName)
        {
            MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO client_order(id_order, date, price, already_paid, order_name) VALUES" +
                                    "(?id_order, ?date, ?price, ?already_paid, ?order_name);";
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            try
            {
                dataBaseConnection.Open();
                command.Parameters.Add("?id_order", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("?date", MySqlDbType.Date).Value = date;
                command.Parameters.Add("?price", MySqlDbType.Float).Value = price;
                command.Parameters.Add("?already_paid", MySqlDbType.Float).Value = alreadyPaid;
                command.Parameters.Add("?order_name", MySqlDbType.VarChar).Value = orderName;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Can't connect to mysql");
            }
        }

        public static void SaveOrder(KeyValuePair<string, int> keyValue, int order_id)
        {
            MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);
            string query = "INSERT INTO kitbox.client_order_component (id_order, code, quantity)" +
                           "VALUE(?order_id, ?code, ?quantity)";
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            try
            {
                dataBaseConnection.Open();
                command.Parameters.Add("?order_id", MySqlDbType.Int32).Value = order_id;
                command.Parameters.Add("?code", MySqlDbType.VarChar).Value = keyValue.Key;
                command.Parameters.Add("?quantity", MySqlDbType.Int32).Value = keyValue.Value;
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Can't connect to mysql");
            }
        }

        public static void test(Dictionary<string, int> keyValue)
        {
            List<string> keys = keyValue.Keys.ToList<string>();
            List<string> found = new List<string> { };
            foreach(string l in keyValue.Keys)
            {
                MySqlDataReader rdr = Fetch(string.Format("select code from kitbox.component Where code like '{0}';", l));
                while(rdr.Read())
                {
                    found.Add(rdr.GetString(0));
                }
            }
            Console.WriteLine(string.Format("{0} in keys {1} in found", keys.Count, found.Count));

            IEnumerable<string> differenceQuery = keys.Except(found);
            foreach(string l in differenceQuery)
            {
                Console.WriteLine(l);
            }
        }
        
    }
}
