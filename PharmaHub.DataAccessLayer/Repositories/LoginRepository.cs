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

        public bool Register(AddLoginDto addLoginDTO)
        {
            bool status = false;
            try
            {
                Login login = new Login
                {
                    EmailId = addLoginDTO.EmailId,
                    UserPassword = addLoginDTO.UserPassword,
                    RoleId = addLoginDTO.RoleId
                };
                _context.Logins.Add(login);
                _context.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }
    }
}
