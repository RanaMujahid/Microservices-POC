using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PHServices.Common.Utilities;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace SecureAuth
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly string _authURL;
        public BasicAuthenticationHandler(
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IOptionsMonitor<AuthenticationSchemeOptions> options)
            : base(options, logger, encoder, clock)
        {
            _authURL = "http://localhost:24638/api/UserAuthApi/AuthenticateForBasicAuth";
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            try
            {
                if (!Request.Headers.ContainsKey("Authorization"))
                    return AuthenticateResult.Fail("Missing Authorization Header");
                if (!Request.Headers.ContainsKey("ClientApp"))
                    return AuthenticateResult.Fail("Missing ClientApp Header");

                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Parameter)).Split(':');
                var username = credentials.FirstOrDefault();
                var password = credentials.LastOrDefault();
                var clntapp = Request.Headers["clntapp"].ToString();

                var userData = await HttpClientHelper.SendHttpRequest<LoginModel, LoginModel>(_authURL, HttpMethod.Post, new LoginModel() { UserName = username, Password = password });
                if (userData == null || string.IsNullOrEmpty(userData.UserName))
                    return AuthenticateResult.Fail("Invalid credentials");


                var claims = new[] {
                        new Claim("uname", userData.UserName),
                        new Claim("aud", clntapp)
                    };
                var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, Scheme.Name));
                var ticket = new AuthenticationTicket(principal, Scheme.Name);
                return AuthenticateResult.Success(ticket);
            }
            catch (Exception)
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

        }
    }
}
