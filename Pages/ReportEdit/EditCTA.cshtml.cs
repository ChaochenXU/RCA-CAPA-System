using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Threading.Tasks;

namespace RCAONE.Pages.ReportEdit
{
    public class EditCTAModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public EditCTAModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Containment Containment { get; set; }
        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
        public Employee Employee { get; set; }
        //获取Containment
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.userid == Admin.userid);
            Containment = await _context.Containment.FirstOrDefaultAsync(m => m.repid == Employee.onreport);
            if (Containment == null)
            {
                return NotFound();
            }
            return Page();
        }
        //修改CTA
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToPage("./EditCTA", new { id = AdminID });
            }
            _context.Attach(Containment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToPage("../Reports/Containment", new { id = AdminID });
        }
    }
}
