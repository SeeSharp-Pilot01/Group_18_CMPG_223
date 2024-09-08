using System;
using System.Collections;
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
    public partial class Booking : Form
    {
        public static float housePrice = 0;
        public static float areaPrice = 0;
        public static float totalPrice = 0;
        public static string guestHName = "";
        public static string areaType = "";
        public static string Booking_Status = "";

        public Booking()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASUSX515-TABU;Initial Catalog=IsintuBookings;Integrated Security=True");

        SqlDataAdapter myAdapter;
        DataTable mydataSet;
        int i = 0;




        private void button3_Click(object sender, EventArgs e)
        {


            string query = "";
            int NumDays = 0;
            Booking_Status = "Active";

            //Numeric updown code 
            if (nud_EG.Value > 0)
            {
                NumDays = (int)nud_EG.Value;

            }
            else if (nud_WBG.Value > 0)
            {
                NumDays = (int)nud_EG.Value;
            }
            else if (nud_NG.Value > 0)
            {
                NumDays = (int)nud_EG.Value;
            }
            else if (nud_MV.Value > 0)
            {
                NumDays = (int)nud_EG.Value;
            }



            //Checkbox code goes here 
            if (expG_chb.Checked)
            {
                guestHName = "Explorer Guesthouse";



            }
            else if (wbG_chb.Checked)
            {
                guestHName = "Willow Brooke Guesthouse";
            }
            else if (ndG_chb.Checked)
            {
                guestHName = "Ndlunkulu Guesthouse";
            }
            else if (mtG_chb.Checked)
            {
                guestHName = "Mountain Villa";
            }


            con.Open();
            try
            {

                string query1 = "SELECT house_number FROM GuestHouse WHERE house_name = @HouseName";
                SqlCommand cmdH = new SqlCommand(query1, con);


                using (cmdH)
                {
                    // parameter prevents SQL injection
                    cmdH.Parameters.AddWithValue("@HouseName", guestHName);

                    using (SqlDataAdapter myAdapter = new SqlDataAdapter(cmdH))
                    {
                        DataTable mydataSet = new DataTable();
                        myAdapter.Fill(mydataSet);

                        if (mydataSet.Rows.Count > 0)
                        {
                            // Return the house number if found
                            i = Convert.ToInt32(mydataSet.Rows[0]["house_number"]);
                        }
                        else
                        {
                            MessageBox.Show("No house found with the specified name.");
                        }
                    }
                }


            }
            catch (SqlException error)
            {
                MessageBox.Show("An error occurred while querying the database: ");
            }

            con.Close();


            //Open connection string for INSERT 
            con.Open();

            // Restricted to one house entry per row , will look into how I can change this  
            query = "INSERT INTO Booking (booking_date, booking_payment, arrival_date, departure_date, total_cost, booking_status, Num_of_days, guest_id, house_number) VALUES (@BookingDate, @BookingPayment, @ArrivalDate, @DepartureDate, @TotalCost, @BookingStatus, @NumOfDays, @GuestId, @HouseNumber)";
            SqlCommand cmd1 = new SqlCommand(query, con);
            cmd1.Parameters.AddWithValue("@BookingDate", System.DateTime.Today);
            cmd1.Parameters.AddWithValue("@BookingPayment", totalPrice);
            cmd1.Parameters.AddWithValue("@ArrivalDate", dateTimePicker1.Value);
            cmd1.Parameters.AddWithValue("@DepartureDate", dateTimePicker2.Value);
            cmd1.Parameters.AddWithValue("@TotalCost", totalPrice);
            cmd1.Parameters.AddWithValue("@BookingStatus", Booking_Status);
            cmd1.Parameters.AddWithValue("@NumOfDays", NumDays);
            cmd1.Parameters.AddWithValue("@GuestId", Log1.i);
            cmd1.Parameters.AddWithValue("@HouseNumber", i);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Booking has been successfuly executed");
            //Close connection string for Insert
        }

        //admin_Id, house_number
        //@AdminId, @HouseNumber

        private void button2_Click(object sender, EventArgs e)
        {
            totalPrice = 0;

            /* if (expG_chb.Checked)
             {
                 housePrice = 800;
                 totalPrice = totalPrice + housePrice;

                 if (resE_rdb.Checked)
                 {
                     areaPrice = 150;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Resedential Area";
                 }
                 else if (riverE_rdb.Checked)
                 {
                     areaPrice = 200;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Next To River";
                 }
                 else if (mtnE_rdb.Checked)
                 {
                     areaPrice = 250;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Mountain Side";
                 }
                 else
                 {
                     MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                 guestHName = "Explorer Guesthouse";
             }
             else if (wbG_chb.Checked)
             {


                 housePrice = 1000;
                 totalPrice = totalPrice + housePrice;

                 if (resE_rdb.Checked)
                 {
                     areaPrice = 150;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Resedential Area";
                 }
                 else if (riverE_rdb.Checked)
                 {
                     areaPrice = 200;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Next To River";
                 }
                 else if (mtnE_rdb.Checked)
                 {
                     areaPrice = 250;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Mountain Side";
                 }
                 else
                 {
                     MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

                 guestHName = "Willow Brooke Guesthouse";
             }
             else if (ndG_chb.Checked)
             {
                 housePrice = 1200;
                 totalPrice = totalPrice + housePrice;

                 if (resE_rdb.Checked)
                 {
                     areaPrice = 150;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Resedential Area";
                 }
                 else if (riverE_rdb.Checked)
                 {
                     areaPrice = 200;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Next To River";
                 }
                 else if (mtnE_rdb.Checked)
                 {
                     areaPrice = 250;
                     totalPrice = totalPrice + areaPrice;
                     areaType = "Mountain Side";
                 }
                 else
                 {
                     MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }

                 guestHName = "Ndlunkulu Guesthouse";
             }
             else if (mtG_chb.Checked)
             {
                 housePrice = 1400;
                 totalPrice = totalPrice + housePrice;
                 guestHName = "Mountain Villa";
             }
             else
             {
                 MessageBox.Show("Please select a guesthouse type. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/




            Cost_Summary cost_Summary = new Cost_Summary();
            cost_Summary.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (expG_chb.Checked)
            {
                expGuest = 600;
                totalPrice = totalPrice + expGuest;

                if (resE_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverE_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnE_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (wbG_chb.Checked)
            {
                wbGuest = 800;
                totalPrice = totalPrice + wbGuest;

                if (resW_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverW_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnW_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (ndG_chb.Checked)
            {
                ndGuest = 950;
                totalPrice = totalPrice + ndGuest;

                if (resN_rdb.Checked)
                {
                    resArea = 150;
                    totalPrice = totalPrice + resArea;
                }
                else if (riverN_rdb.Checked)
                {
                    riverArea = 200;
                    totalPrice = totalPrice + riverArea;
                }
                else if (mtnN_rdb.Checked)
                {
                    mtnArea = 250;
                    totalPrice = totalPrice + mtnArea;
                }
                else
                {
                    MessageBox.Show("Please select a area to be situated in. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (mtG_chb.Checked)
            {
                mtGuest = 1200;
                totalPrice = totalPrice + mtGuest;
            }
            else
            {
                MessageBox.Show("Please select a guesthouse type. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            */


            Activities activities = new Activities();
            activities.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void resW_rdb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void riverW_rdb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void mtnW_rdb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void expG_chb_CheckedChanged(object sender, EventArgs e)
        {
            if (expG_chb.Checked)
            {
                mtG_chb.Checked = false;
                ndG_chb.Checked = false;
                wbG_chb.Checked = false;
            }
            if (mtG_chb.Checked)
            {
                expG_chb.Checked = false;
                ndG_chb.Checked = false;
                wbG_chb.Checked = false;
            }
            if (ndG_chb.Checked)
            {
                mtG_chb.Checked = false;
                expG_chb.Checked = false;
                wbG_chb.Checked = false;
            }
            if (wbG_chb.Checked)
            {
                mtG_chb.Checked = false;
                ndG_chb.Checked = false;
                expG_chb.Checked = false;
            }

        }

        private void Booking_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
