using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace storeprocceder
{
    class Global
    {
        public static SqlConnection con = new SqlConnection(storeprocceder.Properties.Settings.Default.dbcon);

    }


}
