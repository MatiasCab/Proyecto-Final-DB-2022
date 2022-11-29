using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BCryptNet = BCrypt.Net.BCrypt;
using System.Threading.Tasks;

namespace Aplicacion_1
{
    public static class Logica
    {

        public static Usuario Login(string userId, string password)
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetUser(password, userId);

            bool isFirst = true;
            Usuario user = null;

            while (appReader.Read())
            {
                if (isFirst)
                {
                    isFirst = false;
                    user = new Usuario(appReader.GetInt32(0), appReader.GetString(1), appReader.GetString(2), appReader.GetString(4));
                }
                user.InsertRolNegApp(appReader.GetString(5), appReader.GetString(4));
            }

            if (isFirst)
            {
                return null;
            }
            MySQLHandler.getInstance().close(appReader);
            return user;
        }

        public static AplicativoRoles GetMenuAplicativos(string app_id, string rol_id)
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetVistaMenuAplicativos(app_id, rol_id);

            bool isFirst = true;

            AplicativoRoles rolesAplicativos = null;

            while (appReader.Read())
            {
                if (isFirst)
                {
                    isFirst = false;
                    rolesAplicativos = new AplicativoRoles(appReader.GetString(3), appReader.GetString(2), appReader.GetString(4));
                }
                rolesAplicativos.InsertRolApp(appReader.GetString(1), appReader.GetString(0));
            }
            MySQLHandler.getInstance().close(appReader);
            return rolesAplicativos;
        }

        public static Dictionary<int, string> GetQuestions(){

            Dictionary<int,string> dictQuestions = new Dictionary<int, string>();    
            MySqlDataReader questionReader = MySQLHandler.getInstance().GetQuestions();

            while (questionReader.Read())
            {
                dictQuestions.Add(questionReader.GetInt32(0), questionReader.GetString(1));
                    
            }

            MySQLHandler.getInstance().close(questionReader);
            return dictQuestions;

        }

        public static void CreateUser(string id, string nombres, string apellidos, string direccion, string ciudad, string departamento, string password)
        {
            string hashedPassword = BCryptNet.HashPassword(password);
            MySQLHandler.getInstance().CreateUser(id, nombres, apellidos, direccion, ciudad, departamento, hashedPassword);
        }

        public static void CreatePermiso(string user_id, string app_id, string rol_neg_id, string fecha_solicitud, string fecha_autorizacion, string estado){
            MySQLHandler.getInstance().CreatePermiso(user_id, app_id, rol_neg_id, fecha_solicitud, fecha_autorizacion, estado);
        }

        public static void AprobarPermiso(  string user_id, string app_id, string rol_neg_id, string fecha_solicitud, string fecha_autorizacion, string estado){
            MySQLHandler.getInstance().AprobarPermiso(user_id, app_id, rol_neg_id, fecha_solicitud, fecha_autorizacion, estado);
        }

        public static void CreateResponse(string id,  string id_pregunta, string respuesta){
            MySQLHandler.getInstance().createResponse(id, id_pregunta, respuesta);
        }
        
    }

    
}
