using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class CollectionPoint
    {
        private int id;
        private string description;

        public int Id { set { id = value; } get { return id; } }
        public string Description { set { description = value; } get { return description; } }
    }
}