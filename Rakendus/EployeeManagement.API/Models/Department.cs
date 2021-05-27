using EmployeeManagement.Models;
using EployeeManagement.API.Models2;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Department GetDepartment(int departmentId)
        {
            return appDbContext.Departments
                .FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return appDbContext.Departments;
        }

        Department IDepartmentRepository.GetDepartment(int departmentId)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Department> IDepartmentRepository.GetDepartments()
        {
            throw new System.NotImplementedException();
        }
    }
}