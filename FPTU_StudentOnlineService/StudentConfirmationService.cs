using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class StudentConfirmationService
    {
        private string ConfirmationID;
        private string ServiceID;
        private decimal Fee;
        private string Major;
        private string ConfirmationType;
        private string PhoneNumber;
        private string FileAttached;
        private DateTime RegistrationDate;
        private string Description;
        private string DeliveryMethod;
        private string ResuiltDeliveryMethod;

        public string ConfirmationIDProp { get { return ConfirmationID; } set { ConfirmationID = value; } }
        public string ServiceIDProp { get { return ServiceID; } set { ServiceID = value; } }
        public decimal FeeProp { get { return Fee; } set { Fee = value; } }
        public string MajorProp { get { return Major; } set { Major = value; } }
        public string ConfirmationTypeProp { get { return ConfirmationType; } set { ConfirmationType = value; } }
        public string PhoneNumberProp { get { return PhoneNumber; } set { PhoneNumber = value; } }
        public string FileAttachedProp { get { return FileAttached; } set { FileAttached = value; } }
        public DateTime RegistrationDateProp { get { return RegistrationDate; } set { RegistrationDate = value; } }
        public string DescriptionProp { get { return Description; } set { Description = value; } }
        public string DeliveryMethodProp { get { return DeliveryMethod; } set { DeliveryMethod = value; } }
        public string ResuiltDeliveryMethodProp { get { return ResuiltDeliveryMethod; } set { ResuiltDeliveryMethod = value; } }

        public StudentConfirmationService(string confirmationID, string serviceID, decimal fee, string major, string confirmationType, string phoneNumber, string fileAttached, DateTime registrationDate, string description, string deliveryMethod, string resuiltDeliveryMethod)
        {
            ConfirmationIDProp = confirmationID;
            ServiceIDProp = serviceID;
            FeeProp = fee;
            MajorProp = major;
            ConfirmationTypeProp = confirmationType;
            PhoneNumberProp = phoneNumber;
            FileAttachedProp = fileAttached;
            RegistrationDateProp = registrationDate;
            DescriptionProp = description;
            DeliveryMethodProp = deliveryMethod;
            ResuiltDeliveryMethodProp = resuiltDeliveryMethod;
        }
    }
}
