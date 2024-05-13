//Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
public class AppDbContext : DbContext{
  public AppDbContext (DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<R_CV.Contactos> Contactos { get; set; } = default!;}
