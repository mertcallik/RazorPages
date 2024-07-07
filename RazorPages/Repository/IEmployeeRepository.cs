using RazorPages.Models;

namespace RazorPages.Repository
{
    public interface IEmployeeRepository
    { 
        IEnumerable<Employee> GetAll { get; }
        Employee GetById(int id);
        Employee Update(Employee entity);
    }
}
