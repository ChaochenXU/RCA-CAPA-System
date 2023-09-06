using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Problem
    {
        public int ID { get; set; }
        public string probname { get; set; }
        [Required]
        public string probwhat { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime probwhen { get; set; }
        [Required]
        public string probwhere { get; set; }
        [Required]
        public string probwho { get; set; }
        [Required]
        public string probwhy { get; set; }
        [Required]
        public string probhow { get; set; }
        [Required]
        public int probline { get; set; }
        [Required]
        public int probrules { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime probdue { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string probheadid { get; set; }
        public string probid { get; set; }
        public int status { get; set; }
        public float scorevalue { get; set; }
    }
}
