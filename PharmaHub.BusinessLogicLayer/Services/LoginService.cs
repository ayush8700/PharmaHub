using Microsoft.Extensions.Configuration;
using PharmaHub.BusinessLogicLayer.Authentication;
using PharmaHub.DataAccessLayer.Repositories;
using PharmaHub.DataTranferObjects;

namespace PharmaHub.BusinessLogicLayer.Services
{
    public class LoginService : ILoginService
    {
        ILoginRepository _loginRepository;
        JwtTokenImplementation _jwtTokenImplementation;
        IConfiguration _configuration;

        public LoginService(ILoginRepository loginRepository, JwtTokenImplementation jwtTokenImplementation, IConfiguration configuration)
        {
            _loginRepository = loginRepository;
            _jwtTokenImplementation = jwtTokenImplementation;
            _configuration = configuration;
        }

        public SaveLoginDto Login(string emailId, string password)
        {
            SaveLoginDto loginDto = new SaveLoginDto();
            try
            {
                GetLoginDto login = _loginRepository.Login(emailId, password);

                if (login.LoginId != 0)
                {
                    loginDto.LoginId = login.LoginId;
                    loginDto.EmailId = login.EmailId;
                    loginDto.Role = login.Role;
                    var secretKey = _configuration["Jwt:SecretKey"];

                    if (string.IsNullOrEmpty(secretKey))
                    {
                        throw new Exception("JWT secret key is missing");
                    }
                    loginDto.token = _jwtTokenImplementation.GenerateJwtToken(loginDto.Role, loginDto.EmailId, secretKey);
                }
                else
                {
                    loginDto.LoginId = 0;
                }
            }
            catch (Exception)
            {
                // Handle the exception as necessary
            }
            return loginDto;
        }
    }
}
