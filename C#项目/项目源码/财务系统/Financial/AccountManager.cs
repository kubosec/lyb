using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;


namespace Financial
{
    /// <summary>
    /// 帐户管理器类型
    /// </summary>
    public class AccountManager
    {
        private AccountCollection accountList = new AccountCollection();

        /// <summary>
        /// 获取或设置帐户列表
        /// </summary>
        public AccountCollection AccoutList
        {
            get
            {
                return this.accountList;
            }
            set
            {
                this.accountList = value;
            }
        }

        /// <summary>
        /// 将帐户管理数据保存到文件
        /// </summary>
        /// <param name="pathOfDataFile">数据文件路径</param>
        public bool SaveDataToFile(string pathOfDataFile)
        {
            StreamWriter sw = new StreamWriter(pathOfDataFile,false,Encoding.Default);
            XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));
            try
            {
                xml.Serialize(sw, this.accountList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }

            return true;
        }

        /// <summary>
        /// 重文件读取帐户信息
        /// </summary>
        /// <param name="pathOfDataFile">数据文件路径</param>
        public bool LoadDataFromFile(string pathOfDataFile)
        {
            StreamReader sr = new StreamReader(pathOfDataFile,Encoding.Default);
            XmlSerializer xml = new XmlSerializer(typeof(AccountCollection));
            try
            {
                this.accountList = (AccountCollection)xml.Deserialize(sr);
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return true;
        }


    }
}
