namespace Aplicacion_1
{
    public class PersonasPregunta
    {
        public int ci { get; set; }
        public int preg_id { get; set; }
        public string respuesta { get; set; }

        public PersonasPregunta(int ci, int preg_id, string respuesta)
        {
            this.ci = ci;
            this.preg_id = preg_id;
            this.respuesta = respuesta;
        }


    }
}