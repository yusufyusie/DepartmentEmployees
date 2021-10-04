using Contracts;
using DataModel;
using DataModel.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    public class EmployeeRepository : IEmployee
    {
        private readonly RepositoryDbContext _DbContext;
        public EmployeeRepository(RepositoryDbContext dbContext)
        {
            _DbContext = dbContext;

        }
        public int Create(Employee employee)
        {
            _DbContext.Employees.Add(employee);
            _DbContext.SaveChanges();
            return employee.EmployeeId;

        }

        public bool Delete(int id)
        {
            var old = _DbContext.Employees.Find(id);
            if (old != null)
            {
                _DbContext.Employees.Remove(old);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Employee> GetAll()
        {
            return _DbContext.Employees.ToList();
        }

        public Employee GetByCondition(int id)
        {
            return _DbContext.Employees.Find(keyValues: id);
        }

        public bool Update(int id, Employee employee)
        {
            var existing = _DbContext.Employees.Find(id);
            if (existing != null)
            {
                existing.FirstName = employee.FirstName;
                existing.LastName = employee.LastName;
                existing.Gender = employee.Gender;
                existing.Age = employee.Age;
                existing.BirthDate = employee.BirthDate;
                _DbContext.Employees.Update(existing);
                _DbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
