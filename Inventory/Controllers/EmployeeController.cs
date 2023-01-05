using Inventory.Models;
using Inventory.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _emp;
        public EmployeeController(IEmployee emp)
        {
            _emp = emp;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            return await _emp.GetAll();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetById(int id)
        {
            return await _emp.GetById(id);
        }

        [HttpPost]
        public async Task<ActionResult<Employee>> Create(Employee emp)
        {
            await _emp.Create(emp);
            return CreatedAtAction(nameof(GetById), new { emp.Id }, emp);
        }

        [HttpPut]
        public async Task<ActionResult> Update(int id, Employee emp)
        {
            if (id != emp.Id)
            {
                return BadRequest();
            }
            await _emp.Update(emp);
            return NoContent();

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var emp = await _emp.GetById(id);
            if (emp != null)
            {
                return NotFound();
            }
            await _emp.Delete(emp.Id);
            return NoContent();

        }
    }
}
