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
        public T GetTBySql<T>(T t, string str)
        {
            Type type = typeof(T);
            string column = string.Join(",", type.GetProperties().Select(p => string.Format($"[{p.Name}]")));
            string sql = $"SELECT {column} FROM {typeof(T).Name} {str}";
            T oT = (T)Activator.CreateInstance(type);
            using (SqlConnection conn = new SqlConnection())
            {
                conn.Open();
                SqlDataReader reader = null;
                while (reader.Read())
                {
                    foreach (var item in typeof(T).GetProperties())
                    {
                        item.SetValue(oT, reader[item.Name] == DBNull.Value ? null : reader[item.Name]);
                    }
                }
            }
            return oT;
        }
    }
}
