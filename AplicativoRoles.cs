using System;
using System.Collections.Generic;

namespace Aplicacion_1
{
    public class AplicativoRoles : Aplicativo
    {
        public string descripcion_rol_neg;
        public Dictionary<string, LinkedList<string>> rolesApp { get; private set; }

        public AplicativoRoles(string descripcion_rol_neg, string nombre_app, string app_id)
            : base(app_id, nombre_app)
        {
            this.descripcion_rol_neg = descripcion_rol_neg;
            this.rolesApp = new Dictionary<string, LinkedList<string>>();
        }

        public void InsertRolApp(string descripcion_rol_A, string descripcion_menu)
        {
            if (!this.rolesApp.ContainsKey(descripcion_rol_A))
            {
                this.rolesApp.Add(descripcion_rol_A, new LinkedList<string>());
            }
            Console.WriteLine(descripcion_rol_A);
            this.rolesApp.TryGetValue(descripcion_rol_A, out LinkedList<string> value);
            value.AddLast(descripcion_menu);
        }


    }
}