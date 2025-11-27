using backend.models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data
{
    
    public class ApplicationDbContext:DbContext

    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base (options) { 
        }

        public DbSet<Products> Productos => Set<Products>();
    }

}

