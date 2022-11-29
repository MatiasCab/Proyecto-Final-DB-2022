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
                    user = new Usuario(appReader.GetInt32(0), appReader.GetString(1), appReader.GetString(2), appReader.GetString(4), appReader.GetString(6));
                }
                user.InsertRolNegApp(appReader.GetString(5), appReader.GetString(4));
            }
            MySQLHandler.getInstance().close(appReader);
            if (isFirst)
            {
                return null;
            }
            return user;
        }

        public static Usuario getUser(string userId)
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetUserNoPass(userId);
            
            Usuario user = null;

            while (appReader.Read())
            {
                user = new Usuario(appReader.GetInt32(0), appReader.GetString(1), appReader.GetString(2), appReader.GetString(4), appReader.GetString(6));
            }
            
            MySQLHandler.getInstance().close(appReader);
            
            if(user != null)
            {
                return user;
            }
            return null;
        }

        public static Usuario LoginHashPass(string userId, string password)
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetUserNoPass(userId);

            bool isFirst = true;
            Usuario user = null;

            while (appReader.Read())
            {
                if (isFirst)
                {
                    isFirst = false;
                    user = new Usuario(appReader.GetInt32(0), appReader.GetString(1), appReader.GetString(2), appReader.GetString(3), appReader.GetString(6));
                }
                user.InsertRolNegApp(appReader.GetString(5), appReader.GetString(4));
            }

            MySQLHandler.getInstance().close(appReader);

            if (isFirst)
            {
                return null;
            }


            bool logueoCorrecto = BCryptNet.Verify(password, user.hashpwd);
            if(logueoCorrecto){
                return user;
            }else{
                return null;
            }
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

        public static LinkedList<Aplicativo> GetApps()
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetApp();

            Aplicativo app = null;
            LinkedList<Aplicativo> apps = new LinkedList<Aplicativo>();

            while (appReader.Read())
            {
                app = new Aplicativo(appReader.GetString(0), appReader.GetString(1));
                apps.AddLast(app);
            }

            MySQLHandler.getInstance().close(appReader);
            return apps;
        }

        public static LinkedList<RolesNegocio> GetRoles()
        {
            MySqlDataReader appReader = MySQLHandler.getInstance().GetRoles();

            RolesNegocio rolesNegocio = null;
            LinkedList<RolesNegocio> rolesNegocios = new LinkedList<RolesNegocio>();

            while (appReader.Read())
            {
                rolesNegocio = new RolesNegocio(appReader.GetInt32(0), appReader.GetString(1));
                rolesNegocios.AddLast(rolesNegocio);
            }

            MySQLHandler.getInstance().close(appReader);
            return rolesNegocios;
        }

        public static void CreateUser(int id, string nombres, string apellidos, string direccion, string ciudad, string departamento, string password)
        {
            string hashedPassword = BCryptNet.HashPassword(password);
            MySQLHandler.getInstance().CreateUser(id, nombres, apellidos, direccion, ciudad, departamento, hashedPassword);
        }

        public static void CreatePermiso(int user_id, string app_id, int rol_neg_id, DateTime fecha_solicitud, DateTime? fecha_autorizacion, bool estado){
            MySQLHandler.getInstance().CreatePermiso(user_id, app_id, rol_neg_id, fecha_solicitud, fecha_autorizacion, estado);
        }

        public static void UpdatePermiso(Permiso permiso){
            MySQLHandler.getInstance().UpdatePermiso(permiso);
        }

        public static void CreateResponse(int id,  int id_pregunta, string respuesta){
            MySQLHandler.getInstance().createResponse(id, id_pregunta, respuesta);
        }

        public static LinkedList<Permiso> GetPermisos(){
            MySqlDataReader appReader = MySQLHandler.getInstance().GetPermisos();

            LinkedList<Permiso> permisos = new LinkedList<Permiso>();

            while (appReader.Read())
            {
                    DateTime date = new DateTime(0001, 01, 01, 00, 00, 00);
                    if (!appReader.IsDBNull(4))
                    {
                        date = appReader.GetDateTime(4);
                    }
                    Permiso permiso = new Permiso(appReader.GetInt32(0), appReader.GetString(1), appReader.GetInt32(2), appReader.GetDateTime(3), date, appReader.GetBoolean(5));
                    permisos.AddLast(permiso);
                
            }

            MySQLHandler.getInstance().close(appReader);
            return permisos;
        }

        public static LinkedList<PersonasPregunta> GetPersonasPreguntas(int id){
            MySqlDataReader appReader = MySQLHandler.getInstance().GetPersonasPreguntas(id);
            PersonasPregunta personasPregunta = null;
            LinkedList<PersonasPregunta> personasPreguntas = new LinkedList<PersonasPregunta>();

            while (appReader.Read())
            {
                personasPregunta = new PersonasPregunta(appReader.GetInt32(0), appReader.GetInt32(1), appReader.GetString(2));
                personasPreguntas.AddLast(personasPregunta);
            }

            MySQLHandler.getInstance().close(appReader);
            return personasPreguntas;
        }

        public static Pregunta GetPreguntaById(int id){
            MySqlDataReader appReader = MySQLHandler.getInstance().GetPreguntaById(id);
            Pregunta pregunta = null;

            while (appReader.Read())
            {
                pregunta = new Pregunta(appReader.GetInt32(0), appReader.GetString(1));
            }

            MySQLHandler.getInstance().close(appReader);
            return pregunta;
        }

        //public static void GetPer

        public static void UpdateUser(Usuario user)
        {
            MySQLHandler.getInstance().UpdateUser(user);
        }
        
    }

    
}
