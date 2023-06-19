using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataAccess.interfaces
{
    public interface IAccountRepository
    {
        int Add(Account user);

        Account GetById(int id);

        IEnumerable<Account> GetAllUser(Func<Account, bool> predicate);

        void Update(Account user);

        void Delete(Account user);
    }
}