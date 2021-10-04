using Contracts;
using DataModel;
using DataModel.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class DepartmentRepository : IDepartment
    {
        private readonly RepositoryDbContext _DbContext;
        public DepartmentRepository(RepositoryDbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public int Create(Department department)
        {

            _DbContext.Departments.Add(department);
            _DbContext.SaveChanges();
            return department.DepartmentId;
        }

        public bool Delete(int id)
        {
            var exist = _DbContext.Departments.Find(id);
            if (exist != null)
            {
                _DbContext.Departments.Remove(exist);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Department Get(int id)
        {
            return _DbContext.Departments.Find(keyValues: id);
        }

        public List<Department> GetAll()
        {
            return _DbContext.Departments.ToList();
        }

        public bool Update(int id, Department department)
        {
            var old = _DbContext.Departments.Find(id);
            if (old != null)
            {
                old.DepartmentId = department.DepartmentId;
                old.DepartmentName = department.DepartmentName;
                old.Location = department.Location;
                _DbContext.Departments.Update(old);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
