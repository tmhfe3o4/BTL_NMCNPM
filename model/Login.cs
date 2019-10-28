using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace main.model
{
    public class Login
    {
        private static Login instant = null;
        public String email;
        public String password;
        public String strConnection;
        private Login()
        {
            email = "";
            password = "";
            strConnection = "";
        }
        public static Login GetInstant
        {
            get
            {
                if (instant == null)
                {
                    instant = new Login();
                }
                return instant;
            }
        }
    }
}