using Movies.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movies.Core.Service
{
    public interface IDepartmentService
    {
        public List<Department> GetDepartment();
        public bool InsertDepartment(Department Department);
        public bool UpdateDepartment(Department Department);
        public bool DeleteDepartment(int id);
    }
}
