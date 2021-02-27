using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ManufactureItSense.Model
{
    public class Products
    {
        [Key]
        [Column("ProductId")]
        public int ProductId { get; set; }

        [Column("NameProduc")]
        public string NameProduc { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Price")]
        public int Price { get; set; }
    }
}
