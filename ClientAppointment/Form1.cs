using System;
using System.Data;
using System.Data.SqlClient;//needed to import to bridge the data base sql server
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ClientAppointment
{
    public partial class Form1 : Form
    {
        // Connection string to the database
        private const string ConnectionString = "Data Source=LAPTOP-R6NA64TT\\SQLEXPRESS;Initial Catalog=\"Appointment Scheduling\";Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // This method functions as executes a given query with the provided parameters
        private void ExecuteQuery(string query, Action<SqlCommand> addParameters)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        addParameters(cmd);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Added successful." : "Added failed.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        //method that ensure the time format is valid 
        private string GetValidTime()
        {
            if (DateTime.TryParse(CBTime.Text.Trim(), out DateTime parsedTime))
                return parsedTime.ToString("HH:mm:ss");
            MessageBox.Show("Invalid time format. Please use HH:mm:ss.");
            return string.Empty;
        }
        // method that has a function to generate a PDF with appointment details
        private void GeneratePdf()
        {
            string filePath = "C:\\Users\\Meri\\Downloads\\appointment_details.pdf";
            using (Document doc = new Document())
            {
                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();
                doc.Add(new Paragraph("Appointment Details"));
                doc.Add(new Paragraph($"Name: {TxtBxName.Text.Trim()}"));
                doc.Add(new Paragraph($"Contact: {TxtBxContactNumber.Text.Trim()}"));
                doc.Add(new Paragraph($"Date: {dateTimePicker.Value.ToShortDateString()}"));
                doc.Add(new Paragraph($"Time: {CBTime.Text.Trim()}"));
                doc.Add(new Paragraph($"Details: {RTBNotes.Text.Trim()}"));
                doc.Add(new Paragraph($"Reschedule: {(RBYes.Checked ? "Yes" : "No")}"));
            }
            MessageBox.Show("PDF generated successfully!");
        }
        //a button submit to add the information into the data base table
        private void submitBtn_Click_1(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Appointments (Name, [Contact Number], Date, Time, [Appointment Details], Reschedule) 
                             VALUES (@Name, @ContactNumber, @Date, @Time, @AppointmentDetails, @Reschedule)";

            // Open connection and execute the SQL query
            ExecuteQuery(query, (cmd) =>
            {
                cmd.Parameters.AddWithValue("@Name", TxtBxName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", TxtBxContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Time", GetValidTime());
                cmd.Parameters.AddWithValue("@AppointmentDetails", string.IsNullOrEmpty(RTBNotes.Text) ? DBNull.Value : (object)RTBNotes.Text.Trim());
                cmd.Parameters.AddWithValue("@Reschedule", RBYes.Checked ? 1 : 0);
            });
            // Ask the user if they want a PDF copy
            var result = MessageBox.Show("Do you want to generate a PDF of the appointment?",
                                         "Generate PDF",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the user clicks 'Yes', generate the PDF using the method GeneratePdf
            if (result == DialogResult.Yes)
            {
                GeneratePdf();
            }
            MessageBox.Show("Thank you!");
        }
        // An Update Appointment that has same primary key which is same name
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                string q = "UPDATE Appointments SET " +
                           "Name = @Name, " +
                           "[Contact Number] = @ContactNumber, " +
                           "Date = @Date, " +
                           "Time = @Time, " +
                           "[Appointment Details] = @AppointmentDetails, " +
                           "Reschedule = @Reschedule " +
                           "WHERE Name = @Name";  
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.Parameters.AddWithValue("@Name", TxtBxName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactNumber", TxtBxContactNumber.Text.Trim());
                cmd.Parameters.AddWithValue("@Date", dateTimePicker.Value);
                cmd.Parameters.AddWithValue("@Time", GetValidTime());
                cmd.Parameters.AddWithValue("@AppointmentDetails", string.IsNullOrEmpty(RTBNotes.Text) ? DBNull.Value : (object)RTBNotes.Text.Trim());
                cmd.Parameters.AddWithValue("@Reschedule", RBYes.Checked ? 1 : 0);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment updated successfully!");
                }
                else
                {
                    MessageBox.Show("No appointment found with the specified name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        //A Delete button that delete the same primary key which is same name like the update button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                // SQL Delete Query to delete the appointment based on Name
                string query = "DELETE FROM Appointments WHERE Name = @Name";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", TxtBxName.Text.Trim()); 
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Appointment deleted successfully!");
                }
                else
                {
                    MessageBox.Show("No appointment found with the provided name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // A read button that when click you can see the data in table and the update,delete and the create
        private void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                string q = "SELECT * FROM Appointments";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridAppointments.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }

}



