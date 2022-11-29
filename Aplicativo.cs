using System;

namespace Aplicacion_1
{
    public class Aplicativo
    {
        public string app_id { get; private set; }
        public string nombreApp { get; private set; }

        public Aplicativo(string app_id, string nombreApp){
            this.app_id = app_id;
            this.nombreApp = nombreApp;
        }
    }
}