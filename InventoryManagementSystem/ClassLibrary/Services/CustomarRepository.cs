using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Class_Library.Services
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(InventoryManagementContext context) : base(context) { }

        public bool CustomerExists(int id) => _dbSet.Any(c => c.cid == id);

        public Customer? GetByName(string name) => _dbSet.FirstOrDefault(c => c.cname == name);

        public IEnumerable<Customer> GetAllWithOrders()
        {
            return _dbSet.AsNoTracking()
                .Include(c => c.Orders).ThenInclude(o => o.Product)
                .ToList();
        }

        public Customer? GetByIdWithOrders(int id)
        {
            return _dbSet
                .Include(c => c.Orders).ThenInclude(o => o.Product)
                .FirstOrDefault(c => c.cid == id);
        }

        public IEnumerable<Customer> SearchCustomers(string searchTerm)
        {
            var query = _dbSet.AsNoTracking();
            if (string.IsNullOrWhiteSpace(searchTerm)) return query.ToList();

            searchTerm = searchTerm.ToLower();
            return query.Where(c =>
                c.cid.ToString().Contains(searchTerm) ||
                c.cname.ToLower().Contains(searchTerm) ||
                c.cphone.Contains(searchTerm)
            ).ToList();
        }
    }
}