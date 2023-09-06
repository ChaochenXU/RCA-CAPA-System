using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Threading.Tasks;

namespace RCAONE.Pages.ReportEdit
{
    public class EditCRAModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public EditCRAModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Corrective Corrective { get; set; }
        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
        public Employee Employee { get; set; }
        //获取Corrective
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.userid == Admin.userid);
            Corrective = await _context.Corrective.FirstOrDefaultAsync(m => m.repid == Employee.onreport);
            if (Corrective == null)
            {
                return NotFound();
            }
            return Page();
        }
        //修改CRA
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./EditCRA", new { id = AdminID });
            }
            _context.Attach(Corrective).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("../Reports/Corrective", new { id = AdminID });
        }

    }
}
