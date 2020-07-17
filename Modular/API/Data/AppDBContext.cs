using API.Models;
using Bussiness_Logic.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public class AppDBContext : DbContext //IdentityDbContext<ApplicationUser>
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<UsersType> UsersType { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<Ubication> Ubications { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<EquipmentType> EquipmentTypes { get; set; }
        public DbSet<Mantenaince> Mantenainces { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<ProviderType> ProvidersType { get; set; }
        public DbSet<Logs> Logs { get; set; }
        public DbSet<AssetsType> AssetsTypes { get; set; }
        public DbSet<Fixed_Assets> Fixed_Assets { get; set; }
        public DbSet<CV_Devices> CV_Devices { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<DevicesTypes> DevicesTypes { get; set; }
        public DbSet<CharacteristicsDevices> CharacteristicsDevices { get; set; }
        public DbSet<Devices_Accessories> Devices_Accessories { get; set; }
        public DbSet<Devices_Mantenaince> Devices_Mantenaince { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<UsersType>().ToTable("UsersType");
            modelBuilder.Entity<Lending>().ToTable("Lendings");
            modelBuilder.Entity<Ubication>().ToTable("Ubications");
            modelBuilder.Entity<Equipment>().ToTable("Equipments");
            modelBuilder.Entity<EquipmentType>().ToTable("EquipmentTypes");
            modelBuilder.Entity<Mantenaince>().ToTable("Mantenainces");
            modelBuilder.Entity<Purchase>().ToTable("Purchases");
            modelBuilder.Entity<Providers>().ToTable("Providers");
            modelBuilder.Entity<ProviderType>().ToTable("ProvidersType");
            modelBuilder.Entity<Logs>().ToTable("Logs");
            modelBuilder.Entity<AssetsType>().ToTable("AssetsType");
            modelBuilder.Entity<Fixed_Assets>().ToTable("Fixed_Assets");
            modelBuilder.Entity<CV_Devices>().ToTable("CV_Devices");
            modelBuilder.Entity<Departments>().ToTable("Departments");
            modelBuilder.Entity<Positions>().ToTable("Positions");
            modelBuilder.Entity<DevicesTypes>().ToTable("DevicesTypes");
            modelBuilder.Entity<CharacteristicsDevices>().ToTable("CharacteristicsDevices");
            modelBuilder.Entity<Devices_Accessories>().ToTable("Devices_Accessories");
            modelBuilder.Entity<Devices_Mantenaince>().ToTable("Devices_Mantenaince");
        }

    }
}