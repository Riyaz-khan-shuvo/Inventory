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
        private readonly EmployeeServices _emp;
        public EmployeeController(EmployeeServices emp)
        {
            _emp = emp;
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _emp.GetAll();
        }
    }
}
