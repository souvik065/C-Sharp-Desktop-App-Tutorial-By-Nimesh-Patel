
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SPPracticeSession2
{
    class SqlMethods
    {
        public static SqlConnection con = new SqlConnection(SPPracticeSession2.Properties.Settings.Default.DBcon);

    }

}
