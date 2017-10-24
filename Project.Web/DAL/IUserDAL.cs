using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Web.Models;

namespace Project.Web.DAL
{
    public interface IUserDAL
    {
        bool VerifyUserNameAndPW(string userName, string passWord);
        bool UserExists(string userName);
        bool CorrectPW(string userName, string passWord);

    }
}
