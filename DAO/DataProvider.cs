using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => DataProvider.instance = value;
        }

        private DataProvider() { }

        // Get connection string from App.config file
        // private string conString = System.Configuration.ConfigurationManager.ConnectionStrings["medicalManagement"].ConnectionString;
        private static string SERVER = "151.106.117.0";
        private static string DATABASE = "u116687685_pet";
        private static string USERNAME = "u116687685_pet";
        private static string PASSWORD  = "Thanhphuc3010@";
        private static string conString = "server=" + SERVER + ";database=" + DATABASE + ";uid=" + USERNAME + ";pwd=" + PASSWORD + ";";

        public static IDbConnection Connect = new MySqlConnection(conString);
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                conn.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
    }
}
