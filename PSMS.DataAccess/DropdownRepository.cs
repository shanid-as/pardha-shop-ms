using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dapper;
using PSMS.Domain;

namespace PSMS.Repository
{
    public class DropdownRepository : DataRepository
    {
        //private const string connectionString = @"Data Source=SHANI-11\SQLEXPRESS;Initial Catalog=LoanManagementSystem;Integrated Security=True;";
        private string connectionString = ConfigurationManager.ConnectionStrings["PSMS_ConnectionString"].ConnectionString;

        //public DataTable GetDropdown(string sql, bool isStoreProcedure = false)
        //{
        //    using (SqlConnection connection = OpenConnection(connectionString))
        //    {
        //        try
        //        {
        //            SqlCommand cmd = new SqlCommand(sql, connection);
        //            //cmd.CommandType = CommandType.StoredProcedure;
        //            //cmd.Parameters.AddWithValue("@param1", 1);
        //            //cmd.Parameters.AddWithValue("@param2", 2);

        //            SqlDataAdapter da = new SqlDataAdapter(cmd);
        //            DataSet ds = new DataSet();
        //            da.Fill(ds, "DropdownDataset");
        //            return ds.Tables[0];
        //        }
        //        catch (Exception)
        //        {
        //            return null;
        //        }
        //    }
        //}

        public List<Dropdown> GetDropdown(string sql, DynamicParameters param = null, bool isQuery = false)
        {
            using (IDbConnection connection = OpenConnection(connectionString))
            {
                return connection.Query<Dropdown>(sql, param, commandType: isQuery ? CommandType.Text : CommandType.StoredProcedure).ToList();
            }
        }

        private SqlConnection OpenConnection(string connectionString)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}
