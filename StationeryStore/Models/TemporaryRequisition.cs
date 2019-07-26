using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class TemporaryRequisition
    {
        private string itemId;
        private string description;
        private int qty;
        private string employeeId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }


    }
}