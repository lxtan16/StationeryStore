using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class DisbursementDetails
    {
        private string id;
        private string itemId;
        private int qtyRetrieved;
        private int qtyCollected;
        

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
        public int QtyRetrieved
        {
            get { return qtyRetrieved; }
            set { qtyRetrieved = value; }
        }
        public int QtyCollected
        {
            get { return qtyCollected; }
            set { qtyCollected = value; }
        }
       
        
    }
}