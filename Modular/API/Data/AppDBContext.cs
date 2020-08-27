using Bussiness_Logic.Models;
using Bussiness_Logic.Models.Afiliations;
using Bussiness_Logic.Models.Col;
using Bussiness_Logic.Models.Complements;
using Bussiness_Logic.Models.Employee;
using Bussiness_Logic.Models.Providers;
using Bussiness_Logic.Models.Users;
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

        //UsersDbSet
        public DbSet<Users> Users { get; set; }
        public DbSet<UsersType> UsersType { get; set; }

        //ProvidersDbSet
        public DbSet<Providers> Providers { get; set; }
        public DbSet<ProvidersType> ProvidersType { get; set; }

        //EmployeeDbSet
        public DbSet<Employees> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
        public DbSet<Departments> Departments {get; set;}
        public DbSet<Employee_Cities> Employee_Cities { get; set; }

        //ColDbSet
        public DbSet<DepartmentsCol> DepartmentsCols { get; set; }
        public DbSet<CitiesCol> CitiesCols { get; set; }

        //AfiliationsDbSet
        public DbSet<Afiliation> Afiliation { get; set; }
        public DbSet<AFP> AFP { get; set; }
        public DbSet<ARL> ARL { get; set; }
        public DbSet<EPS> EPS { get; set; }
        public DbSet<CCF> CCF { get; set; }

        //ComplementsDbSet
        public DbSet<Internal_Information> Internal_Information { get; set; }
        public DbSet<StatusCivil> StatusCivil { get; set; }
        public DbSet<TypeCity> TypeCity { get; set; }
        public DbSet<TypeDocument> TypeDocument { get; set; }


        //public DbSet<Logs> Logs { get; set; }
        //public DbSet<Lending> Lendings { get; set; }
        //public DbSet<Ubication> Ubications { get; set; }
        //public DbSet<Equipment> Equipments { get; set; }
        //public DbSet<EquipmentType> EquipmentTypes { get; set; }
        //public DbSet<Mantenaince> Mantenainces { get; set; }
        //public DbSet<Purchase> Purchases { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Users
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<UsersType>().ToTable("UsersType");
            
            //Providers
            modelBuilder.Entity<Providers>().ToTable("Providers");
            modelBuilder.Entity<ProvidersType>().ToTable("ProvidersType");
            
            //Employees
            modelBuilder.Entity<Employees>().ToTable("Employees");
            modelBuilder.Entity<EmployeeType>().ToTable("EmployeeTypes");
            modelBuilder.Entity<Departments>().ToTable("DepartmentsEmp");
            modelBuilder.Entity<Employee_Cities>().ToTable("Employee_Cities");

            //Col
            modelBuilder.Entity<DepartmentsCol>().ToTable("DepartmentsCols");
            modelBuilder.Entity<CitiesCol>().ToTable("CitiesCols");

            //Afiliations
            modelBuilder.Entity<Afiliation>().ToTable("Afiliations");
            modelBuilder.Entity<AFP>().ToTable("AFP");
            modelBuilder.Entity<ARL>().ToTable("ARL");
            modelBuilder.Entity<EPS>().ToTable("EPS");
            modelBuilder.Entity<CCF>().ToTable("CCF");

            //Complements

            modelBuilder.Entity<Internal_Information>().ToTable("Internal_Information");
            modelBuilder.Entity<StatusCivil>().ToTable("StatusCivil");
            modelBuilder.Entity<TypeCity>().ToTable("TypeCity");
            modelBuilder.Entity<TypeDocument>().ToTable("TypeDocument");


            //modelBuilder.Entity<Logs>().ToTable("Logs");
            //modelBuilder.Entity<Lending>().ToTable("Lendings");
            //modelBuilder.Entity<Ubication>().ToTable("Ubications");
            //modelBuilder.Entity<Equipment>().ToTable("Equipments");
            //modelBuilder.Entity<EquipmentType>().ToTable("EquipmentTypes");
            //modelBuilder.Entity<Mantenaince>().ToTable("Mantenainces");
            //modelBuilder.Entity<Purchase>().ToTable("Purchases");

        }

    }
}