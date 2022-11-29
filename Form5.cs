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
        public Form5()
        {
            InitializeComponent();
            getQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private LinkedList<Pregunta> preguntas = new LinkedList<Pregunta>();

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
        
        private getIdPregunta(textoPregunta){
            foreach(Pregunta p in preguntas){
                if(p.pregunta == textoPregunta){
                    return p.id;
                }
            }
            return -1;
        }
        


        private void crearUsuario(){
            string pregunta1 = getIdPregunta(this.pregunta1.Text);
            string pregunta2 = getIdPregunta(this.pregunta2.Text);
            string pregunta3 = getIdPregunta(this.pregunta3.Text);
            string respuesta1 = this.respuesta1.Text;
            string respuesta2 = this.respuesta2.Text;
            string respuesta3 = this.respuesta3.Text;

            string ci = this.userCI.Text;

            //create response
            if(ci != null){
                Logica.CreateResponse(ci, pregunta1, respuesta1);
                Logica.CreateResponse(ci, pregunta2, respuesta2);
                Logica.CreateResponse(ci, pregunta3, respuesta3);
            }
            
            //create user
            string nombres      = this.userName.Text;
            string apellidos    = this.lastName.Text;
            string direccion    = this.Direccion.Text;
            string ciudad       = this.Ciudad.Text;
            string departamento = this.departamento.Text;
            string password     = this.password.Text;
            if(ci != null && nombres != null && apellidos != null && direccion != null && ciudad != null && departamento != null && password != null){
                Logica.CreateUser(ci, nombres, apellidos, direccion, ciudad, departamento, password);
            }

            //create permiso
            
            
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
