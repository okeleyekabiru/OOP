using OOP.Entities;

namespace OOP.DataAccess.interfaces
{
    public interface ITansactionRepository
    {
        int Add(Transaction user);

        Transaction GetById(int id);

        IEnumerable<Transaction> GetAllUser(Func<Transaction, bool> predicate);

        void Update(Transaction user);

        void Delete(Transaction user);
    }
}