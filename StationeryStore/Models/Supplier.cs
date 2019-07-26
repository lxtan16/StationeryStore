using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Supplier
    {
        private string id; 
        private string name; 
        private string contactName; 
        private string phone; 
        private string fax; 
        private string address; 
        private string registrationNo;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string RegistrationNo
        {
            get { return registrationNo; }
            set { registrationNo = value; }
        }
    }
}