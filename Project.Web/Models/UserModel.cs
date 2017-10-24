using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Web.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Guid NewUserID()
        {
            Guid user = Guid.NewGuid();
            return user;
        }
    }
}