using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Autor
    {
        public Autor()
        {
            LibAuts = new HashSet<LibAut>();
        }
        public int IdAutor { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public ICollection<LibAut> LibAuts { get; private set; }
    }
}
