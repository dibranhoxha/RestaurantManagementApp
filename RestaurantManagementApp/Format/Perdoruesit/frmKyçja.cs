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
using RMS.BO;

namespace MenaxhimiRestorantit
{
    public partial class frmKyçja : Form
    {
        public frmKyçja()
        {
            InitializeComponent();
        }
        PerdoruesitBLL perdoruesitBLL = new PerdoruesitBLL();

        private void bttKyçu_Click_1(object sender, EventArgs e)
        {
            string mesazhi = perdoruesitBLL.KyçPerdorues(txtUsername.Text, txtFjalekalimi.Text);

            MessageBox.Show(mesazhi);
            if (PerdoruesiAktiv.LoggedIn == true)
            {
                Hide();
                if (PerdoruesiAktiv.Autorizohet("Administrator"))
                {
                    frmRegjistrimi AdminHome = new frmRegjistrimi();
                    AdminHome.Show();
                }
            }
        }
    }
    }


    