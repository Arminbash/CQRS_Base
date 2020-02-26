using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Libro
    {
        public Libro()
        {
            Prestamos = new HashSet<Prestamo>();
            LibAuts = new HashSet<LibAut>();
        }
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Area { get; set; }

        public ICollection<Prestamo> Prestamos { get; private set; }
        public ICollection<LibAut> LibAuts { get; private set; }
    }
}
