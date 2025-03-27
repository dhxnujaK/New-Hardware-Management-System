using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Hardware_Management_System.Models
{
    public class Paint : item
    {
        public string? Brand { get; set; }
        public string? Quality { get; set; }
        public string? Colour { get; set; }

        public string? ColourCode { get; set; }
        public int? Capacity { get; set; }

    }
}
