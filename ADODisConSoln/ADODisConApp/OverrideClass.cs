using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODisConApp
{
    public class OverrideClass : Program
    {
        public override void FetchAndDisplayProfileUsingSP()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("proc_Fetchprofiles", conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                Console.WriteLine("Id : " + dataRow[0]);
                Console.WriteLine("Name : " + dataRow["Name"]);
                Console.WriteLine("Age : " + dataRow[2]);
                Console.WriteLine("Qualification : " + dataRow[3]);
                Console.WriteLine("IsEmployed : " + dataRow[4]);
                Console.WriteLine("NoticePeriod : " + dataRow["NoticePeriod"]);
                Console.WriteLine("CurrentCTC : " + dataRow[6]);
                Console.WriteLine("UserName : " + dataRow[7]);
                Console.WriteLine("-------------------------");
            }
        }

    }
}