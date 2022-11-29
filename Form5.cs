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
    public partial class Form5 : Form
    {
        private LinkedList<Pregunta> preguntas = new LinkedList<Pregunta>();
        private LinkedList<Aplicativo> aplicativos = null;
        public Form5()
        {
            InitializeComponent();
            getQuestions();
            getRoles();
            setAplicativos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.crearUsuario();
        }

        private void getRoles()
        {
            LinkedList<RolesNegocio> roles = Logica.GetRoles();

            foreach(RolesNegocio rol in roles)
            {
                this.rolesGrid.Rows.Add(rol.descripcion_rol_neg);
            }
        }

        private void setAplicativos()
        {
            this.aplicativos = Logica.GetApps();

            foreach (Aplicativo app in this.aplicativos)
            {
                this.aplicativosGrid.Rows.Add(false, app.nombreApp);
            }
        }

        private LinkedList<string> getAppId()
        {
            LinkedList<string> apps = new LinkedList<string>();

            foreach (DataGridViewRow row in this.aplicativosGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    foreach (Aplicativo app in this.aplicativos)
                    {
                        if(app.nombreApp == row.Cells[1].Value.ToString())
                        {
                            apps.AddLast(app.app_id);
                        }
                    }
                }
            }
            return apps;
        }

        private LinkedList<Pregunta> getQuestions(){
            Dictionary<int, string> preguntas = Logica.GetQuestions();
            LinkedList<Pregunta> preguntasList = new LinkedList<Pregunta>();
            foreach(KeyValuePair<int, string> pregunta in preguntas){
                Pregunta p = new Pregunta(pregunta.Key, pregunta.Value);
                preguntasList.AddLast(p);
            }
            foreach(Pregunta p in preguntasList){
                this.pregunta1.Items.Add(p.pregunta);
                this.pregunta2.Items.Add(p.pregunta);
                this.pregunta3.Items.Add(p.pregunta);
            }
            this.preguntas = preguntasList;
            this.pregunta1.Text=preguntasList.ElementAt(0).pregunta;
            this.pregunta2.Text=preguntasList.ElementAt(1).pregunta;
            this.pregunta3.Text=preguntasList.ElementAt(2).pregunta;
            string[] preguntas1 = new string[2];
            string[] preguntas2 = new string[2];
            string[] preguntas3 = new string[2];
            foreach(string pregunta in pregunta1.Items){
                if(pregunta == pregunta2.Text){
                    preguntas1[0] = pregunta;
                }
                if(pregunta == pregunta3.Text){
                    preguntas1[1] = pregunta;
                }
            }
            foreach(string pregunta in pregunta2.Items){
                if(pregunta == pregunta1.Text){
                    preguntas2[0] = pregunta;
                }
                if(pregunta == pregunta3.Text){
                    preguntas2[1] = pregunta;
                }
            }
            foreach(string pregunta in pregunta3.Items){
                if(pregunta == pregunta1.Text){
                    preguntas3[0] = pregunta;
                }
                if(pregunta == pregunta2.Text){
                    preguntas3[1] = pregunta;
                }
            }
            foreach(string pregunta in preguntas1){
                this.pregunta1.Items.Remove(pregunta);
                this.pregunta1.Items.Remove(pregunta);
            }
            foreach(string pregunta in preguntas2){
                this.pregunta2.Items.Remove(pregunta);
                this.pregunta2.Items.Remove(pregunta);
            }
            foreach(string pregunta in preguntas3){
                this.pregunta3.Items.Remove(pregunta);
                this.pregunta3.Items.Remove(pregunta);
            }
            return preguntasList;
        }

        private void reloadQuestions(string preguntasX, string pregunta){
            if(preguntasX == "pregunta1"){
                this.pregunta2.Items.Clear();
                this.pregunta3.Items.Clear();
                foreach(Pregunta p in preguntas){
                    if(p.pregunta != pregunta1.Text){
                        this.pregunta2.Items.Add(p.pregunta);
                        this.pregunta3.Items.Add(p.pregunta);
                    }
                }
                this.pregunta1.Text=pregunta;
            }

            else if(preguntasX == "pregunta2"){
                this.pregunta1.Items.Clear();
                this.pregunta3.Items.Clear();
                foreach(Pregunta p in preguntas){
                    if(p.pregunta != this.pregunta2.Text){
                        this.pregunta1.Items.Add(p.pregunta);
                        this.pregunta3.Items.Add(p.pregunta);
                    }
                }
                this.pregunta2.Text=pregunta;
            }
            else if(preguntasX == "pregunta3"){
                this.pregunta1.Items.Clear();
                this.pregunta2.Items.Clear();
                foreach(Pregunta p in preguntas){
                    if(p.pregunta != this.pregunta3.Text){
                        this.pregunta2.Items.Add(p.pregunta);
                        this.pregunta1.Items.Add(p.pregunta);
                    }
                }
                this.pregunta3.Text=pregunta;
            }
            
        }
        
        private int getIdPregunta( string textoPregunta){
            foreach(Pregunta p in preguntas){
                if(p.pregunta == textoPregunta){
                    return p.preg_id;
                }
            }
            return -1;
        }





        private void crearUsuario() {

            if (this.pregunta1.Text != null && this.pregunta2.Text != null && this.pregunta3.Text != null &&
            this.userCI.Text != null && this.userName.Text != null && this.lastName.Text != null &&
            this.Direccion.Text != null && this.Ciudad.Text != null && this.departamento.Text != null && this.password.Text != null &&
            this.respuesta1.Text != null && this.respuesta2.Text != null && this.respuesta3.Text != null) {
                int pregunta1 = getIdPregunta(this.pregunta1.Text);
                int pregunta2 = getIdPregunta(this.pregunta2.Text);
                int pregunta3 = getIdPregunta(this.pregunta3.Text);

                string respuesta1 = this.respuesta1.Text;
                string respuesta2 = this.respuesta2.Text;
                string respuesta3 = this.respuesta3.Text;

                int ci = Int32.Parse(this.userCI.Text);
                string nombres = this.userName.Text;
                string apellidos = this.lastName.Text;
                string direccion = this.Direccion.Text;
                string ciudad = this.Ciudad.Text;
                string departamento = this.departamento.Text;
                string password = this.password.Text;

                Logica.CreateUser(ci, nombres, apellidos, direccion, ciudad, departamento, password);
                //create response
                Logica.CreateResponse(ci, pregunta1, respuesta1);
                Logica.CreateResponse(ci, pregunta2, respuesta2);
                Logica.CreateResponse(ci, pregunta3, respuesta3);

                LinkedList<string> appIds = this.getAppId();

                int role = Int32.Parse(this.rolesGrid.SelectedCells[0].Value.ToString());               
                foreach(string appId in appIds){
                    Logica.CreatePermiso(ci, appId, role, DateTime.Now, null, false);
                }


            }else{
                MessageBox.Show("Debe seleccionar una pregunta para cada campo");
            }


            //create user

                

            
            
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void pregunta1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.reloadQuestions("pregunta1", this.pregunta1.Text);
        }

        private void pregunta2_SelectedValueChanged(object sender, EventArgs e)
        {
            this.reloadQuestions("pregunta2", this.pregunta2.Text);
        }

        private void pregunta3_SelectedValueChanged(object sender, EventArgs e)
        {
            this.reloadQuestions("pregunta3", this.pregunta3.Text);
        }

        private void pregunta1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
