using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        // FK to Category (1:M)
        [ForeignKey("Category")]
        public int? catid { get; set; }

        //[ForeignKey("catid")]
        public virtual Category? Category { get; set; }

        // Computed for display only — not stored in DB
        [NotMapped]
        public string pcategory => Category?.catname ?? string.Empty;

        // One Product -> Many Orders
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}