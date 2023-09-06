using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Login
{
    public class LoginModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public LoginModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Admin Admin { get; set; }
        public IList<Employee> Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {   //检索adminid
            var employees = from m in _context.Employee
                            select m;
            if (!string.IsNullOrEmpty(Admin.userid))
            {
                employees = employees.Where(s => s.userid.Contains(Admin.userid));
            }
            Employee = await employees.ToListAsync();
            //admin入库
            _context.Admin.Add(Admin);
            await _context.SaveChangesAsync();
            //校对id、password
            if (Admin.userpassword == Employee[0].userpassword)
            {
                return RedirectToPage("../Navigation/Navigation", new { id = Admin.ID });
            }
            else
            {
                return Page();
            }
        }
    }
}