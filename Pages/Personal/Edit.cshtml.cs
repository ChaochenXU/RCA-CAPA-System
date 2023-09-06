using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Threading.Tasks;

namespace RCAONE.Pages.Personal
{
    public class EditModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public EditModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
        //绑定个人信息
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.userid == Admin.userid);
            if (Employee == null)
            {
                return NotFound();
            }
            return Page();
        }
        //修改个人信息
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Attach(Employee).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("./Personal", new { id = AdminID });
        }
    }
}
