using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees{get;set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 1, DepartmentName = "Mondstadt" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 2, DepartmentName = "Liyue" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 3, DepartmentName = "Inazuma" });
            modelBuilder.Entity<Department>().HasData(
                new Department { DepartmentId = 7, DepartmentName = "Snezhnaya" });
            
            
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Keqing",
                LastName = "",
                Email = "buffElectro@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                DepartmentId = 2,
                PhotoPath = "images/keqing.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 2,
                FirstName = "Childe",
                LastName = "Tartaglia",
                Email = "Bowisweak@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Male,
                DepartmentId = 7,
                PhotoPath = "images/childe.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 3,
                FirstName = "Klee",
                LastName = "",
                Email = "boomboombakudan@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/klee.jpg"
            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 4,
                FirstName = "Amber",
                LastName = "",
                Email = "starterbow@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/amber.jpg"
            });
        }
    }
}
