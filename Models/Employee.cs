using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string userid { get; set; }
        [Required]
        [StringLength(16, MinimumLength = 8)]
        public string userpassword { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        public string useremail { get; set; }
        [Required]
        public int usergender { get; set; }
        [Required]
        public int userdepartment { get; set; }
        public int ishead { get; set; }
        public int isfree { get; set; }
        public string onreport { get; set; }
    }
}
