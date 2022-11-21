using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;

namespace Aplicacion_1
{
    public class MySQLHandler
    {
        private const string CONN_STR = "server=localhost;user=root;database=Proyecto;port=3306;password=admin";
        private static MySQLHandler _instance = null;
        private MySqlConnection db = new MySqlConnection(CONN_STR);


        public static MySQLHandler getInstance()
        {
            if (_instance == null)
            {
                _instance = new MySQLHandler();
            }
            return _instance;
        }

        public void connectToDatabase()
        {
            try
            {
                if (db.State != ConnectionState.Open)
                {
                    db.Open();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
            }
        }

        public MySqlDataReader GetUser(string hashedPassword, string userId)
        {
            this.connectToDatabase();
            string sqlQuery = $"CALL spGetUser('{hashedPassword}', {userId})";

            var cmd = new MySqlCommand(sqlQuery, db);

            return cmd.ExecuteReader();

        }


    } 
}