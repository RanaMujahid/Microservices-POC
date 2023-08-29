namespace SecureAuth
{
    public class LoginModel
    {
        public long UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ClientApp { get; set; } = string.Empty;
    }
}
