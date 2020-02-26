using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class LibAut
    {
        public int IdLibAut { get; set; }
        public int IdAutor { get; set; }
        public int IdLibro { get; set; }

        public Autor Autor { get; set; }
        public Libro Libro { get; set; }
    }
}
