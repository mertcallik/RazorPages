using Microsoft.EntityFrameworkCore;
using RazorPages.Models;

namespace RazorPages.Data.Concreate.EfCore
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique();

            modelBuilder.Entity<Employee>().HasData(new List<Employee>()
            {
                new Employee()
                {
                    Id = 1, Name = "Mert Çalık", Departmant = "It", Email = "mertclkdev@gmail.com", Photo = "mert.jpg"
                },
                new Employee()
                {
                    Id = 2, Name = "Casper", Departmant = "Security", Email = "casper@gmail.com", Photo = "casper.jpeg"
                },
                new Employee()
                {
                    Id = 3, Name = "Princess Cirilla", Departmant = "Witcher", Email = "cirilla@gmail.com",
                    Photo = "ciri.jpg"
                },
                new Employee()
                {
                    Id = 4, Name = "Geralt of Rivia", Departmant = "Witcher", Email = "geralt@gmail.com",
                    Photo = "geralt.jpg"
                },
            });
        }
        public DbSet<Employee> Employees => Set<Employee>();

    }
}
