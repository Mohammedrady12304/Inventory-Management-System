using Class_Library.Context;
using Class_Library.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Class_Library.Services
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly InventoryManagementContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(InventoryManagementContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll() => _dbSet.ToList();

        public T? GetById(object id) => _dbSet.Find(id);

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(object id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void Save() => _context.SaveChanges();
    }
}