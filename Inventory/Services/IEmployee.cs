using Inventory.Models;

namespace Inventory.Services
{
    public interface IEmployee
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee> Create(Employee employee);
        Task<Employee> GetById(int id);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}
