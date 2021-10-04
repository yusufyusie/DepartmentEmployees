using Contracts;
using DataModel.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartment _departmentService;

        public DepartmentsController(IDepartment departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpPost]
        public int Create(Department department)
        {
            return _departmentService.Create(department);
        }
        [HttpGet]
        public List<Department> GetAll()
        {
            return _departmentService.GetAll();
        }
        [HttpGet("id")]
        public Department Get(int id)
        {
            return _departmentService.Get(id);
        }
        [HttpPut]
        public bool Update(int id, Department department)
        {
            return _departmentService.Update(id, department);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _departmentService.Delete(id);
        }
    }
}
