using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Financial
{
    /// <summary>
    /// 系统用户类型
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
        /// 获取用户数据文件所在目录的绝对路径
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
        /// 获取用户数据文件所在目录的相对路径
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
        /// 获取帐户管理数据文件的绝对路径
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
        /// 获取帐户管理数据文件的相对路径
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
        /// 获取或设置用户名
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
        /// 获取或设置密码
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
        /// 获取或设置一个值，其指示该用户是否为系统管理员
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
        /// 获取其AccountManager对象
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
