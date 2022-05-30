using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace StoreProcedurePraticeSession
{
    class SqlMethods
    {
        public static SqlConnection con = new SqlConnection(StoreProcedurePraticeSession.Properties.Settings.Default.DBcon);
    }
}
