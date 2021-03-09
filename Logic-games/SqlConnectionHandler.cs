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

        static public int InitialSetup() 
        {
            string connStr = "server=localhost;user=root;password=''";
            string databaseCreateSql =  $"CREATE DATABASE IF NOT EXISTS {database};"+
                                        $"USE {database};" +

                                        $"CREATE TABLE IF NOT EXISTS snake " +
                                        $"(id int PRIMARY KEY AUTO_INCREMENT, " +
                                        $"score int);" +

                                        $"CREATE TABLE IF NOT EXISTS megoldas1 " + 
                                        $"(`1` int, `2` int, `3` int, `4` int, `5` int, `6` int, `7` int, `8` int, `9` int);";

            connection = new MySqlConnection(connStr);
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(databaseCreateSql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                var ifExists = Query("SELECT COUNT(`1`) FROM megoldas1");
                if (ifExists[0][0] == "0")
                {
                    string generateTable =  "INSERT INTO megoldas1 VALUES " +
                                            "(8, 3, 7, 1, 9, 4, 6, 2, 5), " +
                                            "(5, 4, 9, 6, 2, 3, 7, 8, 1), " +
                                            "(6, 2, 1, 7, 8, 5, 9, 3, 4), " +
                                            "(2, 5, 6, 8, 1, 7, 4, 9, 3), " +
                                            "(4, 1, 3, 5, 6, 9, 2, 7, 8), " +
                                            "(9, 7, 8, 3, 4, 2, 5, 1, 6), " +
                                            "(1, 6, 4, 2, 7, 8, 3, 5, 9), " +
                                            "(7, 9, 5, 4, 3, 1, 8, 6, 2), " +
                                            "(3, 8, 2, 9, 5, 6, 1, 4, 7);";
                    RunNonQuery(generateTable);
                }
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
