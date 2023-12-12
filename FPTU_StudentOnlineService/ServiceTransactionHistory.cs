using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class ServiceTransactionHistory
    {
        public string ServiceID { get; set; }
        public string ServiceName { get; set; }
        public decimal TotalAmount { get; set; }
        public int Quantity { get; set; }
        public string ServiceFormStatus { get; set; }
        public DateTime? RegistrationDate { get; set; } 

        public ServiceTransactionHistory(string serviceID, string serviceName, decimal totalAmount, int quantity, string serviceFormStatus, DateTime? registrationDate)
        {
            ServiceID = serviceID;
            ServiceName = serviceName;
            TotalAmount = totalAmount;
            Quantity = quantity;
            ServiceFormStatus = serviceFormStatus;
            RegistrationDate = registrationDate;
        }
    }
}
