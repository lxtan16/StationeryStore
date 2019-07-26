using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Adjustment
    {
        private string id;
        private string itemId;
        private string reason;
        private int qtyAdjusted;
        private string createdBy;
        private DateTime dateIssued;
        private string status;
        private double totalValue;

        public string Id {
            get { return id; }
            set { id = value; }
        }
        public string ItemId {
            get { return itemId; }
            set { itemId = value; }
        }
        public string Reason {
            get { return reason; }
            set { reason = value; }
        }
        public int QtyAdjusted {
            get { return qtyAdjusted; }
            set { qtyAdjusted = value; }
        }
        public string CreatedBy {
            get { return createdBy; }
            set { createdBy = value; }
        }
        public DateTime DateIssued {
            get { return dateIssued; }
            set { dateIssued = value; }
        }
        public string Status {
            get { return status; }
            set { status = value; }
        }
        public double TotalValue {
            get { return totalValue; }
            set { totalValue = value; }
        }
    }
}