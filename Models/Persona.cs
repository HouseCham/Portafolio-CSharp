namespace Portafolio.Models
{
    public class Persona
    {
        public string Nombre { get; set; } //para definir que un parametro no sea nulo, se pone un ? 
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
}
