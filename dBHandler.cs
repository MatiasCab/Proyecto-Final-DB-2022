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

        public void close(MySqlDataReader reader)
        {
            reader.Close();
            reader.Dispose();
            this.db.Close();
        }

        public MySqlDataReader GetUser(string hashedPassword, string userId)
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM vwGetUser WHERE hashpwd = '{hashedPassword}' AND user_id = {userId};";

            var cmd = new MySqlCommand(sqlQuery, db);

            var reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader GetVistaMenuAplicativos(string app_id, string rol_id)
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM vwGetVistaAplicativos WHERE nombreapp = '{app_id}' AND descripcion_rol_neg = '{rol_id}'";

            var cmd = new MySqlCommand(sqlQuery, db);

            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetQuestions(){
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM PREGUNTAS";

            var cmd = new MySqlCommand(sqlQuery, db);
              return cmd.ExecuteReader();

        }

        public void createResponse(int id,  int id_pregunta, string respuesta){
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERSONAS_PREGUNTAS VALUES ({id}, {id_pregunta}, '{respuesta}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void CreateUser(int id, string nombre, string apellido, string direccion, string ciudad, string departamento, string hashpwd){
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERSONAS VALUES ('{id}', '{nombre}', '{apellido}', '{direccion}', '{ciudad}', '{departamento}', '{hashpwd}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void CreatePermiso(string user_id, string app_id, string rol_neg_id, string fecha_solicitud, string fecha_autorizacion, string estado){
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERMISOS VALUES ('{user_id}', '{app_id}', '{rol_neg_id}', '{fecha_solicitud}', '{fecha_autorizacion}', '{estado}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void AprobarPermiso(string user_id, string app_id, string rol_neg_id, string fecha_solicitud, string fecha_autorizacion, string estado){
            this.connectToDatabase();
            string sqlQuery = $"UPDATE PERMISOS SET fecha_autorizacion = '{fecha_autorizacion}', estado = '{estado}' WHERE user_id = '{user_id}' AND app_id = '{app_id}' AND rol_neg_id = '{rol_neg_id}' AND fecha_solicitud = '{fecha_solicitud}'";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }


    } 
}