using System.Collections.Generic;
using System.Linq;
using Task.Data.Models;

namespace Task.Data.Services
{
    public class InMemoryUserData : IUserData
    {
        List<User> users;

        public InMemoryUserData()
        {
            users = new List<User>()
            {
                new User{Id = 1, FName = "Ani", LName = "Katsitadze", Age = 22, Status = UserStatus.Unknown, PersonalID="01001085718", PhoneNumber="571018404"},
                new User{Id = 2, FName = "Tevzi", LName = "Tevzadze", Age = 21,Status = UserStatus.Unknown,PersonalID="27281089918", PhoneNumber="574089400"},
                new User{Id = 3, FName = "Mariam", LName = "Gadishvili",Age =18,Status = UserStatus.Single,PersonalID="89081067710", PhoneNumber="593028404"},
                new User{Id = 4, FName = "Qurdi", LName = "Kaci",Age =45,Status = UserStatus.Married,PersonalID="01008085998", PhoneNumber="555013667"},
            };
        }

        public void Add(User user)
        {
            users.Add(user);
            user.Id = users.Max(r => r.Id) + 1;

        }

        public User Get(int id)
        {
            return users.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return users.OrderBy(r => r.Id);
        }

        public void Update(User user)
        {
            var existing = Get(user.Id);
            if(existing != null)
            {
                existing.FName = user.FName;
                existing.LName = user.LName;
                existing.Age = user.Age;
                existing.PersonalID = user.PersonalID;
                existing.PhoneNumber = user.PhoneNumber;
                existing.Status = user.Status;
            }
        }
    }
}
