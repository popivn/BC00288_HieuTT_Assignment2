using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class Department
    {
        private string DepartmentID;
        private string DepartmentName;
        private string ContactEmail;
        private string ContactPhone;
        private string Location;
        private string Responsibilities;

        public string departmentID { get { return DepartmentID; } set { DepartmentID = value; } }
        public string departmentName { get { return DepartmentName; } set { DepartmentName = value; } }
        public string contactEmail { get { return ContactEmail; } set { ContactEmail = value; } }
        public string contactPhone { get { return ContactPhone; } set { ContactPhone = value; } }
        public string location { get { return Location; } set { Location = value; } }
        public string responsibilities { get { return Responsibilities; } set { Responsibilities = value; } }

        public Department(string departmentID, string departmentName, string contactEmail, string contactPhone, string location, string responsibilities)
        {
            this.DepartmentID = departmentID;
            this.DepartmentName = departmentName;
            this.ContactEmail = contactEmail;
            this.ContactPhone = contactPhone;
            this.Location = location;
            this.Responsibilities = responsibilities;
        }
    }
}
