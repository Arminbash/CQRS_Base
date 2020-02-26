using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdLector { get; set; }
        public int IdLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }

        public Estudiante Estudiante { get; set; }
        public Libro Libro { get; set; }
    }
}
