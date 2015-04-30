using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Equipo
    {
        public int identificador { get; set; }
        public string nombre { get; set; }
        public int identificador_imagen { get; set; }
        public int identificador_liga { get; set; }
        public int puntos { get; set; }
        public int goles_favor { get; set; }
        public int goles_contra { get; set; }
        public int partidos_jugados { get; set; }

    }
}
