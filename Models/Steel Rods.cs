using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Hardware_Management_System.Models
{
    public class Steel_Rods: item
    {
        
        public int? Length { get; set; }

        public string? Brand { get; set; }
    }
}
