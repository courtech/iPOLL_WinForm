using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOTING_SYSTEM_IDKENERMOR
{
    public class dbc
    {
        public static OleDbConnection con;
        internal static OleDbDataAdapter bridge;
        internal static OleDbCommand cmd;
        internal static DataSet ds;
        public static void Connect()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        }
    }
}
