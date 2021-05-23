using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMS.BLL;

namespace RestaurantManagementApp.Staff
{
    public partial class StaffList : Form
    {
        public StaffList()
        {
            InitializeComponent();
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            //StaffBLL staffBLL = new StaffBLL();
            //DataTable list = staffBLL.ShowStaff();
            //dgvStaffList.DataSource = list;
        }
    }
}
