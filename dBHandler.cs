using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Data;
using System.Collections.Generic;

using System.Drawing.Text;
using System.Management.Instrumentation;

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

        public List<Permiso> RetrieveData()
        {
            this.connectToDatabase();
            string sqlQuery = "SELECT * FROM PERMISOS";

            var cmd = new MySqlCommand(sqlQuery, db);

            var rdr = cmd.ExecuteReader();

            List<Permiso> permsisos = new List<Permiso>();

            while (rdr.Read()) {
                Console.WriteLine(rdr.GetValue(0));
                Console.WriteLine(rdr.GetValue(1));
                Console.WriteLine(rdr.GetValue(2));

                DateTime? fechaAutorizacion = null; 

                if (!rdr.IsDBNull(4))
                {
                    fechaAutorizacion = rdr.GetDateTime(4);
                }

                Permiso permiso = new Permiso(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2), rdr.GetDateTime(3), fechaAutorizacion, rdr.GetBoolean(5));
                permsisos.Add(permiso);
            }

            //Para el if -> IsDBNull o rdr.getValue(x).getType() == System.DBNull

            db.Close();
            return permsisos;
        }


    } 
}