using New_Hardware_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Hardware_Management_System
{
    internal class DataSeeder
    {
        public static void Seed()
        {
            using (var context = new HardwareDbContext())
            {
                if(!context.Items.AsEnumerable().OfType<Cement>().Any())
{
                    context.Items.Add(new Cement
                    {
                        ItemName = "UltraTech Cement",
                        Category = "Building Material",
                        Quantity = 50,
                        BuyingPrice = 200,
                        SellingPrice = 2340,
                        Brand = "UltraTech",
                        Quality = "High"
                    });
                    context.SaveChanges();
                }

            }
        }

    }
}
