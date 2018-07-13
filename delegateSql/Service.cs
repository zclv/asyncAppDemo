using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegateSql
{
    public class Service
    {
        public T Execute<T>(Func<SqlCommand, T> func, string connectionString)
        {
            SqlTransaction tran = null;
            try
            {
                T t = default(T);
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    tran = conn.BeginTransaction();
                    {
                        SqlCommand cmd = new SqlCommand();
                          t = func.Invoke(cmd);
                    }
                    tran.Commit();
                    return t;
                }
            }
            catch (Exception)
            {
                tran.Rollback();
                throw;
            }
        }
    }
}
