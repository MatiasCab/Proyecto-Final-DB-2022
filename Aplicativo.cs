using System;

namespace Aplicacion_1
{
    public class Aplicativo
    {
        public int app_id { get; private set; }
        public string nombreApp { get; private set; }

        public void RolesNegocio(int app_id, string nombreApp){
            this.app_id = app_id;
            this.nombreApp = nombreApp;
        }
    }
}