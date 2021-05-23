using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.DAL;
using System.Data;
using RMS.BO;

namespace RMS.BLL
{
    public class StaffBLL
    {
        private readonly StaffDAL staffDAL;

        public StaffBLL() {
            staffDAL = new StaffDAL();
        }

        public DataTable ShowStaff()
        {
            return staffDAL.GetStaffList();
        }

        
        public void GetStaffMVP()
        {

        }
    }
}
