using DataModel.Entity;
using System.Collections.Generic;

namespace Contracts
{
    public interface IEmployee
    {
        public int Create(Employee employee);
        public List<Employee> GetAll();
        public Employee GetByCondition(int id);
        public bool Update(int id, Employee employee);
        public bool Delete(int id);
    }
}
