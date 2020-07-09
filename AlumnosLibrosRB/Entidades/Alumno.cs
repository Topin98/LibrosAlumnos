using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlumnosLibrosRB.Entidades
{
    public class Alumno
    {
        public int IDAlumno { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        private string curso;
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string Observaciones { get; set; }
        public bool Bilingue { get; set; }
        public bool Becario { get; set; }
        public int Expediente { get; set; }
        public bool Activo { get; set; }
        public List<int> lNumRegistros = new List<int>();

        public string Curso
        {
            set
            {
                try
                {
                    if (value.Length == 3 && Char.IsNumber(value[0]) && value[1] == 'º' && Char.IsLetter(value[2]))
                    {
                        this.curso = value;
                    }
                    else throw new Exception();
                }
                catch (Exception)
                {
                    throw new Exception("Curso no válido");
                }
            }
            get { return this.curso; }
        }

        public string NombreCompleto
        {
            get { return this.Apellidos + ", " + this.Nombre; }
        }
    }
}
