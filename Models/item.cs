using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Hardware_Management_System.Models
{
    public class item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public double BuyingPrice { get; set; }
        public double SellingPrice { get; set; }

    }
}
