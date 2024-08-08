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
    public partial class Form1 : Form
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\cuong\Documents\hotel.mdf;Integrated Security=True;Connect Timeout=30";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Hãy điền đầy đủ các dòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection connect = new SqlConnection(conn))
                {
                    connect.Open();
                    string selectData = " SELECT * FROM users WHERE (username = @usern AND password = @pass) AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect)) 
                    {
                        cmd.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        
                        adapter.Fill(table);

                        if (table.Rows.Count != 0) { 
                            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // lấy vai trò người dùng
                            string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";
                            using(SqlCommand getRole = new SqlCommand(selectRole, connect)){
                                getRole.Parameters.AddWithValue("@usern", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@pass", login_password.Text.Trim());
                                string userRole = getRole.ExecuteScalar() as string; // vai trò người dùng

                                // dựa trên vai trò chuyển hướng người dùng
                                if(userRole == "Admin")
                                {
                                    AdminMainForm adminForm = new AdminMainForm();
                                    adminForm.Show(); // mở form admin
                                    this.Hide(); // ẩn form đăng nhập 
                                }
                                else if(userRole == "Staff")
                                {
                                    staffMainForm staffForm = new staffMainForm();
                                    staffForm.Show(); // mở form staff
                                    this.Hide(); // ẩn form đăng nhập 
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
            }
        }
    }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }
    }
}
