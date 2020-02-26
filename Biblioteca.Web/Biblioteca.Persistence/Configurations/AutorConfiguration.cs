using Biblioteca.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Persistence.Configurations
{
    public class AutorConfiguration : EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
        {
            this.ToTable("Autor");
            this.HasKey(e => e.IdAutor);
        }
    }
}
