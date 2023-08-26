using HsopitalModelLib;
using System.Data;

namespace HospitalDAL
{
    public class Repository : IRepoD<Doctor, int>
    {
        SqlConnection conn;
        public Repository()
        {
            conn = new SqlConnection(@"Data Source=LAPTOP-					GBCUGLF4\SQLEXPRESS;Integrated Security=true;Initial 			Catalog=db_Hospital");
        }
        public Doctor AddD(Doctor item)
        {
            SqlCommand cmd = new SqlCommand("proc_Insert_Doctor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dname", item.name);
            cmd.Parameters.AddWithValue("@age", item.age);
            cmd.Parameters.AddWithValue("@exp", item.experience);
            cmd.Parameters.AddWithValue("@consultfee", item.consultationfee);
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            if (result > 0)
            {
                conn.Open();
                cmd = new SqlCommand("proc_Get_DLatestId", conn);
                item.id = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                conn.Close();
                return item;
            }
            return null;
        }

        public Doctor GetD(int key)
        {
            SqlCommand cmd = new SqlCommand("proc_Show_Single_Doctor", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", key);
            Doctor doctor = new Doctor();
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
                return null;
            if (reader.Read())
            {
                doctor.id = Convert.ToInt32(reader[0].ToString());
                doctor.name = reader[1].ToString();
                doctor.age = Convert.ToInt32(reader[2].ToString());
                doctor.experience = Convert.ToInt32(reader[3].ToString());
                doctor.consultationfee = float.Parse(reader[4].ToString());
            }
            conn.Close();
            return doctor;
        }

        public ICollection<Doctor> getDAll()
        {
            List<Doctor> doctors = new List<Doctor>();
            SqlCommand cmd = new SqlCommand("proc_Show_Doctors", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (!reader.HasRows)
            {
                return null;
            }
            while (reader.Read())
            {
                Doctor doctor = new Doctor();
                doctor.id = Convert.ToInt32(reader[0].ToString());
                doctor.name = reader[1].ToString();
                doctor.age = Convert.ToInt32(reader[2].ToString());
                doctor.experience = Convert.ToInt32(reader[3].ToString());
                doctor.consultationfee = float.Parse(reader[4].ToString());
                doctors.Add(doctor);
            }
            conn.Close();
            return doctors;
        }

        public Doctor RemoveD(int key)
        {
            Doctor doctor = new Doctor();
            doctor = GetD(key);
            if (doctor != null)
            {
                SqlCommand cmd = new SqlCommand("proc_Delete_Doctor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", key);
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    return doctor;
                }
            }
            return null;
        }
    }
}

}