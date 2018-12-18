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
    public partial class AddAccount : Form
    {
        public AddAccount()
        {
            InitializeComponent();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "insert into addaccount(户主,账号,开户日期,操作前金额,操作,操作时间,余额,是否使用) values('" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker2.Value + "','" + textBox4.Text + "','" + xb + "')";
            DBOperation.exesql(sql);
            MessageBox.Show("添加成功！", "提示");
        }
        string xb = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            xb = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            xb = radioButton2.Text;
        }

        private void AddAccount_Load(object sender, EventArgs e)
        {
            //xb = radioButton1.Text;
            comboBox3.Text = "请选择";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text="";
            textBox3.Text="";
            textBox2.Text="";
            textBox4.Text = ""; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
