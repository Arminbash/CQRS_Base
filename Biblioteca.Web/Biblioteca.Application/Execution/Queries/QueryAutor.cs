using Biblioteca.Application.Infrastructure;
using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Execution.Queries
{
    public class QueryAutor
    {
        private readonly IBibliotecaDbContext _context;
        public QueryAutor(IBibliotecaDbContext context)
        {
            _context = context;
        }
        public List<Autor> getAllAutores()
        {
            try
            {
                var listAutores = _context.Set<Autor>().ToList();
                return listAutores;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new List<Autor>();
            }
        }

        public Autor getAutorXId(int idAutor)
        {
            try
            {
                var autor = _context.Set<Autor>().Where(x => x.IdAutor == idAutor).FirstOrDefault();
                return autor;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return new Autor();
            }
        }
    }
}
