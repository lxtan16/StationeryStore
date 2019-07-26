using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Category
    {
        private int id;
        private string categoryName;

        public int Id { set { id = value; } get { return id; } }
        public string CategoryName { set { categoryName = value; } get { return categoryName; } }
    }
}