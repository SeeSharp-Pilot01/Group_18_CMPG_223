using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace iSintu_Bookings
{
    public partial class Log1 : Form
    {
        public Log1()
        {
            InitializeComponent();
        }



        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");


        SqlDataAdapter myAdapter;
        DataTable mydataSet;
        SqlDataReader myDataReaderG;
        public static string username, password;
        public static int i = 0;

        private void Login_btn_Click(object sender, EventArgs e)
        {
            username = User_txt.Text;
            password = Passw_txt.Text;
            try
            {
                con.Open();

                SqlCommand commG = new SqlCommand("SELECT * FROM Guest WHERE guest_email = '" + User_txt.Text + "' AND guest_password = '" + Passw_txt.Text + "'", con);
                myAdapter = new SqlDataAdapter();
                mydataSet = new DataTable();


                myAdapter.SelectCommand = commG;
                myAdapter.Fill(mydataSet);

                myDataReaderG = commG.ExecuteReader();




                if (mydataSet.Rows.Count > 0)
                {
                    username = User_txt.Text;
                    password = Passw_txt.Text;
                    i = Convert.ToInt32(mydataSet.Rows[0]["guest_id"]);

                    Booking booking = new Booking();
                    booking.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    User_txt.Clear();
                    Passw_txt.Clear();
                    //to focus on username
                    User_txt.Focus();
                }

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            // i = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["guest_Id"].FormattedValue.ToString());


        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Passw_txt.Clear();
            User_txt.Clear();
        }

        private void Hide_cbx_CheckedChanged(object sender, EventArgs e)
        {

            if (Hide_cbx.Checked)
            {
                Passw_txt.UseSystemPasswordChar = false;
            }
            else
            {
                Passw_txt.UseSystemPasswordChar = true;
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            RegisterGuest register = new RegisterGuest();
            register.Show();
            this.Hide();
        }

        private void Log1_Load(object sender, EventArgs e)
        {
           /* ManageBookings managebookings = new ManageBookings();
            managebookings.Show();

            Admin1 admin1 = new Admin1();
            admin1.Show()*/

            Booking booking1 = new Booking();
            booking1.Show();

            //RegisterGuest registerguest1 = new RegisterGuest();
           // registerguest1.Show();

            Cost_Summary cost_Summary1 = new Cost_Summary();
            cost_Summary1.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
