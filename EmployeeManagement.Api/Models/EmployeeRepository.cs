﻿using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _appDbContext;

        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployee(int employeeId)
        {
            return await _appDbContext.Employees
                .FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await _appDbContext.Employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var result = await _appDbContext.Employees
                 .FirstOrDefaultAsync(x => x.EmployeeId == employee.EmployeeId);
            if (result != null)
            {
                result.FirstName = employee.FirstName;
                result.LastName = employee.LastName;
                result.Email = employee.Email;
                result.DateofBirth = employee.DateofBirth;
                result.Gender = employee.Gender;
                result.DepartmentId = employee.DepartmentId;
                result.PhotoPath = employee.PhotoPath;
                await _appDbContext.SaveChangesAsync();
                return result;
            }

            return null;

        }

        public async void DeleteEmployee(int employeeId)
        {
            var result = await _appDbContext.Employees
                 .FirstOrDefaultAsync(x => x.EmployeeId == employeeId);
            if (result != null)
            {
                _appDbContext.Employees.Remove(result);
                await _appDbContext.SaveChangesAsync();
            }
        }
    }
}
