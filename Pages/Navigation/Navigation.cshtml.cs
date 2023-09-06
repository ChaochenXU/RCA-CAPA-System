using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Navigation
{
    public class NavigationModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public NavigationModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
        public IList<Employee> Employee { get; set; }
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
            return Page();
        }
        //判断是否有进入个人中心权限
        public IActionResult OnPostSeventh()
        {
            return RedirectToPage("../Personal/Personal", new { id = AdminID });
        } 
        //判断是否有进入问题申报界面权限
        public async Task<IActionResult> OnPostFirstAsync()
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == AdminID);
            var a = Admin.userid.Substring(0, 1);
            if (a == "3" || a == "1")
            {
                return RedirectToPage("../Problems/Problems", new { id = AdminID });
            }
            else
            {
                return Page();
            }
        }
        //判断是否有进入组员选择界面权限
        public async Task<IActionResult> OnPostSecondAsync()
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == AdminID);
            var employees = from m in _context.Employee
                            select m;
            if (!string.IsNullOrEmpty(Admin.userid))
            {
                employees = employees.Where(s => s.userid.Contains(Admin.userid));
            }
            Employee = await employees.ToListAsync();
            var a = Admin.userid.Substring(0, 1);
            if ((a == "4" && Employee[0].ishead == 1) || a == "1")
            {
                return RedirectToPage("../Retrieve/Retrieves", new { id = AdminID });
            }
            else
            {
                return Page();
            }
        }
        //判断是否有进入图表分析界面权限
        public IActionResult OnPostThird()
        {
            return RedirectToPage("../Analysis/Analysis", new { id = AdminID });
        }
        //判断是否有进入打分界面权限
        public async Task<IActionResult> OnPostFourthAsync()
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == AdminID);
            var a = Admin.userid.Substring(0, 1);
            if (a == "2" || a == "1")
            {
                return RedirectToPage("../Scores/Score1", new { id = AdminID });
            }
            else
            {
                return Page();
            }
        }
        //判断是否有进入报告填写界面权限
        public async Task<IActionResult> OnPostFifthAsync()
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == AdminID);
            var a = Admin.userid.Substring(0, 1);
            var employees = from m in _context.Employee
                            select m;
            if (!string.IsNullOrEmpty(Admin.userid))
            {
                employees = employees.Where(s => s.userid.Contains(Admin.userid));
            }
            Employee = await employees.ToListAsync();

            if ((a == "4" && Employee[0].isfree == 1) || a == "1" || a == "3")
            {
                return RedirectToPage("../Reports/Reports", new { id = AdminID });
            }
            else
            {
                return Page();
            }
        }
        //判断是否有进入报告列表权限
        public IActionResult OnPostSixth()
        {
            return RedirectToPage("../RepList/RepList", new { id = AdminID });
        }
    }
}