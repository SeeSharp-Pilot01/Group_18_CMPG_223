using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSintu_Bookings
{
    public partial class RegisterGuest : Form
    {

        public RegisterGuest()
        {
            InitializeComponent();
        }







        /// <summary>
        /// test code above
        /// </summary>

        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");
        SqlDataAdapter myAdapter;
        DataTable mydataSet;

        private bool IsValidEmail(string email)
        {
            // Regular expression for validating email format
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /*con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Guest", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
            int lastRowIndex = dataGridView1.Rows.Count - 1;

            MessageBox.Show("Index: " + lastRowIndex);*/

            string connectionString = "Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {



                    connection.Open();
                    string query = "INSERT INTO Guest (guest_name, guest_surname, guest_email, g_phone_number, guest_address, guest_nationality, guest_preferences, guest_password) VALUES (@Name, @Surname, @Email, @Cell, @Address, @Nationality, @Preferences, @Password)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //cmd.Parameters.AddWithValue("@ID", lastRowIndex); S/O TO TEBZA!!
                    cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname_txt.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_txt.Text);
                    cmd.Parameters.AddWithValue("@Cell", Cell_txt.Text);
                    cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
                    cmd.Parameters.AddWithValue("@Nationality", cmbx1.SelectedText);
                    cmd.Parameters.AddWithValue("@Preferences", Preferences_txt.Text);
                    cmd.Parameters.AddWithValue("@Password", Password_txt.Text);
                    MessageBox.Show("Guest successfully registered, please note your username is: " + cmbx1.SelectedText); //Users username is their email
                    // Your code to execute after opening the connection

                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }



            }


            con.Close();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterGuest_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Cell_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
