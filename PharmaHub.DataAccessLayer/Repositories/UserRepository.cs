using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataAccessLayer.Models;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public class UserRepository
    {
        PharmaHubDbContext _context;

        public UserRepository(PharmaHubDbContext context)
        {
            _context = context;
        }
        public User GetUser(int loginId)
        {
            User user = new User();
            try
            {
                user = (from u in _context.Users
                        where u.LoginId == loginId
                        select u).FirstOrDefault();
            }
            catch (Exception)
            {
                user = null;
            }
            return user;
        }

    }

}
