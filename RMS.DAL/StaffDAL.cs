using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using RMS.BO;

namespace RMS.DAL
{
    public class StaffDAL
    {
        public DataTable GetStaffList()
        {
            using(DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.dataAdapter = new SqlDataAdapter("usp_GetStaffList", DatabaseConn.conn);
                DataTable dataTable = new DataTable();
                DatabaseConn.dataAdapter.Fill(dataTable);

                return dataTable;
            }
        }

        public void InsertStaff(Sherbyesi model)
        {
            using(DatabaseConn.conn = new SqlConnection(DatabaseConn.connString))
            {
                DatabaseConn.command = new SqlCommand("usp_InsertSherbyesi", DatabaseConn.conn);
                DatabaseConn.command.CommandType = CommandType.StoredProcedure;

                DatabaseConn.command.Parameters.AddWithValue("@Emri",model.Emri);
                DatabaseConn.command.Parameters.AddWithValue("@NrPersonal",model.NrPersonal);
                DatabaseConn.command.Parameters.AddWithValue("@OrariIPunes",model.OrariIPunes);
                DatabaseConn.command.Parameters.AddWithValue("@InsertBy",model.InsertBy);
                DatabaseConn.command.Parameters.AddWithValue("@InsertDate",model.InsertDate);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                DatabaseConn.command.ExecuteNonQuery();
            }
        }
    }
}
