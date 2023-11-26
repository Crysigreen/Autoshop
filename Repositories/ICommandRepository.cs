namespace Autoshop.Repositories
{
    public interface ICommandRepository<T> where T : class
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        T Update(T entity);
        Task<T> UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
        T Get(Guid id);
        Task<T> GetAsync(Guid id);
        List<T> GetAll();
        Task<List<T>> GetAllAsync();
    }
}
