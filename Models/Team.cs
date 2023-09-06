using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Team
    {
        public int ID { get; set; }
        public string repid { get; set; }

        [StringLength(6, MinimumLength = 6)]
        public string memid1 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string memid2 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string memid3 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string memid4 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string memid5 { get; set; }

    }
}
