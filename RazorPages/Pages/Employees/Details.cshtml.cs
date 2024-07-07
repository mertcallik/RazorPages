using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Models;
using RazorPages.Repository;

namespace RazorPages.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [BindProperty]
        public Employee Employee { get; set; } = null!;
        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetById(id);
            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }

            return Page();
        }
        [HttpPost]

        //post with params
        #region withparameter
        //public IActionResult OnPost(Employee? employee)
        //{
        //    var id=RouteData.Values["id"];
        //    if (employee != null&&int.Parse(id.ToString())== employee.Id)
        //    {
        //        _employeeRepository.Update(employee);
        //    }
        //    return RedirectToPage("/employees/Index");
        //}


        #endregion

        //post with bind property [BindProperty]
        #region withBindProperty

        public IActionResult OnPost()
        {
            var id = RouteData.Values["id"];
            if (Employee != null && int.Parse(id.ToString()) == Employee.Id)
            {
                _employeeRepository.Update(Employee);
            }
            return RedirectToPage("/employees/Index");
        }

        #endregion




    }
}
