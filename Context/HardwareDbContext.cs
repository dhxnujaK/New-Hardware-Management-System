using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using New_Hardware_Management_System.Models;
namespace New_Hardware_Management_System
{
    public class HardwareDbContext : DbContext
    {
        public DbSet<item> Items { get; set; }
        /*public DbSet<Cement> Cements { get; set; }
        public DbSet<Electrical_Appliances> ElectricalAppliances { get; set; }
        public DbSet<Bulb> Bulbs { get; set; }
        public DbSet<Home_Appliances> HomeAppliances { get; set; }
        public DbSet<Nails> Nails { get; set; }
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Steel_Rods> SteelRods { get; set; }*/

        // Configure the SQLite connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;database=HardDataApp;user=root;password=dhanujaK@3036921;";
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<item>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<item>("item")
                .HasValue<Cement>("Cement")
                .HasValue<Paint>("Paint")
                .HasValue<Nails>("Nails")
                .HasValue<Electrical_Appliances>("Electrical_Appliances")
                .HasValue<Home_Appliances>("Home_Appliances")
                .HasValue<Steel_Rods>("Steel_Rods")
                .HasValue<Bulb>("Bulb");
        }

    }

}