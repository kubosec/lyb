using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Financial
{
    /// <summary>
    /// ϵͳ�û�����
    /// </summary>
    public class User
    {

        private string userName = string.Empty;
        private string passWord = string.Empty;
        private bool isAdministrator = false;
        private AccountManager accountManager = new AccountManager();
        private string dirOfDateFile = string.Empty;
        private string dirOfDateFile_Relative = string.Empty;
        private string pathOfDateFile_Account = string.Empty;
        private string pathOfDateFile_Account_Relative = string.Empty;


        public User()
        {
        }

        public User(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
        }


        /// <summary>
        /// ��ȡ�û������ļ�����Ŀ¼�ľ���·��
        /// </summary>
        public string DirOfDataFile
        {
            get
            {
                if (!String.IsNullOrEmpty(this.dirOfDateFile))
                {
                    return this.dirOfDateFile;
                }
                string path = Application.StartupPath + this.DirOfDataFile_Relative;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                return path;
            }
            set
            {
                this.dirOfDateFile = value;
            }
        }

        /// <summary>
        /// ��ȡ�û������ļ�����Ŀ¼�����·��
        /// </summary>
        public string DirOfDataFile_Relative
        {
            get
            {
                return UserManager.DirOfUserListFile_Relative + "\\" + userName;
            }
            set
            {
                this.dirOfDateFile_Relative = value;
            }
        }

        /// <summary>
        /// ��ȡ�ʻ����������ļ��ľ���·��
        /// </summary>
        public string PathOfDataFile_Account
        {
            get
            {
                if(!string.IsNullOrEmpty(this.pathOfDateFile_Account))
                {
                    return this.pathOfDateFile_Account;
                }
                string path = Application.StartupPath + this.PathOfDataFile_Account_Relative;
                if (!File.Exists(path))
                {
                    FileStream fs = null;
                    try
                    {
                        fs = File.Create(path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally
                    {
                        fs.Close();
                    }
                }

                return path;
            }
            set
            {
                this.pathOfDateFile_Account = value;
            }
        }
        

        /// <summary>
        /// ��ȡ�ʻ����������ļ������·��
        /// </summary>
        public string PathOfDataFile_Account_Relative
        {
            get
            {
                if (!string.IsNullOrEmpty(this.pathOfDateFile_Account_Relative))
                {
                    return this.pathOfDateFile_Account_Relative;
                }

                return this.DirOfDataFile_Relative + "\\account.xml";
            }
            set
            {
                this.pathOfDateFile_Account_Relative = value;
            }
        }

        /// <summary>
        /// ��ȡ�������û���
        /// </summary>
        public string UserName
        {
            get
            {
                return this.userName;
            }
            set
            {
                this.userName = value;
            }
        }


        /// <summary>
        /// ��ȡ����������
        /// </summary>
        public string PassWord
        {
            get
            {
                return this.passWord;
            }
            set
            {
                this.passWord = value;
            }
        }

        /// <summary>
        /// ��ȡ������һ��ֵ����ָʾ���û��Ƿ�Ϊϵͳ����Ա
        /// </summary>
        public bool IsAdministrator
        {
            get
            {
                return this.isAdministrator;
            }
            set
            {
                this.isAdministrator = value;
            }
        }

        /// <summary>
        /// ��ȡ��AccountManager����
        /// </summary>
        public AccountManager AccountMagr
        {
            get
            {
                return this.accountManager;
            }
        }
    }
}
