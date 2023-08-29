using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SecureAuth
{
    public class TokenIssuer
    {
        private readonly string _jwtSecret;
        private readonly int _jwtExpirationMinutes;
        private readonly string _jwtIssuer;
        private readonly string _jwtAudience;
        public TokenIssuer(string expiry, string issuer, string audience, string secret)
        {
            _jwtExpirationMinutes = Convert.ToInt32(expiry);
            _jwtSecret = secret;
            _jwtIssuer = issuer;
            _jwtAudience = audience;
        }

        public async Task<string> IssueToken(int userId, string username, string[] roles, string clientApp)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                new Claim("uname", username)
                // You can add other custom claims here, e.g., roles, user-specific data, etc.
                // new Claim("roles", string.Join(",", roles)),
            }),
                Expires = DateTime.UtcNow.AddMinutes(_jwtExpirationMinutes),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = _jwtIssuer,
                Audience = clientApp
            };


            var token = tokenHandler.CreateToken(tokenDescriptor);
            return await Task.FromResult(tokenHandler.WriteToken(token));
        }
    }

}
