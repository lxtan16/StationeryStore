using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StationeryStore.Models
{
    public class Disbursement
    {
        private string id;
        private string departmentId;
        private int collectionPoint;
        private string status;
        private DateTime dateCreated;
        private string collectedBy;
        private string remarks;
        private string otp;
        private string img;






        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }

        public int CollectionPoint
        {
            get { return collectionPoint; }
            set { collectionPoint = value; }
        }

        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        public string CollectedBy
        {
            get { return collectedBy; }
            set { collectedBy = value; }
        }

        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        public string Otp
        {
            get { return otp; }
            set { otp = value; }
        }

        public string Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
