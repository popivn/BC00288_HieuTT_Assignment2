using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class Service
    {
        private string ServiceID;
        private string UserID;
        private string ServiceTypeID;
        private string DepartmentID;
        private string TotalAmount;
        private string Quantity;
        private string ServiceFormStatus    ;

        public string serviceID { get { return ServiceID; } set { ServiceID = value; } }
        public string userID { get { return UserID; } set { UserID = value; } }
        public string serviceTypeID { get { return ServiceTypeID; } set { ServiceTypeID = value; } }
        public string departmentID { get { return DepartmentID; } set { DepartmentID = value; } }
        public string totalAmount { get { return TotalAmount; } set { TotalAmount = value; } }
        public string quantity { get { return Quantity; } set { Quantity = value; } }
        public string serviceFormStatus { get { return ServiceFormStatus; } set { ServiceFormStatus = value; } }

        public Service(string serviceID, string userID, string serviceTypeID, string departmentID, string totalAmount, string quantity, string serviceFormStatus)
        {
            this.serviceID = serviceID;
            this.userID = userID;
            this.serviceTypeID = serviceTypeID;
            this.departmentID = departmentID;
            this.totalAmount = totalAmount;
            this.quantity = quantity;
            this.serviceFormStatus = serviceFormStatus;
        }
    }
}
