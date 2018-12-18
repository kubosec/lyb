using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;// Directory

namespace WindowsFormsApplication3
{
    class DBOperation
    {
        static String currentdir = Directory.GetCurrentDirectory();
        //static String constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + currentdir + @"\susheguanli_data.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //static String constr = @"Data Source=.\SQLEXPRES;AttachDbFilename="+currentdir+@"\Data\iBaby_Data.MDF;Integrated Security=True;Connect Timeout=30;User Instance=True";
        //绑定DataGridView
        //static string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=Student;integrated Security=True";
        static string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
        public static void BindDB(DataGridView dg,string strSql)
        {
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter(strSql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dg.DataSource = ds.Tables[0];

        }
        //  获取数据表
        public static DataTable  GetDataTable( string strSql)
        {
            DataTable dt ;
            SqlConnection con = new SqlConnection(constr);
            SqlDataAdapter sda = new SqlDataAdapter(strSql, con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "DataTab");
            dt = ds.Tables["DataTab"];
            return dt;
        }
       ///添加 删除 修改
        public static void exesql(String strsql)  
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();///建立连接
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = strsql;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //根据select查询sql，返回datareader
        public static SqlDataReader getReader(string sql)
       {
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
            
       }
        
        
    }
}
