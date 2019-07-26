using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Delegation
    {
        private string departmentId;
        private DateTime dateFrom;
        private DateTime dateTo;
        private string employeeId;

        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public DateTime DateFrom
        {
            get { return dateFrom; }
            set { dateFrom = value; }
        }
        public DateTime DateTo
        {
            get { return dateTo; }
            set { dateTo = value; }
        }
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
    }
}