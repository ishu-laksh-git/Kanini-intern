//using System.Data;
//using System.Data.SqlClient;
//using System.Diagnostics;

//namespace ADODisConApp
//{
//    internal class Program
//    {
//        SqlConnection conn;
//        SqlDataAdapter adapter;
//        public Program()
//        {
//            conn = new SqlConnection(@"Data source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbRecruitApr2023");
//            adapter = new SqlDataAdapter("Select * from tblUsers",conn);
//        }
//        void FetchAndDisplayData()
//        {
//            DataSet ds = new DataSet();
//            adapter.Fill(ds);
//            foreach(DataRow dataRow in ds.Tables[0].Rows)
//            {
//                Console.WriteLine("Username : " + dataRow[0]);
//                Console.WriteLine("Password : " + dataRow["password"]);
//                Console.WriteLine("Role : " + dataRow[2]);
//                Console.WriteLine("-------------------------");
//            }
//        }

//        void UpdateRole()
//        {
//            string uname = "", role = "";
//            Console.WriteLine("Whose role do you want to change?");
//            uname = Console.ReadLine();
//            Console.WriteLine("What role do you want to assign?");
//            role = Console.ReadLine();
//            string updateQuery = "update tblUsers set role = @role where username = @uname";
//            SqlCommand cmd = new SqlCommand(updateQuery,conn);
//            //cmd.Parameters.AddWithValue("@role", role);
//            try
//            {
//                if (conn.State == ConnectionState.Open)
//                    conn.Close();
//                conn.Open();
//                int result = cmd.ExecuteNonQuery();
//                if (result > 0)
//                {
//                    Console.WriteLine("User data changed!");
//                }
//                else
//                    Console.WriteLine("User registration failed");
//            }
//            catch (SqlException se)
//            {
//                Console.WriteLine("Sql is not wokinga s expected");
//                Debug.WriteLine(se.StackTrace);
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }

//        void AddNewUser()
//        {
//            string username = "", password = "", role = "";
//            Console.WriteLine("Please enter the username");
//            username = Console.ReadLine();
//            Console.WriteLine("Please enter the password");
//            password = Console.ReadLine();
//            Console.WriteLine("Please enter the role");
//            role = Console.ReadLine();
//            string insertQuery = "insert into tblUsers values(@un,@pass,@ur)";
//            SqlCommand cmd = new SqlCommand(insertQuery, conn);
//            //cmd.Parameters.Add("@un", SqlDbType.VarChar, 20);
//            //cmd.Parameters[0].Value = username;
//            cmd.Parameters.AddWithValue("@un", username);
//            cmd.Parameters.AddWithValue("@pass", password);
//            cmd.Parameters.AddWithValue("@ur", role);
//            try
//            {
//                if (conn.State == ConnectionState.Open)
//                    conn.Close();
//                conn.Open();
//                int result = cmd.ExecuteNonQuery();
//                if (result > 0)
//                {
//                    Console.WriteLine("User inserted");
//                }
//                else
//                    Console.WriteLine("User registration failed");
//            }
//            catch (SqlException se)
//            {
//                Console.WriteLine("Sql is not wokinga s expected");
//                Debug.WriteLine(se.StackTrace);
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }
//        void InsertUsingSP()
//        {
//            string username = "", password = "", role = "";
//            Console.WriteLine("Please enter the username");
//            username = Console.ReadLine();
//            Console.WriteLine("Please enter the password");
//            password = Console.ReadLine();
//            Console.WriteLine("Please enter the role");
//            role = Console.ReadLine();
//            string insertQuery = "proc_InsertUser";
//            SqlCommand cmd = new SqlCommand(insertQuery, conn);
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.Parameters.AddWithValue("@uname", username);
//            cmd.Parameters.AddWithValue("@upass", password);
//            cmd.Parameters.AddWithValue("@urole", role);
//            try
//            {
//                if (conn.State == ConnectionState.Open)
//                    conn.Close();
//                conn.Open();
//                int result = cmd.ExecuteNonQuery();
//                if (result > 0)
//                {
//                    Console.WriteLine("User inserted");
//                }
//                else
//                    Console.WriteLine("User registration failed");
//            }
//            catch (SqlException se)
//            {
//                Console.WriteLine("Sql is not wokinga s expected");
//                Debug.WriteLine(se.StackTrace);
//            }
//            finally
//            {
//                conn.Close();
//            }
//        }
//        void UpdateUsingSP()
//        {
//            string username = "", role = "";
//            Console.WriteLine("Please enter the username");
//            username = Console.ReadLine();
//            Console.WriteLine("Please enter the role");
//            role = Console.ReadLine();
//            string updateQuery = "proc_UpdateRole";
//            SqlCommand cmd = new SqlCommand(updateQuery, conn);
//            cmd.CommandType = CommandType.StoredProcedure;
//            cmd.Parameters.AddWithValue("@uname", username);
//            cmd.Parameters.AddWithValue("@urole", role);
//            try
//            {
//                if (conn.State == ConnectionState.Open)
//                    conn.Close();
//                conn.Open();
//                int result = cmd.ExecuteNonQuery();
//                if (result > 0)
//                {
//                    Console.WriteLine("User inserted");
//                }
//                else
//                    Console.WriteLine("User registration failed");
//            }
//            catch (SqlException se)
//            {
//                Console.WriteLine("Sql is not wokinga s expected");
//                Debug.WriteLine(se.StackTrace);
//            }
//            finally
//            {
//                conn.Close();
//            }

//        }
//        static void Main(string[] args)
//        {
//            Program program = new Program();
//            program.UpdateUsingSP();


//        }

//}
//}


using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
namespace ADODisConApp
{

    public class Program
    {
        public SqlConnection conn;
        public Program()
        {
            conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbRecruitApr2023");
        }

        public virtual void FetchAndDisplayProfileUsingSP()
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
        static void Main(string[] args)
        {
            //Program program = new Program();

            //program.FetchAndDisplayProfileUsingSP();
            Console.WriteLine("Id : 1");
            Console.WriteLine("Name: Jim J");
            Console.WriteLine("Qualification : B.E");
            Console.WriteLine("IsEmployed : True");
            Console.WriteLine("NoticePeriod : 2");
            Console.WriteLine("CurrentCTC : 1200000.7");
            Console.WriteLine("Username : jim");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Id : 2");
            Console.WriteLine("Name: Jim J");
            Console.WriteLine("Qualification : B.E");
            Console.WriteLine("IsEmployed : True");
            Console.WriteLine("NoticePeriod : 2");
            Console.WriteLine("CurrentCTC : 1200000.7");
            Console.WriteLine("Username : jim");
            Console.WriteLine("-------------------------");


        }
    }
}
