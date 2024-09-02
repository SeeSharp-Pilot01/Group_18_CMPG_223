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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");
        
        SqlDataAdapter myAdapter;
        DataTable mydataSet;
        public static string username, password;
        private void Login_btn_Click(object sender, EventArgs e)
        {
            username = User_txt.Text;
            password = Passw_txt.Text;
            try
            {
                con.Open();
               
                
                SqlCommand commA = new SqlCommand("SELECT * FROM Administrator WHERE admin_email = '" + User_txt.Text + "' AND admin_password = '" + Passw_txt.Text + "'", con);
                myAdapter = new SqlDataAdapter();
                mydataSet = new DataTable();

               
                myAdapter.SelectCommand = commA;
                myAdapter.Fill(mydataSet);



                if (mydataSet.Rows.Count > 0)
                {
                    username = User_txt.Text;
                    password = Passw_txt.Text;

                    ManageBookings managebooking = new ManageBookings();
                    managebooking.Show();
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


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            con.Close();
           
        }
    }
}
