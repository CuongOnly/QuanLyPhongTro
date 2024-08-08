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

namespace HotelManagementSystem
{
    public partial class admin_dashboard : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cuong\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_dashboard()
        {
            InitializeComponent();

            displayTotalStaff();
            displayAvailableRooms();
            displayProfitTotal();
            displayProfitToday();
            displayAllRooms();
        }
        //???
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalStaff();
            displayAvailableRooms();
            displayProfitTotal();
            displayProfitToday();
            displayAllRooms();
        }
        // hthi ds phong
        // autosizecolumn -> fill
        public void displayAllRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();
            dataGridView1.DataSource = listData;
        }
        public void displayTotalStaff()
        {
            using(SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Staff'";
                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if(result != DBNull.Value)
                    {
                        totalStaff.Text = result.ToString();
                    }
                }
            }
        }
        public void displayAvailableRooms()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Active' OR status = 'Available'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        availableRoom.Text = result.ToString();
                    }
                }
            }
        }
        public void displayProfitTotal()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT SUM(price) FROM customer ";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalProfit.Text = "$" + result.ToString() + ".000";
                    }
                }
            }
        }
        public void displayProfitToday()
        {
            using (SqlConnection connect = new SqlConnection(conn))
            {
                connect.Open();
                string selectData = "SELECT SUM(price) FROM customer where date_book = @dbook";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {

                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@dbook", today);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        profitToday.Text = "$" + result.ToString() + ".000";
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
