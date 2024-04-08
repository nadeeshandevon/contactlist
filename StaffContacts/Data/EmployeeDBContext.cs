using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Entity;

namespace WinFormsApp1.Data
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<EmployeeMaster> EmployeeMaster { get; set; }
        public DbSet<StaffType> StaffType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=StaffContacts.sqlite3");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffType>().HasData(
                   new StaffType()
                   {
                       StaffTypeId = 1,
                       Name = "Manager"
                   },
                   new StaffType()
                   {
                       StaffTypeId = 2,
                       Name = "Employee"
                   }
            );
        }
    }
}
