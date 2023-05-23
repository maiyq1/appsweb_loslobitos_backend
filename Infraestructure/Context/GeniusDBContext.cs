using Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Context;

public class GeniusDBContext : DbContext
{
    public GeniusDBContext()
    {
        
    }

    public GeniusDBContext(DbContextOptions<GeniusDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Client> Clients { get; set; }
    
    //Configuracion
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql("Server=localhost,3306;Uid=root;Pwd=FamiliaYenQ01|;Database=geniusdatabase;", serverVersion);
        }
    }
    
    //Tablas
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Client>().ToTable("Clients");
        builder.Entity<Client>().HasKey(p => p.Id);
        builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Client>().Property(c => c.Name).IsRequired().HasMaxLength(30);
        builder.Entity<Client>().Property(t => t.Phone).IsRequired().HasMaxLength(9);
        builder.Entity<Client>().Property(e => e.Email).HasMaxLength(50);

        builder.Entity<Reservation>().ToTable("Reservations");
        builder.Entity<Reservation>().HasKey(p => p.Id);
        builder.Entity<Reservation>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Reservation>().Property(c => c.Placa).IsRequired().HasMaxLength(7);
        builder.Entity<Reservation>().Property(d => d.Place).HasMaxLength(10);
        builder.Entity<Reservation>().Property(b => b.isPaid);
        builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();


    }
}