using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Item
    {
        private string id;
        private string description;
        private string categoryName;
        private double unitPrice;
        private int reorderLevel;
        private int reorderQuantity;
        private int quantity;
        private string unit;
        private int binNumber;

        public string Id { get { return id; } set { id = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string CategoryName { get { return categoryName; } set { categoryName = value; } }
        public double UnitPrice { get { return unitPrice; } set { unitPrice = value; } }
        public int ReorderLevel { get { return reorderLevel; } set { reorderLevel = value; } }
        public int ReorderQuantity { get { return reorderQuantity; } set { reorderQuantity = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public string Unit { get { return unit; } set { unit = value; } }
        public int BinNumber { get { return binNumber; } set { binNumber = value; } }
    }
}