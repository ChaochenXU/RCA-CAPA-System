using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class AppFile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string probid { get; set; }
        public string userid { get; set; }
        [Display(Name = "Size (bytes)")]
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public long Size { get; set; }

        [Display(Name = "Uploaded (UTC)")]
        [DisplayFormat(DataFormatString = "{0:G}")]
        public DateTime UploadDT { get; set; }
        public string Note { get; set; }
        public byte[] Content { get; set; }
    }
}
