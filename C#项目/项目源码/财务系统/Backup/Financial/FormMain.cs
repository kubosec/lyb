using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Financial
{
    /// <summary>
    /// ϵͳ������
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// ��ȡ������ϵͳ�ĵ�ǰ�û�
        /// </summary>
        public User currentUser = null;

        private FormAccountManage formAccout = null;

        public FormMain()
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormMain_Closing);
        }

        /// <summary>
        /// �ر�������ǰ�Ĵ���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormMain_Closing(object sender, CancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("ȷ���˳�ϵͳ��?", "�˳�", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                //
                //�������봦��������񣬱��籣���
                //
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// ��ʼ��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                this.toolStripStatusLabel_UserName.Text = currentUser.UserName;
                FormManageItem fmi = new FormManageItem();
                fmi.MdiParent = this;
                fmi.Show();

                
            }
        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_IncomeManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n       ��Դ�汾�����ṩ�ù���\n     ");
            return;

            /*

            FormFinancialManage form = new FormFinancialManage();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
             */
        }

        /// <summary>
        /// �ʻ�����
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_AccoutManage_Click(object sender, EventArgs e)
        {
            if (this.currentUser == null)
            {
                return;
            }

            if (this.formAccout == null)
            {
                this.formAccout = new FormAccountManage(this.currentUser);
                this.formAccout.MdiParent = this;
            }

            this.formAccout.Show();
            this.formAccout.BringToFront();
            this.formAccout.WindowState = FormWindowState.Maximized;

        }

        /// <summary>
        /// �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItem_DebitManage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n       ��Դ�汾�����ṩ�ù���\n     ");
            return;
            /*
            FormDebitManage form = new FormDebitManage();
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
             */
        }

        private void ToolStripMenuItem_NomalCal_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + Path.DirectorySeparatorChar + "Cal" + Path.DirectorySeparatorChar + "WinCal.exe");
        }

        private void ToolStripMenuItem_ProfressionalCal_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + Path.DirectorySeparatorChar + "Cal" + Path.DirectorySeparatorChar + "MyCal.exe");

        }

        private void ToolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItem_DataInput_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_DataOutput_Click(object sender, EventArgs e)
        {

        }


        //�����޸�
        private void ToolStripMenuItem_PasswordModify_Click(object sender, EventArgs e)
        {
            if (this.currentUser != null)
            {
                FormPswModify fpm = new FormPswModify(this.currentUser.UserName, this.currentUser.PassWord);
                if (fpm.ShowDialog() == DialogResult.OK)
                {
                    string newPsw = fpm.newPsw;
                    this.currentUser.PassWord = newPsw;

                    for (int i = 0; i < UserManager.UserList.Count; i++)
                    {
                        if(UserManager.UserList[i].UserName.Equals(this.currentUser.UserName))
                        {
                            UserManager.UserList[i].PassWord = newPsw;
                            break;
                        }
                    }


                    if (UserManager.SaveUserListToFile())
                    {
                        MessageBox.Show("\n                �����޸ĳɹ�             \n");
                    }

                }

            }
        }

        private void toolStripMenuItem_Windows_DropDownOpening(object sender, EventArgs e)
        {
            this.toolStripMenuItem_Windows.DropDownItems.Clear();

            int i=-1;
            foreach(Form frm in this.MdiChildren)
            {
                i++;
                this.toolStripMenuItem_Windows.DropDownItems.Add(frm.Text);
                this.toolStripMenuItem_Windows.DropDownItems[i].Click += new EventHandler(FormMain_Click);
                if (this.ActiveMdiChild.Text.Equals(frm.Text))
                {
                    (this.toolStripMenuItem_Windows.DropDownItems[i] as ToolStripMenuItem).Checked = true;
                }
            }
        }

        void FormMain_Click(object sender, EventArgs e)
        {
            ToolStripItem ti = sender as ToolStripItem;
            if (ti != null)
            {
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm.Text.Equals(ti.Text))
                    {
                        frm.Focus();
                    }
                }
            }
        }

        private void ToolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            AboutBox_AboutUs ab = new AboutBox_AboutUs();
            ab.ShowDialog();
        }

    }
}