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
    public partial class EditP : Form
    {
        public EditP()
        {
            InitializeComponent();
        }
        string ps=Form_login.name;
        int bx = 0;
        string oldps = Form_login.pwd;
        void check()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                bx++;
                MessageBox.Show("信息不能为空！", "提示");
                return;
                
            }
            else if (textBox3.Text != textBox2.Text)
            {
                bx++;
                MessageBox.Show("两次密码不相同", "提示");
                return;
            }
            else if (oldps.Trim()!=textBox1.Text)
            {
                bx++;
                //MessageBox.Show(oldps);
               
                MessageBox.Show("密码错误", "提示");
                return;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            check();
            if (bx == 0)
            {
                string sql = "update src set password='" + textBox2.Text.Trim() + "' where id='" + ps + "'";
                DBOperation.exesql(sql);
                MessageBox.Show("修改成功！", "提示");
                this.Close();
                
            }
        }

        private void EditP_Load(object sender, EventArgs e)
        {
            label5.Text = Form_login.name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
