using DataModel.Entity;
using System.Collections.Generic;

namespace Contracts
{
    public interface IDepartment
    {
        public int Create(Department department);
        public List<Department> GetAll();
        public Department Get(int id);
        public bool Update(int id, Department department);
        public bool Delete(int id);
    }
}
