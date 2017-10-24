using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Web.Models;

namespace Project.Web.DAL
{
    public interface INewUserDAL
    {
        UserModel CheckUserNameExists(UserModel user);
        bool UserNameTaken(UserModel user);
        UserModel CreateDBEntry(UserModel user);
    }
}
