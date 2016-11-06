using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PersonnelManage 
{
    class sqlHelper
    {
        //.ConnectionString
        public readonly string connectionStr = ConfigurationManager.ConnectionStrings["hrDBStr"].ConnectionString.Trim();
        //ExecuteDataSet
        public DataSet ExecuteDataSet(string conStr,string strSql,string tableName)
        {
            using(SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand comm=preCommand(strSql,conn);
                DataSet ds=new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                if(tableName!=null)
                {
                    adapter.Fill(ds,tableName);
                }else
                {
                    adapter.Fill(ds);
                }
                return ds;
            }
        }

        //ExecuteReader
        public SqlDataReader ExecuteRead(string conStr,string strSql)
        {
            SqlConnection conn = new SqlConnection(conStr);
            SqlCommand comm = preCommand(strSql, conn);
            SqlDataReader dr = comm.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
        //ExecuteScalar
        public object ExecuteScalar(string conStr,string strSql)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand comm = preCommand(strSql, conn);
                return comm.ExecuteScalar();
            }
        }
        //ExecuteNonQurey
        public int ExecuteNonQuery(string conStr,string strSql)
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlCommand comm = preCommand(strSql, conn);
                return comm.ExecuteNonQuery();
            }
        }


        //创建执行者，并判断数据库连接状态，再连接数据库
        private static SqlCommand preCommand(string strSql, SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else if(conn.State==ConnectionState.Broken)
            {
                conn.Close(); conn.Open();
            }
            SqlCommand comm = new SqlCommand(strSql, conn);
            return comm;
        }

        
    }
}
