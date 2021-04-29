using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using simpleapi.Interfaces;
using simpleapi.Models;

namespace simpleapi.Controllers
{
    [ApiController]
    [Route("v1/api/[controller]")]
    public class TestCtrl : Controller
    {
        private readonly IEmployeeInfo _employeeInfo;


        public TestCtrl(IEmployeeInfo employeeInfo)
        {
            _employeeInfo = employeeInfo;
        }


        [HttpGet()]
        public async Task<ActionResult<IEnumerable<EmployeeInfo>>> GetAllEmployee()
        {
            var data = await _employeeInfo.GetAllEmployee();
            return Ok(data);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult> GetEmployeeById(int id)
        {
            var data = await _employeeInfo.GetEmployeeById(id);
            return Ok(data);
        }
        
        [HttpPost]
        public async Task<ActionResult> AddEmployee(EmployeeInfo employee)
        {
                       
            var data = await _employeeInfo.SaveEmployeeInfo(employee);
            return Ok(data);
        }
        
        [HttpPut()]
        public async Task<ActionResult> UpdateDesignation(EmployeeInfo employee)
        {
   

            var dataUpdated = await _employeeInfo.UpdateEmployeeInfo(employee);
            return Ok(dataUpdated);
        }
        
        
        [HttpDelete()]
        public async Task<ActionResult> DeleteEmployee(EmployeeInfo employeeInfo)
        {
            
            var data = await _employeeInfo.DeleteEmployee(employeeInfo);
            return Ok();

   
         
        }
    }
}