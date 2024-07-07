using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data.Abstract;
using RazorPages.Models;

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
