using RazorPages.Data.Abstract;
using RazorPages.Models;

namespace RazorPages.Data.Concreate.EfCore
{
    public class EfEmployeeRepository:IEmployeeRepository
    {
        private readonly DataContext _context;
        public EfEmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAll => _context.Employees;
        public Employee? GetById(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Employee? Update(Employee entity)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == entity.Id);
            if (employee != null)
            {
                employee.Name = entity.Name ?? employee.Name;
                employee.Email = entity.Email ?? employee.Email;
                employee.Departmant = entity.Departmant ?? employee.Departmant;
                employee.Photo = entity.Photo ?? employee.Photo;
                _context.SaveChanges();
            }
            return employee;
        }
    }
}
