using System;

namespace FTU_StudentOnlineService
{
    internal class TuitionReductionService
    {
        private string ReductionID;
        private string ServiceID;
        private string Course;
        private decimal Fee;
        private string Certificate;
        private string Major;
        private DateTime RegistrationDate;
        private string PhoneNumber;
        private string DeliveryMethod;
        private string ResultDeliveryMethod;

        public string ReductionIDProp { get { return ReductionID; } set { ReductionID = value; } }
        public string ServiceIDProp { get { return ServiceID; } set { ServiceID = value; } }
        public string CourseProp { get { return Course; } set { Course = value; } }
        public decimal FeeProp { get { return Fee; } set { Fee = value; } }
        public string CertificateProp { get { return Certificate; } set { Certificate = value; } }
        public string MajorProp { get { return Major; } set { Major = value; } }
        public DateTime RegistrationDateProp { get { return RegistrationDate; } set { RegistrationDate = value; } }
        public string PhoneNumberProp { get { return PhoneNumber; } set { PhoneNumber = value; } }
        public string DeliveryMethodProp { get { return DeliveryMethod; } set { DeliveryMethod = value; } }
        public string ResultDeliveryMethodProp { get { return ResultDeliveryMethod; } set { ResultDeliveryMethod = value; } }

        public TuitionReductionService(string reductionid, string serviceID, string course, decimal fee, string certificate, string major, DateTime registrationDate, string phoneNumber, string deliveryMethod, string resultDeliveryMethod)
        {
            ReductionIDProp = reductionid;
            ServiceIDProp = serviceID;
            CourseProp = course;
            FeeProp = fee;
            CertificateProp = certificate;
            MajorProp = major;
            RegistrationDateProp = registrationDate;
            PhoneNumberProp = phoneNumber;
            DeliveryMethodProp = deliveryMethod;
            ResultDeliveryMethodProp = resultDeliveryMethod;
        }
    }
}
