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
    public partial class AddBorrowIn : Form
    {
        public AddBorrowIn()
        {
            InitializeComponent();
        }
        string xb = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into incomein(借入金额,借入时间,借款人,还款日期,还款人,是否回收,说明) values('" + textBox1.Text + "','" + dateTimePicker1.Value + "','" + textBox2.Text + "','" + dateTimePicker1.Value + "','" + textBox3.Text + "','" + xb + "','" + textBox4.Text + "')";
            DBOperation.exesql(sql);
            MessageBox.Show("添加成功！", "提示");
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
            textBox1.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
