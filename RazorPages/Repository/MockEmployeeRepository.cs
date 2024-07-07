using RazorPages.Models;

namespace RazorPages.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        public MockEmployeeRepository()
        {
            _employees.AddRange(new List<Employee>()
            {
                    new Employee(){Id = 1,Name = "Mert Çalık",Departmant = "It",Email = "mertclkdev@gmail.com",Photo = "mert.jpg"},
                    new Employee(){Id = 2,Name = "Casper",Departmant = "Security",Email = "casper@gmail.com",Photo = "casper.jpeg"},
                    new Employee(){Id = 3,Name = "Princess Cirilla",Departmant = "Witcher",Email = "cirilla@gmail.com",Photo = "ciri.jpg"},
                    new Employee(){Id = 4,Name = "Geralt of Rivia",Departmant = "Witcher",Email = "geralt@gmail.com",Photo = "geralt.jpg"},
            });
        }
        private List<Employee> _employees = new List<Employee>();


        public IEnumerable<Employee> GetAll => _employees;
        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(x => x.Id == id);
        }

        public Employee? Update(Employee entity)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == entity.Id);
            if (employee != null)
            {
                employee.Name = entity.Name ?? employee.Name;
                employee.Email = entity.Email ?? employee.Email;
                employee.Departmant = entity.Departmant ?? employee.Departmant;
                employee.Photo = entity.Photo ?? employee.Photo;
            }
            return employee;
        }
    }
}
