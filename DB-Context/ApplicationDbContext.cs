using EF_SQL_Server.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EF_SQL_Server.DB_Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {


        }

        // USO DE API FLUENTE
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // aqui podemos poner las configuraciones de las tablas
            //modelBuilder.Entity<Naruto>().HasKey(n => n.Id);
            //modelBuilder.Entity<Naruto>().Property(n => n.Name).HasMaxLength(150);

            // USAR LA CONFIGURACION
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Naruto> Characters => Set<Naruto>();
        public DbSet<Jutsu> Jutsus => Set<Jutsu>();

        // CREAR MIGRACION 
        // dotnet ef migrations add Inicial en vscode
        // Add-Migration Inicial en visual studio

        // ACTUALIZAR BASE DE DATOS

        // dotnet ef database update en vscode
        // Update-Database en visual studio

        // HACER UNA NUEVA MIGRACION
        // dotnet ef migrations add NombreMigracion en vscode
        // Add-Migration NombreMigracion en visual studio

        // REMOVER MIGRACION
        // dotnet ef migrations remove en vscode
        // Remove-Migration en visual studio

        // USAR RELACIONES
        // dotnet ef migrations add Relaciones en vscode
        // Add-Migration Relaciones en visual studio
    }
}
