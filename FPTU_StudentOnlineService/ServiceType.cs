using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class ServiceType
    {
        private string ServiceTypeID;
        private string ServiceName;
        private string Description;

        public string serviceTypeID { get { return ServiceTypeID; } set { ServiceTypeID = value; } }
        public string serviceName { get { return ServiceName; } set { ServiceName = value; } }
        public string sescription { get { return Description; } set { Description = value; } }

        public ServiceType(string serviceTypeID, string serviceName, string sescription)
        {
            this.ServiceTypeID = serviceTypeID;
            this.ServiceName = serviceName;
            this.Description = sescription;
        }
    }
}
