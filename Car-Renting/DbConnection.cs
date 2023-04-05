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
        //private static string connectionString = Properties.Settings.Default.connStr ;
        private static string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QLThueXe;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(connectionString);


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

        public int executeInsertQuery(string query, Dictionary<string, object> parameters = null)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, conn);

                if (parameters != null && parameters.Count > 0)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                conn.Open();
                object insertedId = command.ExecuteScalar();
                if (insertedId != null)
                {
                    result = Convert.ToInt32(insertedId);
                }
                conn.Close();
            }

            return result;
        }

        public int executeUpdateQuery(string sqlStr, Dictionary<string, object> parameters)
        {
            int result = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlStr, conn))
                {
                    foreach (KeyValuePair<string, object> param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    result = cmd.ExecuteNonQuery();
                }

                conn.Close();
            }

            return result;
        }

        //Mot so ham tham khao 

        //public DataTable GetData(string query, List<SqlParameter> parameters = null)
        //{
        //    DataTable dt = new DataTable();
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            if (parameters != null)
        //            {
        //                command.Parameters.AddRange(parameters.ToArray());
        //            }

        //            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //            {
        //                adapter.Fill(dt);
        //            }
        //        }
        //    }

        //    return dt;
        //}



    }


}
