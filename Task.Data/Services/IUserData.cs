using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data.Services
{
    public interface IUserData
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Add(User user);
        void Update(User user);
    }
}
