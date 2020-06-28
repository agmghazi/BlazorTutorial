using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Department Table
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "IT" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "HR" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Payroll" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 4, DepartmentName = "Admin" });

            //seed Employee Table
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeId = 1,
                    FirstName = "Ahmed Gamal",
                    LastName = "Ghazi",
                    Email = "aaa@gmail.com",
                    DateofBirth = new DateTime(1992, 7, 1),
                    DepartmentId = 1,
                    Gender = Gender.Male,
                    PhotoPath = "Images/1.jpg"
                });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Ayman Gamal",
                LastName = "Ghazi",
                Email = "bbb@gmail.com",
                DateofBirth = new DateTime(1996, 9, 1),
                DepartmentId = 2,
                Gender = Gender.Male,
                PhotoPath = "Images/2.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Eslam Gamal",
                LastName = "Ghazi",
                Email = "sss@gmail.com",
                DateofBirth = new DateTime(2002, 10, 1),
                DepartmentId = 1,
                Gender = Gender.Male,
                PhotoPath = "Images/3.jpg"
            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Ali Mohamed",
                LastName = "Abdo",
                Email = "mmm@gmail.com",
                DateofBirth = new DateTime(1995, 7, 1),
                DepartmentId = 2,
                Gender = Gender.Male,
                PhotoPath = "Images/4.jpg"
            });
        }
    }
}
