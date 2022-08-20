
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Community_v1
{
    class DB
    {

        MySqlConnection connection = new MySqlConnection("Server=localhost;" +
                                                        "Database=community_v1;" +
                                                        "port=3306;" +
                                                        "User Id=root;" +
                                                        "password=root");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void clouseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
