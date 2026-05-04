using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.ClassLibrary.Models
{
    [Table("tbCategory")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int catid { get; set; }

        [StringLength(100)]
        public string catname { get; set; } = string.Empty;

        // One Category -> Many Products
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}