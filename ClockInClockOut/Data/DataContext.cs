using Microsoft.EntityFrameworkCore;

namespace ClockInClockOut.Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { IdNumber = 1995, FirstName ="Damian", LastName ="Wint", IsClockedIN = false },
                new Employee { IdNumber = 2020, FirstName = "Franka", LastName = "Choi", IsClockedIN = false },
                new Employee { IdNumber = 1234, FirstName = "Arian", LastName = "Samuel", IsClockedIN = false }

                );

            modelBuilder.Entity<Record>().HasData(
                new Record { ItemNumber = 1, IdNumber = 1995, EmployeeName = "Damian Wint", ClockInTime= DateTime.MinValue, ClockOutTime= DateTime.MinValue, TotalHoursWorked =0.0},
                new Record { ItemNumber = 2, IdNumber = 2020, EmployeeName = "Franka Choi", ClockInTime = DateTime.MinValue, ClockOutTime = DateTime.MinValue, TotalHoursWorked = 0.0 },
                new Record { ItemNumber = 3, IdNumber = 1234, EmployeeName = "Arian Samuel", ClockInTime = DateTime.MinValue, ClockOutTime = DateTime.MinValue, TotalHoursWorked = 0.0 }

                );


        }


        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<Record> Records => Set<Record>();
    }
}
