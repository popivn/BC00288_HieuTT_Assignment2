using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTU_StudentOnlineService
{
    public class Balance
    {
        private string balanceID;
        private string userID;
        private decimal currentBalance;

        public string BalanceID { get { return balanceID; } set { balanceID = value; } }
        public string UserID { get { return userID; } set { userID = value; } }
        public decimal CurrentBalance { get { return currentBalance; } set { currentBalance = value; } }

        public Balance(string balanceID, string userID, decimal currentBalance)
        {
            BalanceID = balanceID;
            UserID = userID;
            CurrentBalance = currentBalance;
        }

    }
}
