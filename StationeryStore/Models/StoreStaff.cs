using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class StoreStaff
    {
        private string id;
        private string name;
        private string pwd;
        private string email;
        private string role;
        private string sessionId;

        public string Id {
            get { return id; }
            set { id = value; }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Pwd {
            get { return pwd; }
            set { pwd = value; }
        }
        public string Email {
            get { return email; }
            set { email = value; }
        }
        public string Role {
            get { return role; }
            set { role = value; }
        }
        public string SessionId {
            get { return sessionId; }
            set { sessionId = value; }
        }
    }
}