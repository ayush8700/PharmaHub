using PharmaHub.DataAccessLayer.Models;
using PharmaHub.DataTranferObjects;

namespace PharmaHub.DataAccessLayer.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        PharmaHubDbContext _context;
        public LoginRepository(PharmaHubDbContext context)
        {
            _context = context;
        }

        public GetLoginDto Login(string emailId, string password)
        {
            GetLoginDto loginDto = new GetLoginDto();

            try
            {
                var user = (from loginUser in _context.Logins
                            join role in _context.Roles on loginUser.RoleId equals role.RoleId
                            where loginUser.EmailId == emailId && loginUser.UserPassword == password
                            select new { loginUser.LoginId, loginUser.EmailId, role.RoleName }).FirstOrDefault();
                if (user != null)
                {
                    loginDto.LoginId = user.LoginId;
                    loginDto.EmailId = user.EmailId;
                    loginDto.Role = user.RoleName;
                }
                else
                {
                    loginDto.LoginId = 0;
                }
            }
            catch (Exception)
            {
                // Handle exception
            }
            return loginDto;
        }

        public int Register(AddLoginDto addLoginDTO)
        {
            int status = 0;
            try
            {
                Login login = new Login
                {
                    EmailId = addLoginDTO.EmailId,
                    UserPassword = addLoginDTO.UserPassword,
                    RoleId = addLoginDTO.RoleId
                };

                Login loginToAdd = (from l in _context.Logins
                                    where l.EmailId == login.EmailId
                                    select l).FirstOrDefault();

                if (loginToAdd != null)
                {
                    status = -1;
                }
                else
                {
                    _context.Logins.Add(login);
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
