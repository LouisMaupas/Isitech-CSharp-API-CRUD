using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext // hot copy de la bdd
{
    // on utilise le constructeur de la class mère
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) // on appelle le constructeur de la class mère 
    {

    }

    public DbSet<Hero> Heroes { get; set; } // on fait une ligne par table
    public DbSet<Villain> Villains { get; set; }
    public DbSet<Country> Countries { get; set; } 
}