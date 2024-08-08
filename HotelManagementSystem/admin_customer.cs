using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class admin_customer : UserControl
    {
        public admin_customer()
        {
            InitializeComponent();
            displayCustomers();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomers();
        }
        public void displayCustomers()
        {
            customersData cData = new customersData();
            List<customersData> listData = cData.customerListData();
            dataGridView1.DataSource = listData;
        }
    }
}
