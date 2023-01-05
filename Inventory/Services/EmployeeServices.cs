using Inventory.Data;
using Inventory.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Services
{
    public class EmployeeServices : IEmployee
    {
        private readonly HRMDbContext _context;
        public EmployeeServices(HRMDbContext context)
        {
            _context = context;
        }
        public async Task<Employee> Create(Employee emplolyee)
        {
            _context.Employees.Add(emplolyee);
            await _context.SaveChangesAsync();
            return emplolyee;
        }

        public async Task Delete(int id)
        {
            var emp = await _context.Employees.FindAsync(id);
            _context.Remove(emp);
            await _context.SaveChangesAsync();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task Update(Employee employee)
        {
            _context.Entry(employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
