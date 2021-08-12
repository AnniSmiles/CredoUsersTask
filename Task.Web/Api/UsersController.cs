using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Task.Data.Models;
using Task.Data.Services;

namespace Task.Web.Api
{
    public class UsersController : ApiController
    {
        private readonly IUserData db;

        public UsersController(IUserData db)
        {
            this.db = db;
        }
        public IEnumerable<User> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
