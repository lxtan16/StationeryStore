using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class PurchaseOrderDetails
    {
        private string id;
        private string itemId;
        private int qty;

        public string Id {
            get { return id; }
            set { id = value; }
        }
        public string ItemId {
            get { return itemId; }
            set { itemId = value; }
        }
        public int Qty {
            get { return qty; }
            set { qty = value; }
        }
    }
}