using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosLibrosRB.Entidades
{
    public class Libro
    {
        public int NumRegistro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int Volumenes { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Observaciones { get; set; }
        public string Estado { get; set; }
    }
}
