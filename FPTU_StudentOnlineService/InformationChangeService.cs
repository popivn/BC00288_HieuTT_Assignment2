using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class InformationChangeService
    {
        private string ChangeID;
        private string ServiceID;
        private string ChangeType;
        private decimal Fee;
        private DateTime RegistrationDate;
        private string Major;
        private string Description;
        private string FileAttached;

        public string ChangeIDProp { get { return ChangeID; } set { ChangeID = value; } }
        public string ServiceIDProp { get { return ServiceID; } set { ServiceID = value; } }
        public string ChangeTypeProp { get { return ChangeType; } set { ChangeType = value; } }
        public decimal FeeProp { get { return Fee; } set { Fee = value; } }
        public DateTime RegistrationDateProp { get { return RegistrationDate; } set { RegistrationDate = value; } }
        public string MajorProp { get { return Major; } set { Major = value; } }
        public string DescriptionProp { get { return Description; } set { Description = value; } }
        public string FileAttachedProp { get { return FileAttached; } set { FileAttached = value; } }

        public InformationChangeService(string changeID, string serviceID, string changeType, decimal fee, DateTime registrationDate, string major, string description, string fileAttached)
        {
            ChangeIDProp = changeID;
            ServiceIDProp = serviceID;
            ChangeTypeProp = changeType;
            FeeProp = fee;
            RegistrationDateProp = registrationDate;
            MajorProp = major;
            DescriptionProp = description;
            FileAttachedProp = fileAttached;
        }
    }
}
