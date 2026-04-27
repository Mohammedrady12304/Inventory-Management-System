using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Product? Product { get; set; }

        [ForeignKey("cid")]
        public Customer? Customer { get; set; }
    }
}
