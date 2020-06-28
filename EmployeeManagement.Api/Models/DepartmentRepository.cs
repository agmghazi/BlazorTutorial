using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Department> GetDepartments()
        {
            return _appDbContext.Departments;
        }

        public Department GetDepartment(int departmentId)
        {
            return _appDbContext.Departments
                .FirstOrDefault(x => x.DepartmentId == departmentId);
        }
    }
}
