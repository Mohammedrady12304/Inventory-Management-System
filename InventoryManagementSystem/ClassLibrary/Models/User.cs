using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Models
{
    [Table("tbUser")]
    public class User
    {
        [Key]
        [StringLength(50)]
        public string username { get; set; } = string.Empty;

        [StringLength(100)]
        public string fullname { get; set; } = string.Empty;

        [StringLength(100)]
        public string password { get; set; } = string.Empty;

        [StringLength(20)]
        public string phone { get; set; } = string.Empty;
    }
}