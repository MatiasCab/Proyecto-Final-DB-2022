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


            var form = new Form1(Logica.LoginHashPass(userId, password));
            var form3 = new Form5();
            form3.ShowDialog();
            form.ShowDialog();
        }
    }
}
