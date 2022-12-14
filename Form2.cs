using MySqlX.XDevAPI.Relational;
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
    public partial class Form2 : Form
    {
        private Permiso permisoSeleccionado = new Permiso(0,null,0,DateTime.Now, new DateTime(0001, 01, 01, 00, 00, 00), false);
        public Form2()
        {
            InitializeComponent();
            this.setData();
        }

        private void setData()
        {
            this.dataGridView1.Rows.Clear();
            LinkedList<Permiso> permisos = Logica.GetPermisos();
            foreach (Permiso permiso in permisos)
            {
                this.dataGridView1.Rows.Add(permiso.user_id, permiso.app_id, permiso.rol_neg_id, permiso.fecha_solicitud, permiso.fecha_autorizacion.Year == 0001 ? "----" : permiso.fecha_autorizacion.ToString(), permiso.estado ? "Habilitado" : "Deshabilitado");
            }
        }


        private void actualizarPermiso()
        {

            DateTime fecha_autorizacion = DateTime.Now;
            this.permisoSeleccionado.fecha_autorizacion = fecha_autorizacion;
            this.permisoSeleccionado.estado = true;
            Logica.UpdatePermiso(this.permisoSeleccionado);

            this.permisoSeleccionado.fecha_autorizacion = DateTime.Now;
            this.setData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.actualizarPermiso();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int selectedCellCount = this.dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            int ciCell = 0;
            string appidCell = "";
            int rolnegCell = 0;
            DateTime fechasolicitadoCell;
            bool estadoCell = false;

            if (selectedCellCount > 0)
            {
                ciCell = Int32.Parse(this.dataGridView1.SelectedCells[0].Value.ToString());
                appidCell = this.dataGridView1.SelectedCells[1].Value.ToString();
                rolnegCell = Int32.Parse(this.dataGridView1.SelectedCells[2].Value.ToString());
                fechasolicitadoCell = Convert.ToDateTime(this.dataGridView1.SelectedCells[3].Value.ToString());
                //fecha autorizacion no es necesaria
                estadoCell = Convert.ToBoolean(this.dataGridView1.SelectedCells[5].Value.ToString() == "Habilitado");

                if (fechasolicitadoCell != null)
                {
                    this.permisoSeleccionado.user_id = ciCell;
                    this.permisoSeleccionado.app_id = appidCell;
                    this.permisoSeleccionado.rol_neg_id = rolnegCell;
                    this.permisoSeleccionado.fecha_solicitud = fechasolicitadoCell;
                    this.permisoSeleccionado.fecha_autorizacion = new DateTime(0001, 01, 01, 00, 00, 00);
                    this.permisoSeleccionado.estado = estadoCell;
                }
                else
                {
                    Console.WriteLine("ERROR AL SELECCIONAR");
                }
            }
        }
    }
}
