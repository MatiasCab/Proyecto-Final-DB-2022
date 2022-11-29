namespace Aplicacion_1
{
    public class Pregunta
    {
        public int preg_id { get; set; }
        public string pregunta { get; set; }
        public bool display { get; set; }

        public Pregunta(int preg_id, string pregunta)
        {
            this.preg_id = preg_id;
            this.pregunta = pregunta;
            this.display = true;
        }

        public int getIdByValue( string value )
        {
            return preg_id;
        }


    }
}