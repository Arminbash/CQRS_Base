using AutoMapper;
using Biblioteca.Application.Infrastructure;
using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Execution.Commands
{
    public class CommandAutor
    {
        private readonly IBibliotecaDbContext _context;
        public CommandAutor(IBibliotecaDbContext context)
        {
            _context = context;
        }

        public bool createAutor(Autor autor)
        {
            try
            {
                _context.Set<Autor>().Add(autor);
                if (_context.SaveChanges() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool updateAutor(Autor autor)
        {
            try
            {
                var entity =  _context.Set<Autor>().FirstOrDefault(x => x.IdAutor == autor.IdAutor);

                if (entity == null)
                {
                    Console.WriteLine("No se encontro el autor.");
                    return false;
                }

                var config = new MapperConfiguration(cfg => {
                    cfg.CreateMap<Autor, Autor>();
                });
                IMapper iMapper = config.CreateMapper();


                iMapper.Map<Autor, Autor>(autor,entity);



                if (_context.SaveChanges()>0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool deleteAutor(int idAutor)
        {
            try
            {
                var entity = _context.Set<Autor>().FirstOrDefault(x => x.IdAutor == idAutor);

                if (entity == null)
                {
                    Console.WriteLine("No se encontro el autor.");
                    return false;
                }

                _context.Set<Autor>().Remove(entity);

                if (_context.SaveChanges() > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
