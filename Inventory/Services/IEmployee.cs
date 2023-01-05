using Inventory.Models;

namespace Inventory.Services
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetAll();// All Employee Display
        Task<Employee> Create(Employee emplolyee);// Inser Employee Data
        Task<Employee> GetById(int id);// Display Employee ID
        Task Update(Employee employee);// Update Employee
        Task Delete(int id);// Delete Employee
    }
}
