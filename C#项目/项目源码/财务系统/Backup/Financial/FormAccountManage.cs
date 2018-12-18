using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;
using System.Xml;
using System.Xml.Serialization;

namespace Financial
{
    /// <summary>
    /// 帐户管理窗口
    /// </summary>
    public partial class FormAccountManage : Form
    {
        private AccountManager accountManager = new AccountManager();
        private User user = null;

        public FormAccountManage(User user)
        {
            InitializeComponent();
            this.Closing += new CancelEventHandler(FormAccountManage_Closing);
            this.user = user;
        }

        /// <summary>
        /// 加载窗体时进行帐户初始化
        /// </summary>
        private void FormAccountManage_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();

            if (this.user != null)
            {

                foreach (Account acc in this.user.AccountMagr.AccoutList)
                {
                    this.accountManager.AccoutList.Add(acc);

                    string[] items = new string[]{
                (this.listView1.Items.Count+1).ToString(),
                acc.OwnerName.ToString(),
                acc.BankbookNum.ToString(),
                acc.CardNum.ToString(),
                acc.StartDate.ToString(),
                acc.BankName.ToString(),
                acc.MoneyType.ToString(),
                acc.AccountType.ToString(),
                acc.IniBlance.ToString(),
                acc.RemainBlance.ToString(),
                acc.Remark.ToString()};

                    ListViewItem lvi = new ListViewItem(items);
                    this.listView1.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// 保存列表中的内容
        /// </summary>
        private void SaveListViewToFile()
        {

            AccountCollection accCollect = new AccountCollection();

            foreach (ListViewItem item in this.listView1.Items)
            {
                Account acc = new Account();
                acc.OwnerName = item.SubItems[1].Text;
                acc.BankbookNum = item.SubItems[2].Text;
                acc.CardNum = item.SubItems[3].Text;
                acc.StartDate = DateTime.Parse(item.SubItems[4].Text);
                acc.BankName = item.SubItems[5].Text;
                acc.MoneyType = item.SubItems[6].Text;
                acc.AccountType = item.SubItems[7].Text;
                acc.IniBlance = double.Parse(item.SubItems[8].Text);
                acc.RemainBlance = double.Parse(item.SubItems[9].Text);
                acc.Remark = item.SubItems[10].Text;

                accCollect.Add(acc);
            }

            this.user.AccountMagr.AccoutList = accCollect;
            this.user.AccountMagr.SaveDataToFile(this.user.PathOfDataFile_Account);
        }


        /// <summary>
        /// 打印文件
        /// </summary>
        /// <param name="pathOfPrintFile">要打印的文件的路径</param>
        private void Print(string pathOfPrintFile)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = pathOfPrintFile;
            this.printDialog1.Document = printDoc;
            this.printDialog1.ShowDialog();
        }

        void FormAccountManage_Closing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// //添加帐户
        /// </summary>
        private void toolStripSplitButton_Add_Click(object sender, EventArgs e)
        {
            FormAddAccount faa = new FormAddAccount();
            Account acc = new Account();

            if (faa.ShowDialog(this) == DialogResult.OK)
            {
                acc.IniBlance = double.Parse(faa.textBox_IniBalance.Text);
                acc.MoneyType = faa.textBox_MoneyType.Text;
                acc.OwnerName = faa.textBox_UserName.Text;
                acc.RemainBlance = double.Parse(faa.textBox_RemainBalance.Text);
                acc.Remark = faa.textBox_Reamrk.Text;
                acc.StartDate = faa.dateTimePicker_StartDate.Value;
                acc.AccountType = faa.textBox_AccountType.Text;
                acc.BankbookNum = faa.textBox_BankbookNum.Text;
                acc.BankName = faa.textBox_BankName.Text;
                acc.CardNum = faa.textBox_cardNum.Text;


                this.accountManager.AccoutList.Add(acc);

                string[] items = new string[]{
                (this.listView1.Items.Count+1).ToString(),
                acc.OwnerName.ToString(),
                acc.BankbookNum.ToString(),
                acc.CardNum.ToString(),
                acc.StartDate.ToString(),
                acc.BankName.ToString(),
                acc.MoneyType.ToString(),
                acc.AccountType.ToString(),
                acc.IniBlance.ToString(),
                acc.RemainBlance.ToString(),
                acc.Remark.ToString()};
                ListViewItem lvi = new ListViewItem(items);
                this.listView1.Items.Add(lvi);

                this.SaveListViewToFile();
            }

            
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            ListViewItem lviSelected = this.listView1.GetItemAt(e.X, e.Y);
            if (lviSelected != null)
            {
                if (e.Button == MouseButtons.Left && e.Clicks > 1)
                {
                    this.toolStripButton_Modify.PerformClick();
                }

                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip_ListViewItemRightClick.Show(this.listView1, e.Location);
                }

            }
            else
            {
                if (e.Button == MouseButtons.Right)
                {
                    this.contextMenuStrip_ListViewRightClick.Show(this.listView1, e.Location);
                }
            }
        }

        
        /// <summary>
        /// 保存
        /// </summary>
        private void toolStripButton_Save_Click(object sender, EventArgs e)
        {
            this.SaveListViewToFile();            
        }

