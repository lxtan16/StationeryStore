using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class RequisitionDetails
    {
        private string id;
        private string itemId;
        private int quantity;
        private string disbursementId;

        public string Id { set { id = value; }get { return id; } }
        public string ItemId { set { itemId = value; }get { return itemId; } }
        public int Quantity { set { quantity = value; } get { return quantity; } }
        public string DisbursementId { set { disbursementId = value; }get { return disbursementId; } }
    }
}