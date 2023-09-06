using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Corrective
    {
        public int ID { get; set; }
        public string repid { get; set; }
        public string CRAaction0 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CRAownerid0 { get; set; }
        public int CRAstatus0 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CRAdue0 { get; set; }
        public string CRAaction1 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CRAownerid1 { get; set; }
        public int CRAstatus1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CRAdue1 { get; set; }
        public string CRAaction2 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CRAownerid2 { get; set; }
        public int CRAstatus2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CRAdue2 { get; set; }

        public string CRAaction3 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CRAownerid3 { get; set; }
        public int CRAstatus3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CRAdue3 { get; set; }


    }
}
