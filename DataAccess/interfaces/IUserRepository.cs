using OOP.Entities;

namespace OOP.DataAccess.interfaces
{
    public interface IUserRepository
    {
        int Add(User user);

        User GetById(int id);

        IEnumerable<User> GetAllUser(Func<User, bool> predicate);

        void Update(User user);

        void Delete(User user);
    }
}