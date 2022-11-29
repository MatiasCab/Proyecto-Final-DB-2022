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
            this.setAplicativosData();
        }

        private void setData(Usuario user)
        {
            var aplicativos = user.rolesNegocio.Values;
            var roles = user.rolesNegocio.Keys;

            foreach (var role in roles)
            {
                this.rolesGrid.Rows.Add(role);
            }

        }

        private void setAplicativosData()
        {
            this.aplicativosGrid.Rows.Clear();

            int selectedCellCount = this.rolesGrid.GetCellCount(DataGridViewElementStates.Selected);

            string rolCell = "";

            if (selectedCellCount > 0)
            {
                rolCell = this.rolesGrid.SelectedCells[0].Value.ToString();
            }
            else
            {
                rolCell = this.rolesGrid.Rows[0].Cells[0].Value.ToString();
            }

            LinkedList<string> aplicativos = new LinkedList<string>();

            this.user.rolesNegocio.TryGetValue(rolCell, out aplicativos);

            foreach (var app in aplicativos)
            {
                this.aplicativosGrid.Rows.Add(app);
            }
        }

        private void rolesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.setAplicativosData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aplicativosGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string rolCell = this.rolesGrid.SelectedCells[0].Value.ToString();
            string aplicativoCell = this.aplicativosGrid.SelectedCells[0].Value.ToString();

            var form = new Form4(aplicativoCell, rolCell);
            form.ShowDialog();
        }
    }
}
 