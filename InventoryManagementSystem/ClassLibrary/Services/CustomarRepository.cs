using Class_Library.Context;
using InventoryManagementSystem.ClassLibrary.Models;

namespace Class_Library.Services
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(InventoryManagementContext context) : base(context) { }

        public bool CustomerExists(int id)
        {
            return _dbSet.Any(c => c.cid == id);
        }

        public Customer? GetByName(string name)
        {
            return _dbSet.FirstOrDefault(c => c.cname == name);
        }
    }
}