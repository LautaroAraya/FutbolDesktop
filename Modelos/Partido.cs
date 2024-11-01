using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FutbolDesktop.Modelos
{
    public class Partido
    {
        public int Id { get; set; }
        public string EquipoLocal { get; set; } = string.Empty;
        public string EquipoVisitante { get; set; } = string.Empty;
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return EquipoLocal;
        }
    }
}
