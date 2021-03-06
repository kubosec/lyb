using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Financial
{
    /// <summary>
    /// 注册新用户的窗体
    /// </summary>
    public partial class FormRegistNewUser : Form
    {
        public FormRegistNewUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.textBox_UserName.Text.Trim().Length == 0)
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "用户名不能为空";
                return;
            }

            if (!this.textBox_Psw.Text.Equals(this.textBox_Psw2.Text))
            {
                this.label_Info.ForeColor = Color.Red;
                this.textBox_Psw.Clear();
                this.textBox_Psw2.Clear();
                this.label_Info.Text = "您两次输入的密码不一致";
                return;
            }

            foreach (User u in UserManager.UserList)
            {
                if (u.UserName.Equals(this.textBox_UserName.Text.Trim()))
                {
                    this.label_Info.ForeColor = Color.Red;
                    this.label_Info.Text = "该用户名已经被其他用户使用,请使用其他用户名";
                    return;
                }

            }


            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}