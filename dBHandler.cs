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

        public MySqlDataReader GetUserHashPass(string hashedPassword, string userId)
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

        public MySqlDataReader GetQuestions()
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM PREGUNTAS";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetRoles()
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM ROLES_NEGOCIO";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetApp()
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM APLICATIVOS";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public void createResponse(int id, int id_pregunta, string respuesta)
        {
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERSONAS_PREGUNTAS VALUES ({id}, {id_pregunta}, '{respuesta}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void CreateUser(int id, string nombre, string apellido, string direccion, string ciudad, string departamento, string hashpwd)
        {
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERSONAS VALUES ('{id}', '{nombre}', '{apellido}', '{direccion}', '{ciudad}', '{departamento}', '{hashpwd}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void CreatePermiso(int user_id, string app_id, int rol_neg_id, DateTime fecha_solicitud, DateTime? fecha_autorizacion, bool estado)
        {
            this.connectToDatabase();
            string sqlQuery = $"INSERT INTO PERMISOS VALUES ('{user_id}', '{app_id}', '{rol_neg_id}', '{fecha_solicitud}', '{fecha_autorizacion}', '{estado}')";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public void UpdatePermiso(Permiso permiso)
        {
            this.connectToDatabase();
            string sqlQuery = $"UPDATE PERMISOS SET fecha_autorizacion = {permiso.fecha_autorizacion}, estado = '{permiso.estado}' WHERE user_id = {permiso.user_id} AND app_id = '{permiso.app_id}' AND rol_neg_id = {permiso.rol_neg_id} AND fecha_solicitud = {permiso.fecha_solicitud}";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteNonQuery();
        }

        public MySqlDataReader GetPermisos()
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM PERMISOS";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetPersonasPreguntas(int id)
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * PERSONAS_PREGUNTAS WHERE user_id = {id}";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public MySqlDataReader GetUserNoPass(string userId)
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM vwGetUser WHERE user_id = {userId};";

            var cmd = new MySqlCommand(sqlQuery, db);

            var reader = cmd.ExecuteReader();
            return reader;
        }

        public MySqlDataReader GetPreguntaById(int id)
        {
            this.connectToDatabase();
            string sqlQuery = $"SELECT * FROM PREGUNTAS WHERE preg_id = {id}";

            var cmd = new MySqlCommand(sqlQuery, db);
            return cmd.ExecuteReader();
        }

        public void UpdateUser(Usuario user)
        {
            this.connectToDatabase();
            string sqlQuery = $"UPDATE PERSONAS SET  hashpwd = '{user.hashpwd}' WHERE user_id = {user.userId}";

            var cmd = new MySqlCommand(sqlQuery, db);
            cmd.ExecuteReader();
        }
    }
}