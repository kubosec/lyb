using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Financial
{
    public partial class FormManageItem : Form
    {
        public FormManageItem()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormManageItem_Closing);
        }

        void FormManageItem_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void label_Account_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGreen;
            this.label_Info.Text = "进行你的个人银行帐户管理";
        }

        private void label_Account_MouseLeave(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = SystemColors.Control;
            this.label_Info.Text = "";
        }

        private void label_Income_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGreen;
            this.label_Info.Text = "进行你的个人收支管理";
        }

        private void label_Debit_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.LightGreen;
            this.label_Info.Text = "进行你的个人借贷业务管理";
        }

        private void label_Account_Click(object sender, EventArgs e)
        {
            FormMain fm = this.MdiParent as FormMain;
            if (fm != null)
            {
                fm.ToolStripMenuItem_AccoutManage.PerformClick();
            }
        }

        private void label_Income_Click(object sender, EventArgs e)
        {
            FormMain fm = this.MdiParent as FormMain;
            if (fm != null)
            {
                fm.ToolStripMenuItem_IncomeManage.PerformClick();
            }
        }

        private void label_Debit_Click(object sender, EventArgs e)
        {
            FormMain fm = this.MdiParent as FormMain;
            if (fm != null)
            {
                fm.ToolStripMenuItem_DebitManage.PerformClick();
            }
        }

        private void FormManageItem_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}