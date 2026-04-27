using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.ClassLibrary.Models
{
    [Table("tbCustomer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cid { get; set; }

        [StringLength(100)]
        public string cname { get; set; } = string.Empty;

        [StringLength(20)]
        public string cphone { get; set; } = string.Empty;
    }
}
