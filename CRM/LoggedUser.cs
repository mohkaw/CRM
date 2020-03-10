using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class LoggedUser
    {
        private string userName;
        private int userID;

        

        public string UserName { get => userName; set => userName = value; }
        public int UserID { get => userID; set => userID = value; }
    }
}
