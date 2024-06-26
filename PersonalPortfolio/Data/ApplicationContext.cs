using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalProtfolio;



namespace Data{
    public class ApplicationContext : DbContext

    {
        public DbSet<Proyect> Proyects {get;set;}
            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Proyect>()
                .Property(a => a.TechnologyEnum)
                .HasConversion(new EnumToStringConverter<TechnologiesEnum>());
        }
    }
}