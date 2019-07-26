using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class SupplierItem
    {
        private string id;
        private string itemId;
        private double unitPrice;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }
    }
}