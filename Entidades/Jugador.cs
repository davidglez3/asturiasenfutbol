using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Jugador
    {
        public int identificador { get; set; }
        public string posicion { get; set; }
        public string nombre { get; set; }
        public string apodo { get; set; }
        public int dorsal { get; set; }
        public int goles { get; set; }
        public int minutos_jugados { get; set; }
        public int partidos_jugados { get; set; }
        public int partidos_titular { get; set; }
        public int partidos_suplente { get; set; }
        public int identificador_equipo { get; set; }
        public int identificador_imagen { get; set; }
        public DateTime fecha_nacimiento { get; set; }

    }
}
