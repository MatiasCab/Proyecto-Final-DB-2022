using Google.Protobuf.WellKnownTypes;
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
    public partial class Form4 : Form
    {
        AplicativoRoles rolesAplicativos;
        public Form4(string app, string rol)
        {
            InitializeComponent();

            this.rolesAplicativos = Logica.GetMenuAplicativos(app, rol);

            this.showAppMenu();
            this.setMenusData();
        }
            
        private void showAppMenu()
        {
            if(this.rolesAplicativos != null)
            {
                var roles = this.rolesAplicativos.rolesApp.Keys;

                foreach (var role in roles)
                {
                    this.rolesAplicativosGrid.Rows.Add(role);
                }
            } else
            {
                this.rolesAplicativosGrid.Rows.Add("No posee ningun rol para este aplicativo.");
            }
        }

        private void setMenusData()
        {
            if(this.rolesAplicativos != null)
            {
                this.menusGrid.Rows.Clear();

                int selectedCellCount = this.rolesAplicativosGrid.GetCellCount(DataGridViewElementStates.Selected);

                string rolCell = "";

                if (selectedCellCount > 0)
                {
                    rolCell = this.rolesAplicativosGrid.SelectedCells[0].Value.ToString();
                }
                else
                {
                    if(this.rolesAplicativosGrid.Rows.Count > 0)
                    {
                        rolCell = this.rolesAplicativosGrid.Rows[0].Cells[0].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("NO HAY DATOS");
                    }
                    
                }

                LinkedList<string> menu = new LinkedList<string>();

                this.rolesAplicativos.rolesApp.TryGetValue(rolCell, out menu);

                foreach (var app in menu)
                {
                    this.menusGrid.Rows.Add(app);
                }

            } else
            {
                this.menusGrid.Rows.Add("No posee ningun menu.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menusGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(this.menusGrid.SelectedCells[0].Value.ToString() == "Autorizar permisos")
            {
                var form = new Form2();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una pregunta para cada campo");
            }
        }

        private void rolesAplicativosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setMenusData();
        }
    }
}
