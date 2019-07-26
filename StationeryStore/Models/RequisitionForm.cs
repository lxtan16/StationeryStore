using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class RequisitionForm
    {
        private string id;
        private string employeeId;
        private string departmentId;
        private DateTime dateCreated;
        private string status;
        private DateTime dateApproved;
        private string remarks;

        public string Id { get { return id; }set { id = value; } }
        public string EmployeeId { get { return employeeId; }set { employeeId = value; } }
        public string DepartmentId { get { return departmentId; }set { departmentId = value; } }
        public DateTime DateCreated { get { return dateCreated; }set { dateCreated = value; } }
        public string Status { get { return status; }set { status = value; } }
        public DateTime DateApproved { get { return dateApproved; }set { dateApproved = value; } }
        public string Remarks { get { return remarks; }set { remarks = value; } }
    }
}