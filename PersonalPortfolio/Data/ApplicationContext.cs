using Microsoft.EntityFrameworkCore;

namespace Data{
    public class ApplicationContext : DbContext
    {
        public DbSet<Proyect> Proyects {get;set;}
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
    }
}