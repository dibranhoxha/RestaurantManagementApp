using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenaxhimiRestorantit;

namespace RestaurantManagementApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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

        private void btnTavolinat_Click(object sender, EventArgs e)
        {
            Format.Tavolinat.Tavolinat tavolinatForm = new Format.Tavolinat.Tavolinat();
            tavolinatForm.Show();
        }

        private void bttnKycu_Click(object sender, EventArgs e)
        {
            frmKyçja Kyçja = new frmKyçja();
            Kyçja.Show();
        }
    }
}
