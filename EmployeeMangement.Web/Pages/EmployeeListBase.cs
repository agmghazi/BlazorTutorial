using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeMangement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployee);
        }

        private void LoadEmployee()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee()
            {
                EmployeeId = 1,
                FirstName = "Ahmed Gamal",
                LastName = "Ghazi",
                Email = "aaa@gmail.com",
                DateofBirth = new DateTime(1992, 7, 1),
                Department = new Department { DepartmentId = 1, DepartmentName = "GIS" },
                Gender = Gender.Male,
                PhotoPath = "Images/1.jpg"
            };
            Employee e2 = new Employee()
            {
                EmployeeId = 2,
                FirstName = "Ayman Gamal",
                LastName = "Ghazi",
                Email = "bbb@gmail.com",
                DateofBirth = new DateTime(1996, 9, 1),
                Department = new Department { DepartmentId = 2, DepartmentName = "Web" },
                Gender = Gender.Male,
                PhotoPath = "Images/2.jpg"
            };
            Employee e3 = new Employee()
            {
                EmployeeId = 3,
                FirstName = "Eslam Gamal",
                LastName = "Ghazi",
                Email = "sss@gmail.com",
                DateofBirth = new DateTime(2002, 10, 1),
                Department = new Department { DepartmentId = 1, DepartmentName = "GIS" },
                Gender = Gender.Male,
                PhotoPath = "Images/3.jpg"
            };
            Employee e4 = new Employee()
            {
                EmployeeId = 4,
                FirstName = "Ali Mohamed",
                LastName = "Abdo",
                Email = "mmm@gmail.com",
                DateofBirth = new DateTime(1995, 7, 1),
                Department = new Department { DepartmentId = 1, DepartmentName = "GIS" },
                Gender = Gender.Male,
                PhotoPath = "Images/4.jpg"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
