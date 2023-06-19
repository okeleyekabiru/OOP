using OOP.DataAccess.interfaces;
using OOP.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.DataAccess.Readers
{
    public class UserRepository : IUserRepository
    {
        public static List<User> Database { get; }

        public int Add(User user)
        {
            Database.Add(user);
            return user.Id;
        }

        public void Delete(User user)
        {
            Database.Remove(user);
        }

        public IEnumerable<User> GetAllUser(Func<User, bool> predicate)
        {
            return Database.Where(predicate);
        }

        public User GetById(int id)
        {
            return Database.FirstOrDefault(e => e.Id == id)!;
        }

        public void Update(User user)
        {
            var usertoUpdate = Database.FirstOrDefault(r => r.Id == user.Id);
            usertoUpdate.FirstName = user.FirstName ?? usertoUpdate.FirstName;
            usertoUpdate.LastName = user.LastName ?? usertoUpdate.LastName;
        }
    }
}