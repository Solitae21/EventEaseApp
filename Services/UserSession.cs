namespace EventEaseApp.Services
{
    public class UserSession
    {
        public string UserName { get; set; } = string.Empty;
        public bool IsRegistered { get; set; } = false;
        public HashSet<string> RegisteredEvents { get; set; } = new();
    }
}
