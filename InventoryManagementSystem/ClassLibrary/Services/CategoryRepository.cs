using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Services
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(InventoryManagementContext context) : base(context) { }
    }
}
