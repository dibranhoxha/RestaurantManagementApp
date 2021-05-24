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
using RestaurantManagementApp.Format.Porosite;

namespace RestaurantManagementApp.Format.Porosite
{
	public partial class Porosia : Form
	{
		public Porosia()
		{
			InitializeComponent();
		}

		private void Porosia_Load(object sender, EventArgs e)
		{
			ProduktetBLL produktetBLL = new ProduktetBLL();
			cmbTavolina.DataSource = produktetBLL.ShowProduktet();
			cmbTavolina.DisplayMember = "Emri";
			cmbTavolina.ValueMember = "ProduktiID";
		}

		private void btnZgjedhProduktet_Click(object sender, EventArgs e)
		{
			ProduktetPerPorosi produktetForm = new ProduktetPerPorosi();
			produktetForm.Show();
		}
	}
}
