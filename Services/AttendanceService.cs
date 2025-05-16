using EventEaseApp.Models;
using System.Collections.Generic;

namespace EventEaseApp.Services
{
    public class AttendanceService
    {
        private readonly List<AttendanceModel> _registrations = new();

        public void RegisterUser(AttendanceModel registration)
        {
            _registrations.Add(registration);
        }

        public List<AttendanceModel> GetRegistrations()
        {
            return _registrations;
        }
    }
}
