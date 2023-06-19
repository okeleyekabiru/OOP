using OOP.DataAccess.interfaces;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataAccess.Readers
{
    public class AccountRepository : IAccountRepository
    {
        public static List<Account> Database { get; }

        public int Add(Account user)
        {
            Database.Add(user);
            return user.Id;
        }

        public void Delete(Account user)
        {
            Database.Remove(user);
        }

        public IEnumerable<Account> GetAllUser(Func<Account, bool> predicate)
        {
            return Database.Where(predicate);
        }

        public Account GetById(int id)
        {
            return Database.FirstOrDefault(e => e.Id == id)!;
        }

        public void Update(Account user)
        {
            var accountToUpdate = Database.FirstOrDefault(r => r.Id == user.Id);
            accountToUpdate.Balance = user.Balance ?? accountToUpdate.Balance;
            accountToUpdate.AccountNumber = user.AccountNumber ?? accountToUpdate.AccountNumber;
            accountToUpdate.Type = user.Type ?? accountToUpdate.Type;
        }
    }
}