using ManufactureItSense.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManufactureItSense.Data
{
    public class ManufactureItSenseContext : DbContext
    {
        public ManufactureItSenseContext(DbContextOptions<ManufactureItSenseContext> options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; }
        public DbSet<Inventory> Inventory { get; set; }

    }
}
