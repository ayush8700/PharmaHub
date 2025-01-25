using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaHub.DataAccessLayer.Models;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public class UserRepository : IUserRepository
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

        public int AddUser(User user)
        {
            int status = 0;
            try
            {
                User userToAdd = (from u in _context.Users
                                     where u.LoginId == user.LoginId
                                     select u).FirstOrDefault();
                if(userToAdd != null)
                {
                    status = -1;
                }
                else
                {
                    _context.Users.Add(user);
                    _context.SaveChanges();
                    status = 1;
                }
            }
            catch (Exception)
            {
                status = -99;
            }
            return status;
        }

        public int DeleteUser(int loginId)
        {
            int status = 0;
            try
            {
                User user = (from u in _context.Users
                             where u.LoginId == loginId
                             select u).FirstOrDefault();

                if (user == null)
                {
                    status = -1;
                }
                else
                {
                    _context.Users.Remove(user);
                    _context.SaveChanges();
                    status = 1;
                }
            }
            catch (Exception)
            {
                status = -99;
            }
            return status;
        }

        public int UpdateUser(User user)
        {
            int status = 0;
            try
            {
                User userToUpdate = (from u in _context.Users
                                     where u.LoginId == user.LoginId
                                     select u).FirstOrDefault();

                if (userToUpdate == null)
                {
                    status = -1;
                }
                else
                {
                    _context.Users.Update(user);
                    _context.SaveChanges();
                    status = 1;
                }
            }
            catch (Exception)
            {
                status = -99;
            }
            return status;
        }

    }
}
