using System;

namespace Aplicacion_1
{
    public class Permiso
    {
        public int user_id { get; set; }
        public string app_id { get; set; }
        public int rol_neg_id { get; set; }
        public DateTime fecha_solicitud { get; set; }
        public DateTime? fecha_autorizacion { get; set; }
        public bool estado { get; set; }

        public Permiso(int user_id, string app_id, int rol_neg_id, DateTime fecha_solicitud,
            DateTime? fecha_autorizacion, bool estado)
        {
            this.user_id = user_id;
            this.app_id = app_id;
            this.rol_neg_id = rol_neg_id;
            this.fecha_solicitud = fecha_solicitud;
            this.fecha_autorizacion = fecha_autorizacion;
            this.estado = estado;

        }

    }
}