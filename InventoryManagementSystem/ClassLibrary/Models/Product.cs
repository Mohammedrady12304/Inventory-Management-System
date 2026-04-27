using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.ClassLibrary.Models
{
    [Table("tbProduct")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int pid { get; set; }

        [StringLength(100)]
        public string pname { get; set; } = string.Empty;

        public int pqty { get; set; }

        public int pprice { get; set; }

        [StringLength(255)]
        public string pdescription { get; set; } = string.Empty;

        [StringLength(100)]
        public string pcategory { get; set; } = string.Empty;
    }
}
