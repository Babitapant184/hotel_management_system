using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_M
{
    internal class function
    {
        internal SqlConnection connection;

        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=VIKI-GALAXY\\SQLEXPRESS04;database=MyHotel;integrated security=True";
            return conn;
        }


        public DataSet getData(String query, string v)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.Connection = conn;

            SqlDataAdapter da = new SqlDataAdapter(cmd); // Associate the SqlCommand with the SqlDataAdapter
            DataSet ds = new DataSet();

            try
            {
                conn.Open(); // Open the connection
                da.Fill(ds); // Fill the DataSet
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Ensure the connection is closed
            }

            return ds;
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection conn=getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection=conn;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            SqlDataReader sdr= cmd.ExecuteReader();
            return sdr;
                
                }

       
    }

}