        /// <summary>
        /// 删除
        /// </summary>
        private void toolStripButton_Del_Click(object sender, EventArgs e)
        {
            string names = string.Empty;
            foreach (ListViewItem item in this.listView1.SelectedItems)
            {
                names += item.SubItems[1].Text + "\n";
            }
            if (!String.IsNullOrEmpty(names))
            {
                DialogResult dr = MessageBox.Show("确实要删除\n" + names + "的帐户信息吗?", "删除帐户", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < this.listView1.SelectedItems.Count; i++)
                    {
                        this.listView1.Items.Remove(this.listView1.SelectedItems[i]);
                        i--;
                    }
                    this.SaveListViewToFile();
                }
            }
        }

        

        /// <summary>
        ///修改帐户信息
        /// </summary>
        private void toolStripButton_Modify_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
            {
                return;
            }


            FormAddAccount faa = new FormAddAccount();
            Account acc = new Account();
            ListViewItem item = this.listView1.SelectedItems[0];

            faa.textBox_UserName.Text = item.SubItems[1].Text;
            faa.textBox_BankbookNum.Text = item.SubItems[2].Text;
            faa.textBox_cardNum.Text = item.SubItems[3].Text;
            faa.dateTimePicker_StartDate.Text = item.SubItems[4].Text;
            faa.textBox_BankName.Text = item.SubItems[5].Text;
            faa.textBox_MoneyType.Text = item.SubItems[6].Text;
            faa.textBox_AccountType.Text = item.SubItems[7].Text;
            faa.textBox_IniBalance.Text = item.SubItems[8].Text;
            faa.textBox_RemainBalance.Text = item.SubItems[9].Text;
            faa.textBox_Reamrk.Text = item.SubItems[10].Text;

