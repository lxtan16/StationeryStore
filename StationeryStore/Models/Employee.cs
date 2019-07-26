using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Employee
    {
        private string id;
        private string name;
        private string password;
        private string email;
        private string role;
        private string department;
        private string sessionId;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Role { get { return role; } set { role = value; } }
        public string Department { get { return department; } set { department = value; } }
        public string SessionID { get { return sessionId; } set { sessionId = value; } }
    }
}