using System;
using System.ComponentModel.DataAnnotations;

namespace RCAONE.Models
{
    public class Containment
    {
        public int ID { get; set; }
        public string repid { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CTAownerid0 { get; set; }
        public string CTApa0 { get; set; }
        public int CTAstatues0 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CTAdue0 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CTAownerid1 { get; set; }
        public string CTApa1 { get; set; }
        public int CTAstatues1 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CTAdue1 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CTAownerid2 { get; set; }
        public string CTApa2 { get; set; }
        public int CTAstatues2 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CTAdue2 { get; set; }
        [StringLength(6, MinimumLength = 6)]
        public string CTAownerid3 { get; set; }
        public string CTApa3 { get; set; }
        public int CTAstatues3 { get; set; }
        [DataType(DataType.Date)]
        public DateTime CTAdue3 { get; set; }
    }
}
