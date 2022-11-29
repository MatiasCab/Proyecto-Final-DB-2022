using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCryptNet = BCrypt.Net.BCrypt;

namespace Aplicacion_1
{
    public partial class Form9 : Form
    {

        Usuario user = null;

        public Form9(Usuario user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text==null)
            {
                MessageBox.Show("Debe ingresar una nueva contraseña");
            }
            else
            {
                this.user.hashpwd = BCryptNet.HashPassword(textBox1.Text);
                Logica.UpdateUser(this.user);

                MessageBox.Show("Contraseña actualizada");
                this.Hide();
            }
        }
    }
}
