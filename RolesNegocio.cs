using System;

namespace Aplicacion_1
{
    public class RolesNegocio
    {
        public int rol_neg_id { get; private set; }
        public string descripcion_rol_neg { get; private set; }

        public RolesNegocio(int rol_neg_id, string descripcion_rol_neg){
            this.rol_neg_id = rol_neg_id;
            this.descripcion_rol_neg = descripcion_rol_neg;
        }
    }
}