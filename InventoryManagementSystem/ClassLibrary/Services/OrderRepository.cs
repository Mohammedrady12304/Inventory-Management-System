using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Services
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(InventoryManagementContext context) : base(context) { }

        public IEnumerable<Order> GetAllWithDetails()
        {
            return _dbSet
                .AsNoTracking()
                .Include(o => o.Product)
                .Include(o => o.Customer)
                .ToList();
        }

        public IEnumerable<Order> SearchOrders(string searchTerm)
        {
            var query = _dbSet.AsNoTracking().Include(o => o.Product).Include(o => o.Customer);

            if (string.IsNullOrWhiteSpace(searchTerm))
                return query.ToList();

            searchTerm = searchTerm.ToLower();
            return query.Where(o =>
                o.oid.ToString().Contains(searchTerm) ||
                o.Product.pname.ToLower().Contains(searchTerm) ||
                o.Customer.cname.ToLower().Contains(searchTerm) ||
                o.odate.ToString().Contains(searchTerm)
            ).ToList();
        }
    }
}
