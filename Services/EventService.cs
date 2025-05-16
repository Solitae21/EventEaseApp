using EventEaseApp.Models;

namespace EventEaseApp.Services
{
    public class EventService
    {
        public List<Event> GetEvents() => new()
    {
        new Event { Id = 1, Name = "Tech Conference 2025", Date = new DateTime(2025, 06, 20), Location = "Manila" },
        new Event { Id = 2, Name = "Business Seminar", Date = new DateTime(2025, 07, 10), Location = "Quezon City" }
    };
    }
}
