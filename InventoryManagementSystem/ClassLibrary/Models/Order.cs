using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.ClassLibrary.Models
{
    [Table("tbOrder")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int oid { get; set; }

        public DateTime odate { get; set; }
        public int pid { get; set; }
        public int cid { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
        public int total { get; set; }

        [ForeignKey("pid")]
        public virtual Product? Product { get; set; }

        [ForeignKey("cid")]
        public virtual Customer? Customer { get; set; }
    }
}