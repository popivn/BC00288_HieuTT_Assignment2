using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class Users
    {
        private string UserID;
        private string RoletypeID;
        private string Name;
        private string Password;
        private string Phonenumber;
        private string Gmail;
        private string StudentStatus;
        private string Major;

        public string userID { get { return UserID ; } set { UserID = value; } }
        public string roletypeID { get { return RoletypeID; } set { RoletypeID = value; } }
        public string name { get { return Name; } set { Name = value; } }
        public string password { get { return Password; } set { Password = value; } }
        public string phonenumber { get { return Phonenumber; } set { Phonenumber = value; } }
        public string gmail { get { return Gmail; } set { Gmail = value; } }
        public string studentStatus { get { return StudentStatus; } set { StudentStatus = value; } }
        public string major { get { return Major; } set { Major = value; } }

        public Users(string userID, string roletypeID, string name, string password, string phonenumber, string gmail, string studentStatus, string major)
        {
            this.UserID = userID;
            this.RoletypeID = roletypeID;
            this.Name = name;
            this.Password = password;
            this.Phonenumber = phonenumber;
            this.Gmail = gmail;
            this.StudentStatus = studentStatus;
            this.Major = major;
        }
    }
}
