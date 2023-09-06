using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RCAONE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Analysis
{
    public class AnalysisModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public AnalysisModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }
        public IList<Problem> Problem { get; set; }
        public Analysiss Analysiss { get; set; }
        public Admin Admin { get; set; }
        //检索分析报告列表
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
            int[] a = new int[20];
            int[] b = new int[16];
            int[] c = new int[12];
            var problems = from m in _context.Problem
                           select m;
            //按触发规则统计
            a[0] = problems.Where(s => s.probrules == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            a[1] = problems.Where(s => s.probrules == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            a[2] = problems.Where(s => s.probrules == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            a[3] = problems.Where(s => s.probrules == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            a[4] = problems.Where(s => s.probrules == 4 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            a[5] = problems.Where(s => s.probrules == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            a[6] = problems.Where(s => s.probrules == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            a[7] = problems.Where(s => s.probrules == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            a[8] = problems.Where(s => s.probrules == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            a[9] = problems.Where(s => s.probrules == 4 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            a[10] = problems.Where(s => s.probrules == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            a[11] = problems.Where(s => s.probrules == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            a[12] = problems.Where(s => s.probrules == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            a[13] = problems.Where(s => s.probrules == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            a[14] = problems.Where(s => s.probrules == 4 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            a[15] = problems.Where(s => s.probrules == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            a[16] = problems.Where(s => s.probrules == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            a[17] = problems.Where(s => s.probrules == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            a[18] = problems.Where(s => s.probrules == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            a[19] = problems.Where(s => s.probrules == 4 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            //按产线统计
            b[0] = problems.Where(s => s.probline == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            b[1] = problems.Where(s => s.probline == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            b[2] = problems.Where(s => s.probline == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            b[3] = problems.Where(s => s.probline == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            b[4] = problems.Where(s => s.probline == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            b[5] = problems.Where(s => s.probline == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            b[6] = problems.Where(s => s.probline == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            b[7] = problems.Where(s => s.probline == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            b[8] = problems.Where(s => s.probline == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            b[9] = problems.Where(s => s.probline == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            b[10] = problems.Where(s => s.probline == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            b[11] = problems.Where(s => s.probline == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            b[12] = problems.Where(s => s.probline == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            b[13] = problems.Where(s => s.probline == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            b[14] = problems.Where(s => s.probline == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            b[15] = problems.Where(s => s.probline == 3 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            //按报告状态统计
            c[0] = problems.Where(s => s.status == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            c[1] = problems.Where(s => s.status == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            c[2] = problems.Where(s => s.status == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddYears(-1)) >= 0).Count();
            c[3] = problems.Where(s => s.status == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            c[4] = problems.Where(s => s.status == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            c[5] = problems.Where(s => s.status == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-3)) >= 0).Count();
            c[6] = problems.Where(s => s.status == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            c[7] = problems.Where(s => s.status == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            c[8] = problems.Where(s => s.status == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddMonths(-1)) >= 0).Count();
            c[9] = problems.Where(s => s.status == 0 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            c[10] = problems.Where(s => s.status == 1 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            c[11] = problems.Where(s => s.status == 2 && DateTime.Compare(s.probwhen, DateTime.Now.AddDays(-7)) >= 0).Count();
            //更新Analysiss表
            var analysis = from m in _context.Analysiss
                           select m;
            if (analysis.Count() == 0)
            {
                Analysiss NewAnalysiss = new Analysiss
                {
                    rules = string.Join(",", a),
                    lines = string.Join(",", b),
                    status = string.Join(",", c),
                };
                _context.Analysiss.Add(NewAnalysiss);
                await _context.SaveChangesAsync();
                Analysiss = await _context.Analysiss.FirstOrDefaultAsync(m => m.ID != 0);
            }
            else
            {
                Analysiss = await _context.Analysiss.FirstOrDefaultAsync(m => m.ID != 0);
                Analysiss.rules = string.Join(",", a);
                Analysiss.lines = string.Join(",", b);
                Analysiss.status = string.Join(",", c);
                _context.Analysiss.Attach(Analysiss);
                await _context.SaveChangesAsync();
            }
            return Page();
        }
    }
}