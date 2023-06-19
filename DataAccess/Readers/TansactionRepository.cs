using OOP.DataAccess.interfaces;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataAccess.Readers
{
    public class TansactionRepository : ITansactionRepository
    {
        public List<Transaction> Database { get; }

        public int Add(Transaction user)
        {
            Database.Add(user);
            return user.Id;
        }

        public void Delete(Transaction user)
        {
            Database.Remove(user);
        }

        public IEnumerable<Transaction> GetAllUser(Func<Transaction, bool> predicate)
        {
            return Database.Where(predicate);
        }

        public Transaction GetById(int id)
        {
            return Database.FirstOrDefault(e => e.Id == id)!;
        }

        public void Update(Transaction user)
        {
            var transactionToUpdate = Database.FirstOrDefault(r => r.Id == user.Id);
            transactionToUpdate.Notes = user.Notes ?? transactionToUpdate.Notes;
            transactionToUpdate.SenderAccountId = user.SenderAccountId ?? transactionToUpdate.SenderAccountId;
            transactionToUpdate.ReceiverAccountId = user.ReceiverAccountId ?? transactionToUpdate.SenderAccountId;
        }
    }
}