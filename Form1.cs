using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Permiso> permisos = MySQLHandler.getInstance().RetrieveData();

            this.dataGridVPermisos.Rows.Clear();

            foreach (Permiso permiso in permisos)
            {
                this.dataGridVPermisos.Rows.Add(permiso.user_id, permiso.app_id, permiso.rol_neg_id, permiso.fecha_solicitud, permiso.fecha_autorizacion == null ? "NULL" : permiso.fecha_autorizacion.ToString(), permiso.estado);
            }
        }
    }
}
 