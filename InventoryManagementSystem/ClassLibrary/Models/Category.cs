using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
