
using System.Data;
using System.Data.SqlClient;
namespace UderstandingADOApp
{
    internal class Program
    {
        SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbRecruitApr2023");    

        }
        public void display()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tblUsers",conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow dataRow in ds.Tables[0].Rows)
            {
                Console.WriteLine("Username : " + dataRow[0]);
                Console.WriteLine("Password : " + dataRow[1]);
                Console.WriteLine("Role : "+ dataRow[2]);
                Console.WriteLine("________________________");
            }
        }

        public void AddData()
        {
            string uname = "", passwrd = "", role = "";
            Console.WriteLine("Add details section:");
            Console.WriteLine("Enter the username:");
            uname = Console.ReadLine();
            Console.WriteLine("Enter the password:");
            passwrd= Console.ReadLine();
            Console.WriteLine("Enter the role:");
            role = Console.ReadLine();
            string insertQuery = "insert into tblUsers values(@uname,@passwrd,@role)";
            SqlCommand sqlCommand = new SqlCommand(insertQuery,conn);
            sqlCommand.Parameters.AddWithValue("@uname", uname);
            sqlCommand.Parameters.AddWithValue("@passwrd", passwrd);
            sqlCommand.Parameters.AddWithValue("@role", role);
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                int result = sqlCommand.ExecuteNonQuery();
                if(result>0)
                {
                    Console.WriteLine("Success!! :)");
                }
                else
                {
                    Console.WriteLine("Not success :(");
                }

            }
            catch(SqlException se)
            {
                Console.WriteLine("Connection le kashtam...sutham"); ;
            }
            finally
            {
                conn.Close();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.display();
            program.AddData();

        }
    }
}