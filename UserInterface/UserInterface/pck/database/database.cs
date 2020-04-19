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
        private static MySqlConnection dataBaseConnection;

        public static bool LogIn(string email, string password)
        {
            String query = string.Format("SELECT * FROM kitbox.user WHERE email='{0}'", email);
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);

            dataBaseConnection.Open();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();

            bool login = reader["password"].Equals(password);

            dataBaseConnection.Close();
            return login;
        }

        public static void Insert(String query)
        {
            MySqlCommand cmd = new MySqlCommand(query, dataBaseConnection);
            dataBaseConnection.Open();
            cmd.ExecuteNonQuery();
            dataBaseConnection.Close();
        }
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
    }
}
