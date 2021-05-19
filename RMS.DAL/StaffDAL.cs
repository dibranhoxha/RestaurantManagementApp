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
        // Fatlum's connection
        string connString = "";

        // Rrezon's connection
        // string connString = "";

        // Dibran's connection
        // string connString = "";

        // Shpat's connection
        // string connString = "";


        public DataTable GetStaffList()
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("usp_GetStaffList", conn);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                return dataTable;



            }
        }

        public void InsertStaff(Sherbyesi model)
        {
            using(SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("usp_InsertSherbyesi", conn);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Emri",model.Emri);
                command.Parameters.AddWithValue("@NrPersonal",model.NrPersonal);
                command.Parameters.AddWithValue("@OrariIPunes",model.OrariIPunes);
                command.Parameters.AddWithValue("@InsertBy",model.InsertBy);
                command.Parameters.AddWithValue("@InsertDate",model.InsertDate);
                //command.Parameters.AddWithValue("@LUD");
                //command.Parameters.AddWithValue("@LUN");
                //command.Parameters.AddWithValue("@LUB");

                command.ExecuteNonQuery();
            }
        }
    }
}
