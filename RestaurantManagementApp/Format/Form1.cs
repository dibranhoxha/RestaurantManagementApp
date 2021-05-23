using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagementApp.Staff;

namespace RestaurantManagementApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void btnStafi_Click(object sender, EventArgs e)
        {
			StaffList staffListForm = new StaffList();
			staffListForm.Show();
        }

        private void btnStatistikat_Click(object sender, EventArgs e)
        {
			Statistikat statistikatForm = new Statistikat();
			statistikatForm.Show();
        }

        private void btnProduktet_Click(object sender, EventArgs e)
        {
            Format.Produktet.Produktet produktetForm = new Format.Produktet.Produktet();
            produktetForm.Show();
        }
    }
}
