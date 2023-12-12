using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class Statistical
    {
        private string Quantity;
        private string RegistrationDate;
        private string ServiceTypeDescription;

        private string Month;
        private string InformationChangeService;
        private string TuitionReductionService;
        private string StudentConfirmationService;

        public string MonthProperty { get { return Month; } set { Month = value; } }
        public string InformationChangeServiceProperty { get { return InformationChangeService; } set { InformationChangeService = value; } }
        public string TuitionReductionServiceProperty { get { return TuitionReductionService; } set { TuitionReductionService = value; } }
        public string StudentConfirmationServiceProperty { get { return StudentConfirmationService; } set { StudentConfirmationService = value; } }


        public string QuantityProperty { get { return Quantity; } set { Quantity = value; } }
        public string RegistrationDateProperty { get { return RegistrationDate; } set { RegistrationDate = value; } }
        public string ServiceTypeDescriptionProperty { get { return ServiceTypeDescription; } set { ServiceTypeDescription = value; } }

        public Statistical( string quantity, string registrationDate, string serviceTypeDescription)
        {
            this.Quantity = quantity;
            this.RegistrationDate = registrationDate;
            this.ServiceTypeDescription = serviceTypeDescription;
        }

        public Statistical(string month, string informationChangeService, string tuitionReductionService, string studentConfirmationService)
        {
            this.Month = month;
            this.InformationChangeService = informationChangeService;
            this.TuitionReductionService = tuitionReductionService;
            this.StudentConfirmationService = studentConfirmationService;
        }
    }
}
