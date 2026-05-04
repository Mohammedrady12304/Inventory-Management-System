using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Class_Library.Services
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(InventoryManagementContext context) : base(context) { }

        public IEnumerable<Product> GetAllWithCategory()
        {
            return _dbSet.AsNoTracking().Include(p => p.Category).ToList();
        }

        public IEnumerable<Product> SearchProducts(string searchTerm)
        {
            var query = _dbSet.AsNoTracking().Include(p => p.Category);
            if (string.IsNullOrWhiteSpace(searchTerm))
                return query.ToList();

            searchTerm = searchTerm.ToLower();
            return query.Where(p =>
                p.pid.ToString().Contains(searchTerm) ||
                p.pname.ToLower().Contains(searchTerm) ||
                p.pprice.ToString().Contains(searchTerm) ||
                p.pdescription.ToLower().Contains(searchTerm) ||
                (p.Category != null && p.Category.catname.ToLower().Contains(searchTerm))
            ).ToList();
        }

        public IEnumerable<Product> GetByCategoryId(int catId)
        {
            return _dbSet.AsNoTracking().Include(p => p.Category)
                .Where(p => p.catid == catId).ToList();
        }
    }
}