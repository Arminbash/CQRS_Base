using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Application.Infrastructure
{
    public interface IBibliotecaDbContext : IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        int SaveChanges();
    }
}
