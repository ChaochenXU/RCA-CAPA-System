using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.RepList
{
    public class RepListModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public RepListModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }

        public IList<Problem> Problem { get; set; }
        public Score Score { get; set; }
        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ProblemLine { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ProblemRule { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ProblemStatus { get; set; }
        [BindProperty(SupportsGet = true)]
        public int id { get; set; }
        //通过登陆人信息获取报告id
        public async Task OnGetAsync(int? id)
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            var problems = from m in _context.Problem
                           select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                problems = problems.Where(s => s.probid.Contains(SearchString));
            }
            if (ProblemLine != 6)
            {
                problems = problems.Where(x => x.probline == ProblemLine);
            }
            if (ProblemRule != 6)
            {
                problems = problems.Where(x => x.probrules == ProblemRule);
            }
            if (ProblemStatus != 6)
            {
                problems = problems.Where(x => x.status == ProblemStatus);
            }
            Problem = await problems.ToListAsync();
        }
    }
}
