using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManufactureItSense.Model
{
    public class Inventory
    {
        [Key]
        [Column("InventoryId")]
        public int InventoryId { get; set; }

        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Products Products { get; set; }

        [Column("Quantity")]
        public int Quantity { get; set; }

        [Column("StateProduc")]
        public string StateProduc { get; set; }

    }
}
