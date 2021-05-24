using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MenaxhimiRestorantit
{
    public partial class frmRegjistrimi : Form
    {
        public string mesazhi;

        public frmRegjistrimi()
        {
            InitializeComponent();
        }

        //private void bttRegjistro_Click(object sender, EventArgs e)
        //{
        //    if (txtUsername.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Username nuk duhet te jete i zbrazet");
        //    }
        //    else if(txtEmri.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Username nuk duhet te jete i zbrazet");
        //    }
        //    else if(txtFjalekalimi.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Fjalekalimi nuk duhet te jete i zbrazet");
        //    }
        //    else if (cmbRolet.SelectedItem.ToString() == "Roli")
        //    {
        //        MessageBox.Show("Roli nuk duhet te jete i zbrazet");
        //    }
        //    else
        //    {
        //        // accessing spRegister stored procedure and return result
        //        try
        //        {
        //            using (DbContext db = new DataClassesDataContext())
        //            {
        //                int selectedIndex = cmbRolet.SelectedIndex;
        //                Object selectedItem = cmbRolet.SelectedItem.ToString();

        //                db.usp_Regjistro(txtUsername.Text, txtEmri.Text, 
        //                    txtFjalekalimi.Text, selectedIndex, PerdoruesiAktiv.Id,ref mesazhi);
        //                db.SubmitChanges();
        //            }
        //            // Result shown in Meassage Box
        //            MessageBox.Show(mesazhi, "Information",
        //                MessageBoxButtons.OK,
        //                MessageBoxIcon.Information,
        //                MessageBoxDefaultButton.Button1,
        //                MessageBoxOptions.RightAlign);
        //            Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            // Returns if any error 
        //            MessageBox.Show(ex.Message);
        //        }
        //    }
        //}

    }
}
