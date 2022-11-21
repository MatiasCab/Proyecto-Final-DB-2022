using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_1
{
    public static class Logica
    {

        public static Usuario Login(string userId, string password)
        {
            MySqlDataReader userReader = MySQLHandler.getInstance().GetUser(password, userId);

            bool isFirst = true;
            Usuario user = null;

            while (userReader.Read())
            {
                if (isFirst)
                {
                    isFirst = false;
                    user = new Usuario(userReader.GetInt32(0), userReader.GetString(1), userReader.GetString(2), userReader.GetString(4));
                }
                user.InsertRolNegApp(userReader.GetString(5), userReader.GetString(4));
            }

            if (isFirst)
            {
                return null;
            }

            Console.WriteLine(user.rolesNegocio.ToString());

            return user;
        }
    }
}
