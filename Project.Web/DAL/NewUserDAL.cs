using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project.Web.Models;

namespace Project.Web.DAL
{
    public class NewUserDAL : INewUserDAL
    {
        

        UserModel INewUserDAL.CheckUserNameExists(UserModel user)
        {
            throw new NotImplementedException();
        }

        bool INewUserDAL.UserNameTaken(UserModel user)
        {
            throw new NotImplementedException();
        }

        UserModel INewUserDAL.CreateDBEntry(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}