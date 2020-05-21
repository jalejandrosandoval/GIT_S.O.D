﻿using Bussiness_Logic.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {

        }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

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
        }

    }
}
