using Microsoft.EntityFrameworkCore;
using RentCar.Data.Entities;
using System.ComponentModel.Design;

namespace RentCar.Data
{
    public class RentCarDbContext:DbContext
    {
        public RentCarDbContext()
        {

        }
        public RentCarDbContext(DbContextOptions<RentCarDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<CType> Types { get; set; } = null!;
        public virtual DbSet<Car_Type> Car_Types { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Office> Offices { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;
        public virtual DbSet<Admin> Admins { get; set; }=null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=RentCarDb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Car_Type>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<CType>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Customer>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Office>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Reservation>().Property(x => x.Id).ValueGeneratedNever();
            modelBuilder.Entity<Admin>().Property(x=>x.Id).ValueGeneratedNever();
            
        }
    }
}