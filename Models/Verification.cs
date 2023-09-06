using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Verification
    {
        public int ID { get; set; }
        public string repid { get; set; }
        public string VAaction0 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string VAownerid0 { get; set; }
        public int VAstatus0 { get; set; }
        [DataType(DataType.Date)]
        public DateTime VAdue0 { get; set; }
        public string VAaction1 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string VAownerid1 { get; set; }
        public int VAstatus1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime VAdue1 { get; set; }
        public string VAaction2 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string VAownerid2 { get; set; }
        public int VAstatus2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime VAdue2 { get; set; }
        public string VAaction3 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string VAownerid3 { get; set; }
        public int VAstatus3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime VAdue3 { get; set; }
    }
}
