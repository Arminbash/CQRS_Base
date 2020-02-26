using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Domain.Entities
{
    public class Estudiante
    {
        public Estudiante()
        {
            Prestamos = new HashSet<Prestamo>();
        }
        public int IdLector { get; set; }
        public string CI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Carrera { get; set; }
        public int Edad { get; set; }

        public ICollection<Prestamo> Prestamos { get; private set; }

    }
}
