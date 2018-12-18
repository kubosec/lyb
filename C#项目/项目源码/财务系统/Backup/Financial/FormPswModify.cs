using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Financial
{
    public partial class FormPswModify : Form
    {

        private string userName;
        private string oldPsw;
        internal string newPsw;

        private FormPswModify()
        {
            InitializeComponent();
        }


        public FormPswModify(string userName, string psw)
        {
            InitializeComponent();


            this.userName = userName;
            this.oldPsw = psw;
            this.label_User.Text += "       "+ this.userName;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (!this.textBox_OldPsw.Text.Equals(this.oldPsw))
            {
                this.label_Info.Text = "旧口令错误!";
                return;
            }
            else 
            {
                if (!this.textBox_NewPsw.Text.Equals(this.textBox_NewPsw2.Text))
                {
                    this.label_Info.Text = "两次输入的新口令不一致!";
                    return;
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.newPsw = this.textBox_NewPsw2.Text;
                }
            }

        }
    }
}