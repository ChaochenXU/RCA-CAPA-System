using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RCAONE.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public CreateModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var employees = from m in _context.Employee
                            select m;
            employees = employees.Where(s => s.userid.Contains(Employee.userid));
            //如果信息符合格式且工号未注册，Employee入库
            if (employees.Count() != 0)
            {
                return Page();
            }
            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Login/Login");
        }
    }
}
