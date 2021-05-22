using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS.BO
{
    public class Staff
    {
        public int StaffID { get; set; }
        public string Emri { get; set; }
        public int NrPersonal { get; set; }
        public DateTime Datelindja { get; set; }
        public DateTime OrariIPunes { get; set; }
        public int Roli { get; set; }
        public int Shitjet { get; set; }
        public int InsertBy { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LUD { get; set; }
        public int LUN { get; set; }
        public int LUB { get; set; }
    }
}
