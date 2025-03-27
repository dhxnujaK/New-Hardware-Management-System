using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Hardware_Management_System.Models
{
    public class Electrical_Appliances : item
    {
        public string? ItemName { get; set; }

        public string? Category { get; set; }
    }

    public class  Bulb : Electrical_Appliances
    {
        public double? Voltage { get; set; }
        public string? Brand { get; set; }

        public string? Type { get; set; }
    }
}
