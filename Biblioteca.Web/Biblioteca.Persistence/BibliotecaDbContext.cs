using Biblioteca.Application.Infrastructure;
using Biblioteca.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence
{
    public class BibliotecaDbContext: DbContext, IBibliotecaDbContext
    {
        //enable-migrations
        //add-migration InitialCreate
        //update-database

        public BibliotecaDbContext() : base("BibliotecaConexion")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new EstudianteConfiguration());
            modelBuilder.Configurations.Add(new LibroConfiguration());
            modelBuilder.Configurations.Add(new PrestamoConfiguration());
            modelBuilder.Configurations.Add(new LibAutConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Biblioteca.Domain.Entities.Autor> Autors { get; set; }
    }
}
