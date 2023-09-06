using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RCAONE.Models;
using RCAONE.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace RCAONE.Pages.Problems
{
    public class FileuploadModel : PageModel
    {
        private readonly RCAONE.Data.MyContext _context;
        private readonly long _fileSizeLimit;
        private readonly string[] _permittedExtensions = { ".txt", ".jpg" };
        public FileuploadModel(RCAONE.Data.MyContext context, IConfiguration config)
        {
            _context = context;
            _fileSizeLimit = config.GetValue<long>("FileSizeLimit");
        }

        [BindProperty]
        public Fileupload FileUpload { get; set; }
        public Admin Admin { get; set; }
        public Employee Employee { get; set; }
        [BindProperty(SupportsGet = true)]
        public int AdminID { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Repid { get; set; }
        public string Result { get; private set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == id);
            Employee = await _context.Employee.FirstOrDefaultAsync(m => m.userid == Admin.userid);
            if (Admin == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            Admin = await _context.Admin.FirstOrDefaultAsync(m => m.ID == AdminID);
            if (!ModelState.IsValid)
            {
                Result = "Please correct the form.";

                return RedirectToPage("../Fileupload/Fileupload", new { id = AdminID });
            }
            foreach (var formFile in FileUpload.FormFile)
            {
                var formFileContent =
                    await FileHelpers.ProcessFormFile<Fileupload>(
                        formFile, ModelState, _permittedExtensions,
                        _fileSizeLimit);

                if (!ModelState.IsValid)
                {
                    Result = "Please correct the form.";
                    return RedirectToPage("../Fileupload/Fileupload", new { id = AdminID });
                }
                var file = new AppFile()
                {
                    userid = Admin.userid,
                    probid = Repid,
                    Content = formFileContent,
                    FileName = formFile.FileName,
                    Note = FileUpload.Note,
                    Size = formFile.Length,
                    UploadDT = DateTime.UtcNow
                };
                _context.AppFile.Add(file);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("../Reports/Reports", new { id = AdminID });
        }
        public class Fileupload
        {
            [Required]
            [Display(Name = "File")]
            public List<IFormFile> FormFile { get; set; }
            [Display(Name = "Note")]
            [StringLength(50, MinimumLength = 0)]
            public string Note { get; set; }
        }
    }
}
