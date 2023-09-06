using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using RCAONE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCAONE.Pages.Problems
{
    public class ProblemsModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;

        public ProblemsModel(RCAONE.Data.MyContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Problem Problem { get; set; }
        public IList<Employee> Employee { get; set; }
        public Admin Admin { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
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
        public async Task<IActionResult> OnPostAsync()
        {

            if (!ModelState.IsValid)
            {
                return RedirectToPage("./Problems", new { id = AdminID });
            }
            //检索负责人
            var employees = from m in _context.Employee
                            select m;
            if (!string.IsNullOrEmpty(Problem.probheadid))
            {
                employees = employees.Where(s => s.userid.Contains(Problem.probheadid));
            }
            Employee = await employees.ToListAsync();
            //判断负责人是否存在或空闲
            if (Employee.Count() == 0)
            {
                return RedirectToPage("../Problems/Problems", new { id = AdminID });
            }
            if (Employee[0].userid.Substring(0, 1) != "4" || Employee[0].isfree == 1)
            {
                return RedirectToPage("../Problems/Problems", new { id = AdminID });
            }
            //问题入库
            System.Random a = new Random(System.DateTime.Now.Millisecond);
            int RandKey = a.Next(10, 99);
            Problem.probid = "RCA" + DateTime.Now.Date.ToShortDateString() + RandKey.ToString();
            Problem.status = 0;
            Problem.scorevalue = 0;
            _context.Problem.Add(Problem);
            await _context.SaveChangesAsync();
            //修改负责人信息isfree和ishead
            Employee[0].onreport = Problem.probid;
            Employee[0].isfree = 1;
            Employee[0].ishead = 1;
            _context.Employee.Attach(Employee[0]);
            await _context.SaveChangesAsync();
            //向组长发送邮件
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Emerson", "1061886245@qq.com"));
            message.To.Add(new MailboxAddress(Employee[0].username, Employee[0].useremail));

            message.Subject = "Notice";

            message.Body = new TextPart("plain") { Text = "You have a new assignment." };

            using (var client = new SmtpClient())
            {
                // For demo-purposes, accept all SSL certificates (in case the server supports STARTTLS)
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.qq.com", 587, false);

                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("1061886245@qq.com", "byilvwjdfxjebdhh");

                client.Send(message);
                client.Disconnect(true);
            }
            return RedirectToPage("../Navigation/Navigation", new { id = AdminID });
        }
    }
}
