using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Preventive
    {
        public int ID { get; set; }
        public string repid { get; set; }
        public string PAaction0 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string PAownerid0 { get; set; }
        public int PAstatus0 { get; set; }
        [DataType(DataType.Date)]
        public DateTime PAdue0 { get; set; }
        public string PAaction1 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string PAownerid1 { get; set; }
        public int PAstatus1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime PAdue1 { get; set; }
        public string PAaction2 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string PAownerid2 { get; set; }
        public int PAstatus2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime PAdue2 { get; set; }
        public string PAaction3 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string PAownerid3 { get; set; }
        public int PAstatus3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime PAdue3 { get; set; }
        public int isrepeat { get; set; }
        public int isPMAPS { get; set; }
        public int isPFMEA { get; set; }
        public int isreview { get; set; }
        public string PAcoments { get; set; }

    }
}
