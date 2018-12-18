using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Borrow : Form
    {
        public Borrow()
        {
            InitializeComponent();
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "请选择";
            //string sql = "select * from income";
            //string sql1 = "select * from incomein";
            //DBOperation.BindDB(dataGridView1, sql);
            //DBOperation.GetDataTable(sql);
        }

        private void 添加借出信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBorrow f1 = new AddBorrow();
            f1.Show();
        }

        private void 添加借入信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBorrowIn f2 = new AddBorrowIn();
            f2.Show();
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string sql = "select * from income";
            //DBOperation.BindDB(dataGridView1, sql);
           // DBOperation.GetDataTable(sql);
            //dataGridView1.Column
            //dataGridView1.RowHeadersVisible = false; 
            this.Close();
            
        }

        private void 关闭ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string xb = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (xb.Equals("借出信息"))
            {
                sql = "select * from income";

            }
            else
            {
                sql = "select * from incomein";
            }
            DBOperation.BindDB(dataGridView1, sql);
            DBOperation.GetDataTable(sql);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            xb = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            xb = radioButton2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (xb.Equals("借出信息"))
            {

                if (comboBox1.Text.Equals("按金额"))
                {
                    string sql = "select * from income where 借出金额='" + textBox1.Text + "'";

                    DBOperation.BindDB(dataGridView1, sql);
                    DBOperation.GetDataTable(sql);
                }
                else
                {
                    string sql = "select * from income where 是否回收='" + textBox1.Text + "'";

                    DBOperation.BindDB(dataGridView1, sql);
                    DBOperation.GetDataTable(sql);
                }

            }
            else
            {
                if (comboBox1.Text.Equals("按金额"))
                {
                    string sql = "select * from incomein where 借入金额='" + textBox1.Text + "'";

                    DBOperation.BindDB(dataGridView1, sql);
                    DBOperation.GetDataTable(sql);
                }
                else
                {
                    string sql = "select * from incomein where 是否回收='" + textBox1.Text + "'";

                    DBOperation.BindDB(dataGridView1, sql);
                    DBOperation.GetDataTable(sql);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (xb.Equals("借出信息"))
            {
                string sql = "select * from income";
                DBOperation.BindDB(dataGridView1, sql);
                DBOperation.GetDataTable(sql);
            }
            else
            {
                string sql = "select * from incomein";
                DBOperation.BindDB(dataGridView1, sql);
                DBOperation.GetDataTable(sql);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (xb.Equals("借出信息"))
            {
                DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (row["序号"] == null) return;//可以进行快速监视
                string bd = Convert.ToString(row["序号"]);
                string str = "delete from income where 序号 = " + bd + "";
                DBOperation.exesql(str);
                MessageBox.Show("删除成功！", "提示");
            }
            else
            {
                DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
                if (row["序号"] == null) return;//可以进行快速监视
                string bd = Convert.ToString(row["序号"]);
                string str = "delete from incomein where 序号 = " + bd + "";
                DBOperation.exesql(str);
                MessageBox.Show("删除成功！", "提示");
            }
        }
    }
}
