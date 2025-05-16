namespace EventEaseApp.Services
{
    public class AuthService
    {
        public bool IsLoggedIn { get; private set; } = false;
        public string UserName { get; private set; } = string.Empty;

        public void Login(string name)
        {
            IsLoggedIn = true;
            UserName = name;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            UserName = string.Empty;
        }
    }
}
