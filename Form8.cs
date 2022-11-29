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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userId.Text == "" || userId==null){
                MessageBox.Show("Debe ingresar un usuario");
            }
            else{
                Usuario user = Logica.getUser(userId.Text);
                if(user == null){
                    MessageBox.Show("El usuario no existe");
                }
                else{
                    Form7 form7= new Form7(user);
                    this.Hide();
                    form7.Show();
                }
            }
        }
    }
}
