using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Class_Library.Services
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(InventoryManagementContext context) : base(context) { }

        public IEnumerable<Category> GetAllWithProducts()
        {
            return _dbSet.AsNoTracking().Include(c => c.Products).ToList();
        }

        public Category? GetByIdWithProducts(int id)
        {
            return _dbSet.Include(c => c.Products).FirstOrDefault(c => c.catid == id);
        }
    }
}