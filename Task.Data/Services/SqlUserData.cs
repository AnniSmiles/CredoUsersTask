using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data.Services
{
    public class SqlUserData : IUserData
    {
        private readonly UserInfoDbContext db;

        public SqlUserData(UserInfoDbContext db)
        {
            this.db = db;
        }
        public void Add(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return from r in db.Users
                   orderby r.LName
                   select r;
        }

        public void Update(User user)
        {
            var entry = db.Entry(user);
            entry.State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
