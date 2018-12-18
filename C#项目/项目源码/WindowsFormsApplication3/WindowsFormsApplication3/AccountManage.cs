using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{

    public partial class AccountManage : Form
    {
        public AccountManage()
        {
            InitializeComponent();
        }
        //static string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";

        private void AccountManage_Load(object sender, EventArgs e)
        {
            string sql = "select * from addaccount";
           DBOperation.BindDB(dataGridView1, sql);
           DBOperation.GetDataTable(sql);
           comboBox1.Text = "请选择";
        }

        

       

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from cain";
            DBOperation.BindDB(dataGridView1, sql);
            DBOperation.GetDataTable(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from addaccount where 操作='" +comboBox1.Text+ "'";
            DBOperation.BindDB(dataGridView1, sql);
            DBOperation.GetDataTable(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select * from addaccount where 账号='" + textBox1.Text + "'";
            DBOperation.BindDB(dataGridView1, sql);
            DBOperation.GetDataTable(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "select * from addaccount";
            DBOperation.BindDB(dataGridView1, sql);
            DBOperation.GetDataTable(sql);
        }

        private void AccountManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            DialogResult dr = MessageBox.Show("确定退出系统吗?", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                //
                //在这里请处理相关事务，比如保存等
                //
                //Application.Exit();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
             * */
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 添加账户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccount f1 = new AddAccount();
            f1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           //string sql="delete * from addaccount where 序号='"++"'
            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row["序号"] == null) return;//可以进行快速监视
            string bd = Convert.ToString(row["序号"]);
            string str = "delete from addaccount where 序号 = " + bd + "";
            DBOperation.exesql(str);
            MessageBox.Show("删除成功！","提示");
        }
        public static string a5="";
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row["序号"] == null) return;//可以进行快速监视
            string bd = Convert.ToString(row["序号"]);
            string str = "select * from addaccount where 序号 = " + bd + "";

            string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);//创建数据库连接
            conn.Open();//打开连接
            //SqlDataAdapter sda = new SqlDataAdapter();//SqlDataAdapter是数据适配器，是数据库和调用者之间的桥梁
            SqlCommand cmd = new SqlCommand();  //SqlCommand表示对数据库要执行的操作命令。
            cmd.CommandText = str;//cmd要执行的sql操作语句
            cmd.Connection = conn;//cmd对应的连接
            SqlDataReader reader = cmd.ExecuteReader();
           // string i;
            //Image re;
            string a1="";
            string a2="";
            string a3="";
            string a4="";
            //string a5="";
            //string a5;
            
            //byte[] imagebytes = null;
            while (reader.Read())
            {
                // imagebytes = (byte[])reader["images"];
                //re = reader["images"];
                a1 = reader["户主"].ToString().Trim();
             //MessageBox.Show(a1);
                a2 = reader["账号"].ToString().Trim();
                a3 = reader["操作前金额"].ToString().Trim();
                //a1 = reader["操作"].ToString();
                a4 = reader["余额"].ToString().Trim();
                a5 = reader["序号"].ToString().Trim();
                

                EditAccount f2 = new EditAccount();
                //AccountManage f3 = new AccountManage();
                f2.textBoxa = a1;
                f2.textBoxb = a2;
                f2.textBoxc = a3;
                f2.textBoxd = a4;

                f2.Show();
            }
           
        }

        private void 添加借出信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddBorrowIn f2 = new AddBorrowIn();
            //f2.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            AddAccount f1 = new AddAccount();
            f1.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddAccount f1 = new AddAccount();
            f1.Show();
        }
    }
}
