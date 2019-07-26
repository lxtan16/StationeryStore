using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Department
    {
        private string id;
        private string name;
        private string contactName;
        private string telephone;
        private string fax;
        private string headName;
        private string repName;
        private int collectionPoint;

        public string Id { set { id = value; } get { return id; } }
        public string Name { set { name = value; } get { return name; } }
        public string ContactName { set { contactName = value; } get { return contactName; } }
        public string Telephone { set { telephone = value; } get { return telephone; } }
        public string Fax { set { fax = value; } get { return fax; } }
        public string HeadName { set { headName = value; } get { return headName; } }
        public string RepName { set { repName = value; } get { return repName; } }
        public int CollectionPoint { set { collectionPoint = value; } get { return collectionPoint; } }

    }
}