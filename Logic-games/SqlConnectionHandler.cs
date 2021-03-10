using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace Logic_games
{
    class SqlConnectionHandler
    {
        static private MySqlConnection connection;
        static private string database = "logicgames";

        //Creates the required tables for the program (Only required to call once)
        static public int InitialSetup() 
        {
            string connStr = "server=localhost;user=root;password=''";
            string databaseCrateSql =   $"CREATE DATABASE IF NOT EXISTS {database};"+
                                        $"USE {database};" +
                                        $"CREATE TABLE IF NOT EXISTS snake " +
                                        $"(id int PRIMARY KEY AUTO_INCREMENT, " +
                                        $"score int);"+
                                        $"CREATE TABLE IF NOT EXISTS battleship " +
                                        $"(id int PRIMARY KEY AUTO_INCREMENT, " +
                                        $"score int);"+
                                        $"CREATE TABLE IF NOT EXISTS times " +
                                        $"(id int PRIMARY KEY AUTO_INCREMENT, " +
                                        $"timeSpent TIME);";
            connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(databaseCrateSql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return 0;
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        //Used to run SQL commands, which has no return value;
        static public void RunNonQuery(string command) 
        {
            string connStr = $"server=localhost;user=root;password='';database={database}";
            connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(command, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't connect to server!");
            }
        }

        //Used to run SQL commands with return values, return 2D list
        static public List<List<string>> Query(string query) 
        {
            string connStr = $"server=localhost;user=root;password='';database={database}";
            connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand sqlCommand = new MySqlCommand(query, connection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                List<List<string>> returned = new List<List<string>>();
                while (reader.Read()) 
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < reader.VisibleFieldCount; i++)
                    {
                        temp.Add(Convert.ToString(reader[i]));
                    }
                    returned.Add(temp);
                }
                connection.Close();
                return returned;
            }
            catch (Exception e)
            {
                MessageBox.Show("Couldn't connect to server!");
                return new List<List<string>>();
            }
        }
    }
}
