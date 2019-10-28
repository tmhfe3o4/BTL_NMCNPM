using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace main.model
{
    public class DataConnect
    {
        private static DataConnect instant = null;
        public String strConnection;

        private DataConnect()
        {
            strConnection = "";
        }

        private static DataConnect Instant
        {
            get{
                if(instant == null)
                {
                    instant = new DataConnect();
                }
                return instant;
            }
        }
    }
}