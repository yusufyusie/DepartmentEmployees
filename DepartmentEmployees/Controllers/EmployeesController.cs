using Contracts;
using DataModel.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployee _employeeService;
        public EmployeesController(IEmployee employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public List<Employee> Get()
        {
            return _employeeService.GetAll();
        }
        [HttpPost]
        public int Create(Employee employee)
        {
            return _employeeService.Create(employee);
        }
        [HttpPut]
        public bool Update(int id, Employee employee)
        {
            return _employeeService.Update(id, employee);
        }
        [HttpDelete]
        public bool Delete(int id)
        {
            return _employeeService.Delete(id);
        }
    }
}