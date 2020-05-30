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
    class Medicine
    {
        SqlConnection con;
        SqlCommand cmd;
        public int M_Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public DateTime M_Date { get; set; }
        public DateTime E_Date { get; set; }
        public int Price { get; set; }
        public int Unit { get; set; }

        public int DM_Id { get; set; }
        public string Description { get; set; }

        public int Prescribe_Id { get; set; }
        public int P_Id { get; set; }
        public string Morning { get; set; }
        public string Afternoon { get; set; }
        public string Evening { get; set; }
        public string Night { get; set; }
        public string Time {get;set;}
        public int Days { get; set; }
        public string Remark { get; set; }
        

        public Medicine()
        {
            con = new SqlConnection("Data Source=DIVYASHAH;Initial Catalog=PRMS;Integrated Security=True");
        }

        public void addPrescription()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "INSERT INTO Prescription VALUES(@id,@name,@morning,@afternoon,@evening,@night,@time,@days,@remark)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", P_Id);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@morning", Morning);
                cmd.Parameters.AddWithValue("@afternoon", Afternoon);
                cmd.Parameters.AddWithValue("@evening", Evening);
                cmd.Parameters.AddWithValue("@night", Night);
                cmd.Parameters.AddWithValue("@time", Time);
                cmd.Parameters.AddWithValue("@days", Days);
                cmd.Parameters.AddWithValue("@remark", Remark);
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
        public void deletePrescription()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Prescription WHERE Prescribe_id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", Prescribe_Id);
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
        public void addDocMedicine()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "INSERT INTO Doctor_Medicine VALUES(@Name,@Company,@Description)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Company", Company);
                cmd.Parameters.AddWithValue("@Description", Description);
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
        public void addMedicine()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "INSERT INTO Medicine VALUES(@Name,@Company,@M_Date,@E_Date,@Price,@Unit)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Company", Company);
                cmd.Parameters.AddWithValue("@M_Date", M_Date);
                cmd.Parameters.AddWithValue("@E_Date", E_Date);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
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
        public void deleteMedicine()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Medicine WHERE M_id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", M_Id);
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
        public void updateMedicine()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "UPDATE Medicine SET Name = @Name,Company = @Company,Manufacturing-Date = @M_Date,Expired-Date = @E_Date,Price = @Price,Unit = @Unit WHERE M_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", M_Id);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Company", Company);
                cmd.Parameters.AddWithValue("@M_Date", M_Date);
                cmd.Parameters.AddWithValue("@E_Date", E_Date);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Unit", Unit);
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
        public int totalIncome()
        {
            int count = 0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select SUM(Total_Amount) FROM Pharmacist_Payemnt_Receipt WHERE Bill_Date=@date";
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
        public void addToBill(Form form)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "Select * From Patients WHERE P_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", P_Id);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    s = "SELECT * FROM Medicine WHERE Name = @name";
                    cmd = new SqlCommand(s, con);
                    cmd.Parameters.AddWithValue("@name", Name);
                    sdr = cmd.ExecuteReader();
                    sdr.Read();
                    var aUnit = Convert.ToInt32(sdr["Unit"]);
                    if (Unit>=aUnit)
                    {
                        MessageBox.Show("Medicine Out Of Stock.");
                        sdr.Close();
                    }
                    else
                    {
                        Price = Convert.ToInt32(sdr["Price"]);
                        sdr.Close();
                        s = "INSERT INTO Bill VALUES(@id,@name,@unit,@price)";
                        cmd = new SqlCommand(s, con);
                        cmd.Parameters.AddWithValue("@id", P_Id);
                        cmd.Parameters.AddWithValue("@name", Name);
                        cmd.Parameters.AddWithValue("@unit", Unit);
                        cmd.Parameters.AddWithValue("@price", Price);
                        cmd.ExecuteNonQuery();
                        s = "UPDATE Medicine SET Unit=@new WHERE Name=@name1";
                        cmd = new SqlCommand(s, con);
                        cmd.Parameters.AddWithValue("@name1", Name);
                        cmd.Parameters.AddWithValue("@new", (aUnit - Unit));
                        cmd.ExecuteNonQuery();
                        Bill_generate bg = new Bill_generate();
                        form.Close();
                        bg.Show();
                    }
                }
                else
                {
                    MessageBox.Show("No Patient with that Id Registered.");
                    sdr.Close();
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
        public void generateBill()
        {
            int total_amount=0;
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "SELECT * FROM Bill";
                cmd = new SqlCommand(s, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                int bid=0;
                while(sdr.Read())
                {
                    total_amount = total_amount + (Convert.ToInt32(sdr["Unit"]) * Convert.ToInt32(sdr["Price"]));
                    P_Id = Convert.ToInt32(sdr["P_Id"]);
                    bid = Convert.ToInt32(sdr["Bill_Id"]);
                }
                sdr.Close();
                s = "INSERT INTO Pharmacist_Payemnt_Receipt VALUES(@Pid,@Bill_Date,@Total_Amount)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Pid", P_Id);
                cmd.Parameters.AddWithValue("@Bill_Date", DateTime.Today);
                cmd.Parameters.AddWithValue("@Total_Amount", total_amount);
                cmd.ExecuteNonQuery();
                s = "SELECT * FROM Patients WHERE P_Id=@Pid";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Pid", P_Id);
                sdr = cmd.ExecuteReader();
                sdr.Read();
                var name = sdr["Name"];
                sdr.Close();
        
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("D:/P_Bill" + name + bid.ToString() +".pdf", FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph("Pharmacy Bill", FontFactory.GetFont("TIMES_ROMAN", 26, Font.BOLD, BaseColor.BLACK));
                p.Alignment = Element.ALIGN_CENTER;
                document.Add(p);

                Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
                document.Add(line);

                Paragraph p1 = new Paragraph("DATE: " + DateTime.Today.ToString() + "\nPatient ID: " + P_Id + "\nPatient Name: " + name, FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                p1.Alignment = Element.ALIGN_LEFT;
                document.Add(p1);

                Paragraph p2 = new Paragraph("Doctor Name: Dr. Shah \n Contact No: +91 9872571590", FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                p2.Alignment = Element.ALIGN_RIGHT;
                p2.SpacingBefore = -55f;
                document.Add(p2);



                PdfPTable table = new PdfPTable(5);

                table.AddCell("No.");
                table.AddCell("Medicine Name");
                table.AddCell("Unit");
                table.AddCell("Price");
                table.AddCell("Total");

                s = "SELECT * FROM Bill";
                cmd = new SqlCommand(s, con);
                int i = 1;
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    table.AddCell(i.ToString());
                    table.AddCell(sdr["Medicine_Name"].ToString());
                    table.AddCell(sdr["Unit"].ToString());
                    table.AddCell(sdr["Price"].ToString());
                    table.AddCell((Convert.ToInt32(sdr["Unit"]) * Convert.ToInt32(sdr["Price"])).ToString());
                    i++;
                }
                sdr.Close();
                PdfPCell cell = new PdfPCell(new Phrase("Total Amount"));
                cell.Colspan = 4;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                table.AddCell(cell);
                table.AddCell(total_amount.ToString());
                table.SpacingBefore = 25f;
                document.Add(table);


                Paragraph p3 = new Paragraph("Signature", FontFactory.GetFont("TIMES_ROMAN", 15, BaseColor.BLACK));
                p3.Alignment = Element.ALIGN_RIGHT;
                p3.SpacingBefore = 45f;
                document.Add(p3);
                document.Close();

                s = "TRUNCATE TABLE Bill";
                cmd = new SqlCommand(s, con);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
