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
    public partial class Form7 : Form
    {
        Usuario user;

        LinkedList<PersonasPregunta> personasPregunta = null;
        LinkedList<Pregunta> preguntas = new LinkedList<Pregunta>();

        public Form7(Usuario user)
        {
            InitializeComponent();
            this.user = user;
            loadQuestions();
        }

        private void loadQuestions()
        {
           this.personasPregunta = Logica.GetPersonasPreguntas(user.userId);
            
            foreach (PersonasPregunta pp in personasPregunta)
            {
                Pregunta pregunta = Logica.GetPreguntaById(pp.preg_id);
                if (pregunta != null)
                {
                    this.preguntas.AddLast(pregunta);
                    comboBox1.Items.Add(pregunta.pregunta);
                }
            }
            comboBox1.SelectedValue=this.preguntas.First.Value.pregunta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox1.Text==null)
            {
                MessageBox.Show("Debe ingresar una respuesta");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una pregunta");
                return;
            }
            string respuesta = textBox1.Text;
            string pregunta = comboBox1.SelectedItem.ToString();
            int preg_id = 0;
            foreach (Pregunta p in preguntas)
            {
                if (p.pregunta == pregunta)
                {
                    preg_id = p.preg_id;
                    break;
                }
            }
            PersonasPregunta pp = null;
            foreach (PersonasPregunta ppx in personasPregunta)
            {
                if (ppx.preg_id == preg_id)
                {
                    pp = ppx;
                    break;
                }
            }
            if (pp.respuesta == respuesta)
            {
                this.Close();
                Form9 form9 = new Form9(this.user);
                form9.Show();
            }
            else
            {
                MessageBox.Show("Respuesta incorrecta");
            }

        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }

    }
}
