using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class PurchaseOrder
    {
        private string id;
        private string supplierId;
        private string orderedBy;
        private string status;
        private DateTime dateCreated;
        private DateTime dateDelivery;

        public string Id {
            get { return id; }
            set { id = value; }
        }
        public string SupplierId {
            get { return supplierId; }
            set { supplierId = value; }
        }
        public string OrderedBy {
            get { return orderedBy; }
            set { orderedBy = value; }
        }
        public string Status {
            get { return status; }
            set { status = value; }
        }
        public DateTime DateCreated {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public DateTime DateDelivery {
            get { return dateDelivery; }
            set { dateDelivery = value; }
        }
    }
}