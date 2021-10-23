using Movies.Core.Data;
using Movies.Core.Repository;
using Movies.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Infra.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository DepartmentRepository;
        public DepartmentService(IDepartmentRepository DepartmentRepository)
        {
            this.DepartmentRepository = DepartmentRepository;
        }

        public bool DeleteDepartment(int id)
        {
            return DepartmentRepository.DeleteDepartment(id);
        }

        public List<Department> GetDepartment()
        {
            return DepartmentRepository.GetDepartment();
        }

        public bool InsertDepartment(Department Department)
        {
            return DepartmentRepository.InsertDepartment(Department);
        }

        public bool UpdateDepartment(Department Department)
        {
            return DepartmentRepository.UpdateDepartment(Department);
        }
    }
}
