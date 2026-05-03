using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Services
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(InventoryManagementContext context) : base(context) { }
    }
}