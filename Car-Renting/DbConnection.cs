using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Renting
{
    class DbConnection
    {
        private static DbConnection instance;
        private static SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);

        public static DbConnection Instance {
            get { 
                if(instance == null)
                    instance = new DbConnection();
                return DbConnection.instance;
            }
            private set { DbConnection.instance = value; }
        }
        //Design Partern Singleton  
        private DbConnection() { }

        public  DataTable getData(string sqlStr)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dt);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public  int ExecuteNonQuery(string sqlStr)
        {
            //ExecuteNoneQuery just count the number of insert , update , del query not Select
            int NumberofSuccess = 5;
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                NumberofSuccess = cmd.ExecuteNonQuery();
                if (NumberofSuccess > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("that bai" + ex);
            }
            finally
            {
                conn.Close();
            }
            return NumberofSuccess;
        }


    }
}
