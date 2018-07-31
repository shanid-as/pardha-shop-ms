using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSMS.Repository
{
    public class DataRepository
    {
        //private const string connectionString = @"Data Source=SHANI-11\SQLEXPRESS;Initial Catalog=LoanManagementSystem;Integrated Security=True;";
        //private string connectionString = System.Configuration.ConfigurationSettings.AppSettings.Get("LMS_ConnectionString");
        private string connectionString = ConfigurationManager.ConnectionStrings["PSMS_ConnectionString"].ConnectionString;
        public T Add<T>(string storedProcedure, DynamicParameters param)
        {
            using (IDbConnection connection = OpenConnection(connectionString))
            {
                return connection.Query<T>(storedProcedure, param, commandType:CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public IEnumerable<T> GetAll<T>(string storedProcedure, DynamicParameters param)
        {
            using (IDbConnection connection = OpenConnection(connectionString))
            {
                return connection.Query<T>(storedProcedure, param, commandType: CommandType.StoredProcedure);
            }
        }

        private IDbConnection OpenConnection(string connectionString)
        {
            IDbConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        //SQL DB insertion, updation and deletion
        public bool nonReturn(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
                catch
                {
                    if (con.State != ConnectionState.Closed) con.Close();
                    return false;
                }
            }
        }

        //SQL DB selection
        public DataSet Get(SqlCommand cmd)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand = cmd;
                    sda.Fill(ds);
                    return (ds);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
