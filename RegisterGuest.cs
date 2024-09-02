using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
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

        

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Guest", con);
            SqlDataAdapter myAdapter = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            myAdapter.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
            int lastRowIndex = dataGridView1.Rows.Count - 1;

            MessageBox.Show("Index: " + lastRowIndex);

            string connectionString = "Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True"; // Replace with your actual connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    connection.Open();
                    string query = "INSERT INTO Guest (guest_name, guest_surname, guest_email, g_phone_number, guest_address, guest_nationality, guest_preferences) VALUES (@Name, @Surname, @Email, @Cell, @Address, @Nationality, @Preferences)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    //cmd.Parameters.AddWithValue("@ID", lastRowIndex); S/O TO TEBZA!!
                    cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
                    cmd.Parameters.AddWithValue("@Surname", Surname_txt.Text);
                    cmd.Parameters.AddWithValue("@Email", Email_txt.Text);
                    cmd.Parameters.AddWithValue("@Cell", Cell_txt.Text);
                    cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
                    cmd.Parameters.AddWithValue("@Nationality", Nationality_txt.Text);
                    cmd.Parameters.AddWithValue("@Preferences", Preferences_txt.Text);

                    MessageBox.Show("Guest successfully registered");
                    // Your code to execute after opening the connection
                    
                    cmd.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }



            }
            /*
            con = new SqlConnection();
            con.Open();
            string query = "INSERT INTO Guest (guest_id, guest_name, guest_surname, guest_email, g_phone_number, guest_address, guest_nationality, guest_preferences) VALUES (@Pass, @Name, @Surname, @Email, @Cell, @Address, @Nationality, @Preferences)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", Cell_txt.Text);
            cmd.Parameters.AddWithValue("@Name", Name_txt.Text);
            cmd.Parameters.AddWithValue("@Surname", Surname_txt.Text);
            cmd.Parameters.AddWithValue("@Email", Email_txt.Text);
            cmd.Parameters.AddWithValue("@Cell", Cell_txt.Text);
            cmd.Parameters.AddWithValue("@Address", Address_txt.Text);
            cmd.Parameters.AddWithValue("@Nationality", Nationality_txt.Text);
            cmd.Parameters.AddWithValue("@Preferences", Preferences_txt.Text);

            //Not sure what to do with the check in checkbox just enter recommended code here.
            cmd.ExecuteNonQuery();
            */
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
    }
}
