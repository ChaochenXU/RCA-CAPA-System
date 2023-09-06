using System.ComponentModel.DataAnnotations;


namespace RCAONE.Models
{
    public class Admin
    {
        public int ID { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 6)]
        public string userid { get; set; }
        public string userpassword { get; set; }
    }
}
