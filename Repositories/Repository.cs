using Autoshop.Database;
using Autoshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoshop.Repositories
{
    public class Repository<T> : ICommandRepository<T> where T : BaseEntity
    {


        private ApplicationContext _context { get; set; }


        public Repository(ApplicationContext context)
        {
            _context = context;

        }

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }


        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public T Update(T entity)
        {
            var toUpdate = _context.Set<T>().FirstOrDefault(m => m.Id == entity.Id);
            if (toUpdate != null)
            {
                toUpdate = entity;
            }
            _context.Update(toUpdate);
            _context.SaveChanges();
            return toUpdate;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var toUpdate = await _context.Set<T>().FirstOrDefaultAsync(m => m.Id == entity.Id);
            if (toUpdate != null)
            {
                toUpdate = entity;
            }
            await Task.Run(() => _context.Update(toUpdate));
            await _context.SaveChangesAsync();
            return toUpdate;
        }

        public void Delete(T entity)
        {
            var toDelete = _context.Set<T>().FirstOrDefault(m => m.Id == entity.Id);
            _context.Set<T>().Remove(toDelete);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            var toDelete = await _context.Set<T>().FirstOrDefaultAsync(m => m.Id == entity.Id);
            await Task.Run(() => _context.Set<T>().Remove(toDelete));
            await _context.SaveChangesAsync();
        }

        public T Get(Guid id)
        {

            var toGet = _context.Set<T>().FirstOrDefault(m => m.Id == id);
            if (toGet != null)
            {
                return toGet;
            }
            return null;
        }

        public async Task<T> GetAsync(Guid id)
        {
            var toGetAsunc = await _context.Set<T>().FirstOrDefaultAsync(m => m.Id == id);
            if (toGetAsunc != null)
            {
                return toGetAsunc;
            }

            return null;
        }
        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await Task.Run(() => _context.Set<T>().ToList());
        }
    }
}
