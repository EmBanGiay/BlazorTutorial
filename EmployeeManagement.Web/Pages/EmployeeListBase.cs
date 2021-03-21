using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Keqing",
                LastName = "",
                Email = "buffElectro@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 2, DepartmentName = "Liyue" },
                PhotoPath = "images/keqing.jpg"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Childe",
                LastName = "Tartaglia",
                Email = "Bowisweak@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 7, DepartmentName = "Snezhnaya" },
                PhotoPath = "images/childe.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Klee",
                LastName = "",
                Email = "boomboombakudan@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "Mondstadt" },
                PhotoPath = "images/klee.jpg"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Amber",
                LastName = "",
                Email = "starterbow@gmail.com",
                DateOfBirth = new DateTime(2020, 9, 28),
                Gender = Gender.Female,
                Department = new Department { DepartmentId = 1, DepartmentName = "Mondstadt" },
                PhotoPath = "images/amber.jpg"
            };

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }

    }
    
}
