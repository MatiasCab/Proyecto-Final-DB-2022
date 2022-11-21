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

        private Usuario user;
        public Form1(Usuario user)
        {
            this.user = user;
            InitializeComponent();
            this.setData(user);
        }

        private void setData(Usuario user)
        {
            var aplicativos = user.rolesNegocio.Values;
            var roles = user.rolesNegocio.Keys;

            foreach(var aplicativo in aplicativos)
            {
                foreach(var app in aplicativo)
                {
                    this.aplicativosGrid.Rows.Add(app);
                }
            }

            foreach(var role in roles)
            {
                this.rolesGrid.Rows.Add(role);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //List<Permiso> permisos = MySQLHandler.getInstance().RetrieveData();

           // this.dataGridVPermisos.Rows.Clear();

            //foreach (Permiso permiso in permisos)
            //{
                //this.dataGridVPermisos.Rows.Add(permiso.user_id, permiso.app_id, permiso.rol_neg_id, permiso.fecha_solicitud, permiso.fecha_autorizacion == null ? "NULL" : permiso.fecha_autorizacion.ToString(), permiso.estado);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rolesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 