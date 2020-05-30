using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Patient_Record_Management_System.Class
{
    class Appointment
    {
        SqlConnection con;
        SqlCommand cmd;

        public int A_id { get; set; }
        public int P_id { get; set; }
        public DateTime Date { get; set; }
        public string time { get; set; }

        public Appointment()
        {
            con = new SqlConnection("Data Source=DIVYASHAH;Initial Catalog=PRMS;Integrated Security=True");
        }

        public Appointment(int v1, int v2, DateTime dateTime, string v3)
        {
            A_id = v1;
            P_id = v2;
            Date = dateTime;
            time = v3;
            con = new SqlConnection("Data Source=DIVYASHAH;Initial Catalog=PRMS;Integrated Security=True");
        }

        public void addAppointment(Form form)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select * From Patients WHERE P_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", P_id);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    s = "SELECT * FROM Appointment WHERE Date = @date AND Time = @time";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@time", time);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Slot already booked.Select another.");
                        sdr.Close();
                    }
                    else
                    {
                        sdr.Close();
                        s = "INSERT INTO Appointment VALUES(@id,@date,@time)";
                        cmd = new SqlCommand(s, con);
                        cmd.Parameters.AddWithValue("@id", P_id);
                        cmd.Parameters.AddWithValue("@date", Date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.ExecuteNonQuery();
                        Manage_appointment ma = new Manage_appointment();
                       
                        form.Close();
                        ma.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No Patient with that Id Registered.");
                    sdr.Close();
                    Add_Patient ap = new Add_Patient();
                    form.Close();
                    ap.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
         
        }
        public void updateAppointment(Form form)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select * From Patients WHERE P_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", P_id);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    s = "SELECT * FROM Appointment WHERE Date = @date AND Time = @time";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@time", time);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        MessageBox.Show("Slot already booked.Select another.");
                        sdr.Close();
                    }
                    else
                    {
                        sdr.Close();
                        s = "UPDATE Appointment SET P_Id=@id,Date=@date,Time=@time WHERE A_Id = @aid";
                        cmd = new SqlCommand(s, con);
                        cmd.Parameters.AddWithValue("@id", P_id);
                        cmd.Parameters.AddWithValue("@date", Date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@aid", A_id);
                        cmd.ExecuteNonQuery();
                        Manage_appointment ma = new Manage_appointment();

                        form.Close();
                        ma.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No Patient with that Id Registered.");
                    sdr.Close();
                    Add_Patient ap = new Add_Patient();
                    form.Close();
                    ap.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
        }
        public void deleteAppointment()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Appointment WHERE A_id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", A_id);
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
        public void generateBill()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "SELECT * FROM Doctor_Payment_Receipt WHERE A_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", A_id);
                SqlDataReader sdr = cmd.ExecuteReader();
                if(sdr.Read())
                {
                    sdr.Close();
                    MessageBox.Show("Bill Already Generated");
                }
                else
                {
                    sdr.Close();
                    s = "SELECT * FROM Doctor_Payment_Receipt WHERE P_Id = @pid";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@pid", P_id);
                    int amt;
                    sdr = cmd.ExecuteReader();
                    if(sdr.Read())
                    {
                        sdr.Close();
                        amt = 250;
                    }
                    else
                    {
                        sdr.Close();
                        amt = 500;
                    }
                    s = "INSERT INTO Doctor_Payment_Receipt VALUES(@aid,@pid,@date,@amount)";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@aid", A_id);
                    cmd.Parameters.AddWithValue("@pid", P_id);
                    cmd.Parameters.AddWithValue("@date", Date);
                    cmd.Parameters.AddWithValue("@amount", amt);
                    cmd.ExecuteNonQuery();
                    s = "SELECT * FROM Patients WHERE P_Id = @id";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@id", P_id);
                    sdr = cmd.ExecuteReader();
                    sdr.Read();
                    var name = sdr["Name"].ToString();
                    sdr.Close();
                    Document document = new Document();
                    PdfWriter.GetInstance(document, new FileStream("D:/Bill"+A_id+".pdf", FileMode.Create));
                    document.Open();
                    Paragraph p = new Paragraph("Doctor Appointment Bill", FontFactory.GetFont("TIMES_ROMAN", 26, Font.BOLD, BaseColor.BLACK));
                    p.Alignment = Element.ALIGN_CENTER;
                    document.Add(p);

                    Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                    document.Add(line);

                    Paragraph p1 = new Paragraph("DATE: " + Date + "\nPatient ID: " + P_id + "\nPatient Name: " + name , FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                    p1.Alignment = Element.ALIGN_LEFT;
                    document.Add(p1);

                    Paragraph p2 = new Paragraph("Doctor Name: Dr. Shah \n Contact No: +91 9872571590", FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                    p2.Alignment = Element.ALIGN_RIGHT;
                    p2.SpacingBefore = -55f;
                    document.Add(p2);



                    PdfPTable table = new PdfPTable(3);

                    table.AddCell("No.");
                    table.AddCell("Subject");
                    table.AddCell("Amount");

                    table.AddCell("1");
                    table.AddCell("Consulting Charge");
                    table.AddCell(amt.ToString());

                    PdfPCell cell = new PdfPCell(new Phrase("Total"));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table.AddCell(cell);
                    table.AddCell(amt.ToString());
                    table.SpacingBefore = 25f;
                    document.Add(table);


                    Paragraph p3 = new Paragraph("Signature", FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                    p3.Alignment = Element.ALIGN_RIGHT;
                    p3.SpacingBefore = 45f;
                    document.Add(p3);
                    document.Close();

                }
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
        public int todayAppointment()
        {
            int count = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select COUNT(*) FROM Appointment WHERE Date=@date";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
            return count;
        }
        public int totalIncome()
        {
            int count = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select SUM(Amount) FROM Doctor_Payment_Receipt WHERE Date=@date";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                count = (int)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
            return count;
        }
    }
}
