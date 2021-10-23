using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Repository
{
    public interface IDepartmentRepository
    {
        public List<Department> GetDepartment();
        public bool InsertDepartment(Department Department);
        public bool UpdateDepartment(Department Department);
        public bool DeleteDepartment(int id);
    }
}
