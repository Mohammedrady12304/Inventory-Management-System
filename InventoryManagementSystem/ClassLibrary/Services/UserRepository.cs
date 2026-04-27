using Class_Library.Context;
using Class_Library.Models;

namespace Class_Library.Services
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(InventoryManagementContext context) : base(context) { }

        public User? GetByUsername(string username)
        {
            return _dbSet.FirstOrDefault(u => u.username == username);
        }

        public bool UsernameExists(string username)
        {
            return _dbSet.Any(u => u.username == username);
        }

        public User? Authenticate(string username, string password)
        {
            return _dbSet.FirstOrDefault(u => u.username == username && u.password == password);
        }
    }
}