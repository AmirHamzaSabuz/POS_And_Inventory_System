using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_And_Inventory_System
{
    class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=DESKTOP-1NSPU91\MSSQL_HAMZA;Initial Catalog=POS_DEMO_DB;Integrated Security=True";
            return con;
        }
    }
}
