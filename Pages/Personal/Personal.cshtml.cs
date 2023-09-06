using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Personal
{
    public class PersonalModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public PersonalModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }
        public IList<Employee> Employee { get; set; }
        public IList<Problem> Problem { get; set; }
        public Admin Admin { get; set; }
        //获取当前登录员工id并显示个人信息
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            if (Admin == null)
            {
                return NotFound();
            }
            var employees = from m in _context.Employee
                            select m;
            if (!string.IsNullOrEmpty(Admin.userid))
            {
                employees = employees.Where(s => s.userid.Contains(Admin.userid));
            }
            Employee = await employees.ToListAsync();
            var problems = from m in _context.Problem
                           select m;
            if (!string.IsNullOrEmpty(Admin.userid))
            {
                problems = problems.Where(s => s.probheadid.Contains(Admin.userid));
            }
            Problem = await problems.ToListAsync();

            return Page();
        }
    }
}