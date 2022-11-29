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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userId = this.userText.Text;
            string password = this.password.Text;


            //var form = new Form1(Logica.LoginHashPass(userId, password));
            //Usuario user = Logica.Login(userId, password);
            Usuario user = Logica.LoginHashPass(userId, password);
            if(user == null){
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
            else{
            var form = new Form1(user);
            var form3 = new Form5();
            form3.ShowDialog();
            form.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form8 = new Form8();
            form8.ShowDialog();
        }
    }
}
