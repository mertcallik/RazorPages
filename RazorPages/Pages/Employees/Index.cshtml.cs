using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Repository;

namespace RazorPages.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository= employeeRepository;
            
        }
        public IEnumerable<Employee> Employees = new List<Employee>();
        public void OnGet()
        {
            Employees = _employeeRepository.GetAll;
        }
    }
}
