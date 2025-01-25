using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataAccessLayer.Models;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public interface IUserRepository
    {
        User GetUser(int loginId);
        int AddUser(User user);
        int DeleteUser(int loginId);
        int UpdateUser(User user);

    }
}
