using System.Collections.Generic;

namespace Aplicacion_1
{
    public class Usuario
    {
        public int userId { get; private set; }
        public string nombre { get; private set; }
        public string apellido { get; private set; }
        public string ciudad { get; private set; }
        public string hashpwd { get; private set; }
        public Dictionary<string, LinkedList<string>> rolesNegocio { get; private set; }

        public Usuario(int userId, string nombre, string apellido, string ciudad, string hashpwd)
        {
            this.userId = userId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.ciudad = ciudad;
            this.rolesNegocio = new Dictionary<string, LinkedList<string>>();
            this.hashpwd = hashpwd;
        }

        public void InsertRolNegApp(string rolNeg, string app)
        {
            if (!this.rolesNegocio.ContainsKey(rolNeg))
            {
                this.rolesNegocio.Add(rolNeg, new LinkedList<string>());
            }
            this.rolesNegocio.TryGetValue(rolNeg, out LinkedList<string> value);
            value.AddLast(app);
        }
    }
}