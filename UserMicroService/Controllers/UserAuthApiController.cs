using Microsoft.AspNetCore.Mvc;
using SecureAuth;

namespace UserMicroService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthApiController : ControllerBase
    {
        TokenIssuer _tokenIssuer;
        public UserAuthApiController(TokenIssuer tokenIssuer)
        {
            _tokenIssuer = tokenIssuer;
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                var user = _users.FirstOrDefault(u => u.Username == loginModel.UserName
                                               && u.Password == loginModel.Password);
                if (user is null)
                {
                    return Unauthorized();
                }

                var token = await _tokenIssuer.IssueToken(user.UserId, user.Username, user.Roles, loginModel.ClientApp);

                return Ok(token);
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost("AuthenticateForBasicAuth")]
        public async Task<IActionResult> AuthenticateForBasicAuth(LoginModel loginModel)
        {
            try
            {
                var user = _users.FirstOrDefault(u => u.Username == loginModel.UserName
                                               && u.Password == loginModel.Password);
                if (user is null)
                {
                    return Unauthorized();
                }
                return Ok(loginModel);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private readonly List<User> _users = new()
        {
            new(1, "admin", "aDm1n", new[]{"Administrator"}, new[] {"shoes.read"}),
            new(2, "user01", "u$3r01", new[]{"User"}, new[] {"shoes.read"})
        };
    }

    public class User
    {
        public User(int userId, string username, string password, string[] roles, string[] permissions)
        {
            UserId = userId;
            Username = username;
            Password = password;
            Roles = roles;
            Permissions = permissions;
        }
        public int UserId { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string[] Roles { get; set; }
        public string[] Permissions { get; set; }
    }

}
