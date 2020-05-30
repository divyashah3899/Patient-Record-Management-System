using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient_Record_Management_System.Class
{
    class Patient
    {
        SqlConnection con;
        SqlCommand cmd;
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string contactno { get; set; }
        public Patient()
        {
            con = new SqlConnection("Data Source=DIVYASHAH;Initial Catalog=PRMS;Integrated Security=True");
        }
        public void addPatient()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "INSERT INTO Patients VALUES(@Name,@Contact,@Address,@Email)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Contact", contactno);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
        }
        public void updatePatient()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "UPDATE Patients SET Name = @Name,ContactNo = @Contact,Address = @Address,EmailId = @email WHERE P_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Contact", contactno);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
        }
        public void deletePatient()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Patients WHERE P_id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }

        }
    }
}
