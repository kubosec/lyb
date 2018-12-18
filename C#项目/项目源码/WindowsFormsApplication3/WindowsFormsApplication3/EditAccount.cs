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
    public partial class EditAccount : Form
    {
        public EditAccount()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            //户主='" + textBox1.Text + "',
            string sql = "update addaccount set 户主='" + textBox1.Text + "',账号='" + textBox3.Text + "',开户日期='" + dateTimePicker1.Value + "',操作前金额='" + textBox2.Text + "',操作='" + comboBox3.Text + "',操作时间='" + dateTimePicker2.Value + "',余额='" + textBox4.Text + "',是否使用='" + xb + "'where 序号 = '" + AccountManage.a5 + "'";
            DBOperation.exesql(sql);
            MessageBox.Show("修改成功！", "提示");
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            comboBox3.Text = "请选择";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string textBoxa
        {
            get{return textBox1.Text;}
            set { textBox1.Text = value; }
        }
        public string textBoxb
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string textBoxc
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string textBoxd
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
//login窗体中：
//mainfrm.menuEnable=false;
    }
}
