using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem
{
    public partial class staffBookRoom : UserControl
    {
        public staffBookRoom()
        {
            InitializeComponent();
                displayRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayRooms();
        }

        public void displayRooms()
        {
            roomsData rData = new roomsData();
            List<roomsData> listData = rData.roomsDataList();
            dataGridView1.DataSource = listData;
        }
        private int getID = 0;
        private decimal regprice = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value; 
                bookRoom_roomID.Text = row.Cells[1].Value.ToString();
                bookRoom_roomType.Text = row.Cells[2].Value.ToString();
                bookRoom_roomName.Text = row.Cells[3].Value.ToString();
                bookRoom_regPrice.Text = (Convert.ToInt32(row.Cells[4].Value)).ToString("000");

                regprice = Convert.ToDecimal(row.Cells[4].Value);

                bookRoom_imageView.ImageLocation = row.Cells[5].Value.ToString();
                bookRoom_status.Text = row.Cells[6].Value.ToString();

            }
        }

        private void bookRoom_scheduleBtn_Click(object sender, EventArgs e)
        {
            // Lấy giá trị ngày bắt đầu và ngày kết thúc từ các điều khiển (controls) trên form
            DateTime fromDate = bookRoom_from.Value;
            DateTime toDate = bookRoom_to.Value;

            // Tính toán số ngày giữa ngày kết thúc và ngày bắt đầu
            TimeSpan countDays = toDate - fromDate;

            // Chuyển đổi số ngày từ TimeSpan thành số nguyên
            int days = countDays.Days;

            // Tính tổng giá tiền dựa trên số ngày và giá đăng ký
            decimal totalPrice = (days + regprice);

            // Kiểm tra nếu tổng giá tiền nhỏ hơn 0, hiện thông báo lỗi
            if (totalPrice < 0)
            {
                MessageBox.Show("Có vấn đề ở đây", "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                bookRoom_total.Text = "000";
            }
            // Kiểm tra nếu tổng giá tiền bằng 0, đặt giá trị tổng tiền bằng giá đăng ký
            else if (totalPrice == 0)
            {
                bookRoom_total.Text = regprice.ToString("000");
            }
            // Nếu tổng giá tiền hợp lệ, tính toán tổng tiền và hiển thị
            else
            {
                bookRoom_total.Text = (days * regprice).ToString();
            }
        }

        private void bookRoom_bookBtn_Click(object sender, EventArgs e)
        {

            if(regprice == 0 || bookRoom_total.Text == "0.00" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(bookRoom_status.Text != "Active")
            {
                MessageBox.Show("Phòng không tồn tại", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hotelData.roomID = bookRoom_roomID.Text;
                hotelData.fromDate = bookRoom_from.Value;
                hotelData.toDate = bookRoom_to.Value;
                hotelData.price = bookRoom_total.Text;
                Form formbg = new Form();
                try
                {
                    using (clientInfo ciForm = new clientInfo())
                    {
                        ciForm.Owner = formbg;
                        ciForm.ShowDialog();
                        formbg.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex, "Báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                finally
                {
                    formbg.Dispose();
                }
            }
        }

        private void bookRoom_to_ValueChanged(object sender, EventArgs e)
        {

        }
        public void clearField()
        {
            bookRoom_roomID.Text = "----------";
            bookRoom_roomType.Text = "----------";
            bookRoom_roomName.Text = "----------";
            bookRoom_status.Text = "----------";
            bookRoom_total.Text = "0.00";
            bookRoom_regPrice.Text = "0.00";
            bookRoom_imageView.Image = null;
        }
        private void bookRoom_clearBtn_Click(object sender, EventArgs e)
        {
            clearField();
        }
    }
}
