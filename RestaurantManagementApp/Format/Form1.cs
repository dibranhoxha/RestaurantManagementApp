using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using MenaxhimiRestorantit;
=======
using RestaurantManagementApp.Format.Produktet;
using RestaurantManagementApp.Format.Tavolinat;
using RestaurantManagementApp.Format.Porosite;
>>>>>>> 4983142e25fe093a83eafc67f2be1f2456f72c2e

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
            Produktet produktetForm = new Produktet();
            produktetForm.Show();
        }

        private void btnTavolinat_Click(object sender, EventArgs e)
        {
            Tavolinat tavolinatForm = new Tavolinat();
            tavolinatForm.Show();
        }

<<<<<<< HEAD
        private void bttnKycu_Click(object sender, EventArgs e)
        {
            frmKyçja Kyçja = new frmKyçja();
            Kyçja.Show();
        }
    }
=======
		private void btnPorosia_Click(object sender, EventArgs e)
		{
            Porosia porosiaForm = new Porosia();
            porosiaForm.Show();
        }
	}
>>>>>>> 4983142e25fe093a83eafc67f2be1f2456f72c2e
}
