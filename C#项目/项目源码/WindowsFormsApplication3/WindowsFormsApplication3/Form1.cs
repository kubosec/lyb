using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;// Directory
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApplication3
{
      
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        public static string name = "";
        public static string pwd = "";
        private void btn_ok_Click(object sender, EventArgs e)
        {


            //string sql = "select * from li where username='" + textBox1.Text + "'";
            //DBOperation.getReader(sql);

           // DESKTOP-KDKK51O\SQLEXPRESS
            string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);//创建数据库连接
            conn.Open();//打开连接
            //SqlDataAdapter sda = new SqlDataAdapter();//SqlDataAdapter是数据适配器，是数据库和调用者之间的桥梁
            SqlCommand cmd = new SqlCommand();  //SqlCommand表示对数据库要执行的操作命令。
            cmd.CommandText = "select * from src where id='" + textBox1.Text + "'";//cmd要执行的sql操作语句
            cmd.Connection = conn;//cmd对应的连接
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string username = reader["id"].ToString();
                string password = reader["password"].ToString();
                name = username;
                pwd = password;
                //Trim()表示把字符串前后的空格都去除。不然有空格会干扰判断。
               
                if (this.textBox1.Text.Trim() == username.Trim() && password.Trim() == this.textBox2.Text.Trim())
                {
                    //Form1 f = new Form1();
                    //f.Show();   //弹出Form1这个窗体        
                    Form_Main f1 = new Form_Main();
                    this.Hide();
                    f1.Show();
                    
                }
                else
                {
                    MessageBox.Show("用户名或密码错误，请重新输入");
                    //this.textBox2.Text = "";
                }


                /*
                string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
                string sql = "select * from li where username='" + textBox1.Text + "'";
                bool flagshow = false;
               // string sql1 = "insert into li values('op','123')";
                //DBOperation.exesql(sql1);

            
             
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                string User = reader[0].ToString();
                MessageBox.Show(User);
               while (reader.Read())//从数据库读取用户信息  
                {  
                    //string User = reader["username"].ToString();  
                    string Pwd = reader["password"].ToString();  
                    if (User==textBox1.Text&Pwd==textBox2.Text)//不区分大小写，且是否存在该用户  
                    {  
                        flagshow = true;  
                    }  
                }  
                reader.Close();//查询关闭  
                con.Close();//连接关闭  
  
                if (flagshow == true)//判断该用户是否存在，存在进入下一界面  
                {  
                    AccountManage f1 = new AccountManage();  
                    //this.Hide();//隐藏当前登录界面  
                    f1.Show();//调用下一界面  
                }  
                else  
                {  
                    MessageBox.Show("用户不存在或输入错误！");  
                    return;  
                }  
                  */



            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定退出系统吗?", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.OK)
            {
                //
                //在这里请处理相关事务，比如保存等
                //
                //Application.Exit();
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Form_register f2 = new Form_register();
            //this.Visible = false;
            f2.Show();
        }
        /*
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            Color clr1 = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            Color clr2 = Color.FromArgb(rand.Next(255), rand.Next(255), rand.Next(255));
            using (Font fnt = new Font("Arial", 25, FontStyle.Bold))
            {
                this.bmpText = (Bitmap)FancyText.ImageFromText("个人财务管理系统", fnt, clr1, clr2);
            }

            this.pictureBox1.Image = this.bmpText;
        }
         */
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = GetImageBytes(pictureBox1.Image);

            string connStr = @"Data Source=rjsys4-4;Initial catalog=student;integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "Insert Into li Values('a','b',@ImgData) ";
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    SqlParameter param = new SqlParameter("ImgData", SqlDbType.VarBinary, imageBytes.Length);
                    param.Value = imageBytes;
                    cmd.Parameters.Add(param);

                    cmd.Connection = conn;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    MessageBox.Show(i.ToString());
                }
            }
        }
        private byte[] GetImageBytes(Image image)
        {
            MemoryStream mstream = new MemoryStream();
            image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byteData, 0, byteData.Length);
            mstream.Close();
            return byteData;
        }
     */   
    }
}
