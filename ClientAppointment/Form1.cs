using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ClientAppointment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=YANYAN\\SQLEXPRESS;Initial Catalog=Appointment;Integrated Security=True;Encrypt=False";
            using (SqlConnection con = new SqlConnection(connectionString))
                {
                    try
                    {
                        con.Open();

                        // Define the SQL query using parameterized commands
                        string query = @"INSERT INTO Appointment (Name, [Contact Number], Date, Time, Notes) 
                             VALUES (@Name, @ContactNumber, @Date, @Time, @Notes)";

                        using (SqlCommand sqlCommand = new SqlCommand(query, con))
                        {
                            // Add parameters to prevent SQL injection
                            sqlCommand.Parameters.AddWithValue("@Name", TxtBxName.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@ContactNumber", TxtBxContactNumber.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Date", dateTimePicker.Value.Date);
                            sqlCommand.Parameters.AddWithValue("@Time", CBTime.Text.Trim());
                            sqlCommand.Parameters.AddWithValue("@Notes", RTBNotes.Text.Trim());

                            // Execute the query
                            int rowsAffected = sqlCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Appointment has been added successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add the appointment.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Show the error message for debugging
                        MessageBox.Show($"SQL Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        // Handle other exceptions
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                
            }


        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
