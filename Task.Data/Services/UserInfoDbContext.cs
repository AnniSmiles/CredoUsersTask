using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Data.Models;

namespace Task.Data.Services
{
    public class UserInfoDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
