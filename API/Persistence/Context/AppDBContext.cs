using AppWeb_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Persisntence.Context
{
    public class AppDBContext: DbContext
    {
        public AppDBContext()
        {
        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {


        }

        public DbSet<UsersViewModel> Users { get; set; }
        public DbSet<EquipmentViewModel> Equipments { get; set; }
        public DbSet<ProvidersViewModel> Providers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UsersViewModel>().ToTable("Users");
            //modelBuilder.Entity<EquipmentViewModel>().ToTable("Equipments");
            //modelBuilder.Entity<ProvidersViewModel>().ToTable("Providers");

        }

    }
}
