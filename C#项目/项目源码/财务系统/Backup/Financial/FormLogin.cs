using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Financial
{
    /// <summary>
    /// ��½����
    /// </summary>
    public partial class FormLogin : Form
    {
        Bitmap bmpText;

        public FormLogin()
        {
            InitializeComponent();

            using (Font fnt = new Font("Arial", 25, FontStyle.Bold))
            {
                this.bmpText = (Bitmap)FancyText.ImageFromText("���˲������ϵͳ", fnt, Color.Green, Color.Goldenrod);
            }

            this.pictureBox_Title.Image = this.bmpText;
        }

        private void button_Tips_MouseDown(object sender, MouseEventArgs e)
        {
            string info = "û�п��õ���ʾ��Ϣ";
            this.label_Info.ForeColor = Color.Red;
            this.label_Info.Text = info;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// ��½
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Log_Click(object sender, EventArgs e)
        {
            User user = new User(this.comboBox_UserName.Text, this.textBox_Psw.Text);
            bool ok = false;

            foreach (User u in UserManager.UserList)
            {
                if (u.UserName.Equals(user.UserName) && u.PassWord.Equals(user.PassWord))
                {
                    ok = true;
                    break;
                }
            }

            if (ok)
            {
                FormMain formMain = new FormMain();
                formMain.currentUser = user;
                user.AccountMagr.LoadDataFromFile(Application.StartupPath + user.PathOfDataFile_Account_Relative);
                this.Hide();
                formMain.Show();
            }
            else
            {
                this.label_Info.ForeColor = Color.Red;
                this.label_Info.Text = "�û������������";
                this.textBox_Psw.Clear();

            }
        }

        /// <summary>
        /// ��ʼ��,�����û��б�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            if (UserManager.LoadUserListFromFile())
            {

                foreach (User u in UserManager.UserList)
                {
                    this.comboBox_UserName.Items.Add(u.UserName);
                }
            }
            else
            {
                //MessageBox.Show("�����û��б����");
            }

            this.timer1.Start();
        }

        /// <summary>
        /// ע�����û�
        /// </summary>
        private void linkLabel_Regist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistNewUser form = new FormRegistNewUser();

            if (form.ShowDialog() == DialogResult.OK)
            {
                string userName = form.textBox_UserName.Text;
                string psw = form.textBox_Psw.Text;

                User newUser = new User(userName, psw);
                UserManager.UserList.Add(newUser);
                UserManager.SaveUserListToFile();

                this.comboBox_UserName.Items.Add(newUser.UserName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Color clr1 = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            Color clr2 = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            using (Font fnt = new Font("Arial", 25, FontStyle.Bold))
            {
                this.bmpText = (Bitmap)FancyText.ImageFromText("���˲������ϵͳ", fnt, clr1, clr2);
            }

            this.pictureBox_Title.Image = this.bmpText;
        }
    }
}