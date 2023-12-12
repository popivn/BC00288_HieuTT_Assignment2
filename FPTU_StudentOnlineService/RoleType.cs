using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    internal class RoleType
    {
        private string RoleTypeID;
        private string RoleName;
        private string Description;

        public string RoleTypeIDProp { get { return RoleTypeID; } set { RoleTypeID = value; } }
        public string RoleNameProp { get { return RoleName; } set { RoleName = value; } }
        public string DescriptionProp { get { return Description; } set { Description = value; } }

        public RoleType(string userID, string roletypeID, string name)
        {
            this.RoleTypeIDProp = userID;
            this.RoleNameProp = roletypeID;
            this.DescriptionProp = name;
        }
    }
}
