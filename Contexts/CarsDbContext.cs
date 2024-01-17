using Cars.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cars.Context
{
    public class CarsDbContext:IdentityDbContext
    {

       public DbSet<Slider> Sliders {  get; set; }
       public DbSet<AppUser>AppUsers { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q9QV65T\\SQLEXPRESS;Database=Cars;Trusted_Connection=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