            if (faa.ShowDialog() == DialogResult.OK)
            {
                acc.IniBlance = double.Parse(faa.textBox_IniBalance.Text);
                acc.MoneyType = faa.textBox_MoneyType.Text;
                acc.OwnerName = faa.textBox_UserName.Text;
                acc.RemainBlance = double.Parse(faa.textBox_RemainBalance.Text);
                acc.Remark = faa.textBox_Reamrk.Text;
                acc.StartDate = faa.dateTimePicker_StartDate.Value;
                acc.AccountType = faa.textBox_AccountType.Text;
                acc.BankbookNum = faa.textBox_BankbookNum.Text;
                acc.BankName = faa.textBox_BankName.Text;
                acc.CardNum = faa.textBox_cardNum.Text;


                this.accountManager.AccoutList.Add(acc);

                string[] its = new string[]{
                (this.listView1.SelectedIndices[0]+1).ToString(),
                acc.OwnerName.ToString(),
                acc.BankbookNum.ToString(),
                acc.CardNum.ToString(),
                acc.StartDate.ToString(),
                acc.BankName.ToString(),
                acc.MoneyType.ToString(),
                acc.AccountType.ToString(),
                acc.IniBlance.ToString(),
                acc.RemainBlance.ToString(),
                acc.Remark.ToString()};
                ListViewItem lvi = new ListViewItem(its);

                this.listView1.Items[this.listView1.SelectedIndices[0]] = lvi;

                this.SaveListViewToFile();
            }
        }

        /// <summary>
        ///打印
        /// </summary>
        private void toolStripButton_Print_Click(object sender, EventArgs e)
        {
            string pathOfPrintFile = "";

            this.Print(pathOfPrintFile);

        }

        /// <summary>
        /// 导入
        /// </summary>
        private void toolStripButton_DataInput_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                StreamReader sr = new StreamReader(path, Encoding.Default);
                XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));
                AccountCollection accColl = null;
                try
                {
                    accColl = (AccountCollection)xml.Deserialize(sr);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("被损坏的数据文件或不合法的数据格式,无法导入!!\n:" + ex.Message);
                    return;
                }
                finally
                {
                    if(sr == null)
                    {
                        sr.Close();
                    }
                }

                File.Copy(path, this.user.PathOfDataFile_Account,true);

                if (accColl != null)
                {
                    this.user.AccountMagr.AccoutList = accColl;
                }
                this.FormAccountManage_Load(null, null);
            }
        }

        /// <summary>
        /// 导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton_DataOutput_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.saveFileDialog1.FileName;
                try
                {
                    File.Copy(this.user.PathOfDataFile_Account, path);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("转存时发生异常:\n" + ex.Message);
                }

            }

        }

        /// <summary>
        /// 退出
        /// </summary>
        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region       right click

        private void ToolStripMenuItem_AddNew_Click(object sender, EventArgs e)
        {
            this.toolStripSplitButton_Add.PerformClick();
        }

        private void ToolStripMenuItem_Statistic_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Statistic.PerformClick();
        }

        private void ToolStripMenuItem_Print_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Print.PerformClick();
        }

        private void ToolStripMenuItem_Import_Click(object sender, EventArgs e)
        {
            this.toolStripButton_DataInput.PerformClick();
        }

        private void ToolStripMenuItem_Output_Click(object sender, EventArgs e)
        {
            this.toolStripButton_DataOutput.PerformClick();
        }

        private void ToolStripMenuItem_Modify_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Modify.PerformClick();
        }

        private void ToolStripMenuItem_Del_Click(object sender, EventArgs e)
        {
            this.toolStripButton_Del.PerformClick();
        }

        #endregion

        private void textBox_Select_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.buttonSelect.PerformClick();
            }
        }

        //筛选
        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string pattern = this.textBox_Select.Text.Trim();

            if (string.IsNullOrEmpty(pattern))
            {
                return;
            }

            ListViewGroup groupSelected = new ListViewGroup("groupSelected", "筛选结果: " + pattern);
            ListViewGroup groupOther = new ListViewGroup("groupOther","其它");

            this.listView1.Groups.Clear();
            this.listView1.Groups.Add(groupSelected);
            this.listView1.Groups.Add(groupOther);

            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                ListViewItem lvi =(ListViewItem) this.listView1.Items[i];
                this.listView1.Items[i].Remove();
                string source = "";
                for (int j = 0; j < lvi.SubItems.Count; j++)
                {
                    source += lvi.SubItems[j].Text;
                }
                if (source.ToString().Contains(pattern))
                {
                    groupSelected.Items.Add(lvi);
                }
                else
                {
                    groupOther.Items.Add(lvi);
                }
                this.listView1.Items.Add(lvi);
            }

           
        }

        private void button_CancelSelect_Click(object sender, EventArgs e)
        {
            this.listView1.Groups.Clear();
        }

        //统计
        private void toolStripButton_Statistic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n       开源版本，不提供该功能\n     ");
            return;
        }

       
    }
}