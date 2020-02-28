using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace UserInterface
{

    public class Database
    {
        private static string connectionString = @"server=localhost;userid=root;database=kitbox;password=Mgbgt1979";
        private static MySqlConnection dataBaseConnection;

        private void InitializeDB()
        {
            dataBaseConnection = new MySqlConnection(connectionString);
        }

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
        public static MySqlDataReader Fetch(string query)
        {
            dataBaseConnection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, dataBaseConnection);
            try
            {
                dataBaseConnection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("{0} ", reader.GetString(1));
                }
                return reader;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
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
    }
}
