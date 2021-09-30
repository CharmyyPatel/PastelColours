using System;
using System.ComponentModel.DataAnnotations;

namespace colour.Models
{
    public class Program1
    {
        public int ID { get; set; }
        public string name { get; set; } 
        [DataType(DataType.Date)]
        public DateTime PowerAcquisitionDate { get; set; }
        public string meaning { get; set; }
        public string mix1 { get; set; } 
        public string mix2 { get; set; }
        public string hexcode { get; set; }
    }
}
