namespace Autoshop.Services
{
    public interface IUserService<T> where T : class
    {
       public Task<T> AddUserAsync(T user);
    }
}
