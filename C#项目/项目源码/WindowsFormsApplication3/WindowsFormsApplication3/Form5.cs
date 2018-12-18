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
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form_Main : Form
    {
        //Mplayer mplayer = new Mplayer();
        //int type = 0;
        public Form_Main()
        {
            InitializeComponent();
            //this.Closing += new CancelEventHandler(Form_Main_FormClosing);
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\kubo\Documents\Visual Studio 2012\Projects\WindowsFormsApplication3\WindowsFormsApplication3\胡夏 - 同桌的你.mp3";

            this.toolStripStatusLabel2.Text = Form_login.name;
            //FormManageItem fmi = new FormManageItem();
            //fmi.MdiParent = this;
            //fmi.Show();



            string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);//创建数据库连接
            conn.Open();//打开连接
            //SqlDataAdapter sda = new SqlDataAdapter();//SqlDataAdapter是数据适配器，是数据库和调用者之间的桥梁
            SqlCommand cmd = new SqlCommand();  //SqlCommand表示对数据库要执行的操作命令。
            cmd.CommandText = "select * from src where id='" + Form_login.name + "'";//cmd要执行的sql操作语句
            cmd.Connection = conn;//cmd对应的连接
            SqlDataReader reader = cmd.ExecuteReader();
            //string i;
            //Image re;
            byte[] imagebytes = null;
            while (reader.Read())
            {
                imagebytes = (byte[])reader["images"];
                //re = reader["images"];
                //string username = reader["id"].ToString();
            }
            //GetImageBytes(re);
            MemoryStream ms = new MemoryStream(imagebytes);

            Bitmap bmpt = new Bitmap(ms);

            pictureBox2.Image = bmpt;


            

        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
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

        private void 账户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = "主界面-[账户管理]";
            panel1.Controls.Clear();
            AccountManage gmFrm = new AccountManage();
            gmFrm.FormBorderStyle = FormBorderStyle.None;//隐藏子窗体边框（去除最大化、最小化、关闭等）
            gmFrm.TopLevel = false;//指示子窗体非顶级窗体

            this.panel1.Controls.Add(gmFrm);//将子窗体载入panel
            gmFrm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            byte[] imageBytes = GetImageBytes(pictureBox1.Image);

            string connStr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "Insert Into src(id,username,password,images) Values('a','b','c',@ImgData) ";
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
              */
           // Image i=
           // GetImageBytes();
            string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);//创建数据库连接
            conn.Open();//打开连接
            //SqlDataAdapter sda = new SqlDataAdapter();//SqlDataAdapter是数据适配器，是数据库和调用者之间的桥梁
            SqlCommand cmd = new SqlCommand();  //SqlCommand表示对数据库要执行的操作命令。
            cmd.CommandText = "select * from src where id='a'";//cmd要执行的sql操作语句
            cmd.Connection = conn;//cmd对应的连接
            SqlDataReader reader = cmd.ExecuteReader();
           // string i;
            //Image re;
            byte[] imagebytes = null;
            while (reader.Read())
            {
                imagebytes = (byte[])reader["images"];
                //re = reader["images"];
                //string username = reader["id"].ToString();
            }
            //GetImageBytes(re);
            MemoryStream ms = new MemoryStream(imagebytes);

            Bitmap bmpt = new Bitmap(ms);

            pictureBox2.Image = bmpt;
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "常见图片|*.jpg;*.gif;*.png;*.bmp|全部文件|*.*" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(open.FileName);
            }
        }

        

        private void 收支管理ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Text = "主界面-[借贷管理]";
            panel1.Controls.Clear();
            Borrow gmFrm = new Borrow();
            gmFrm.FormBorderStyle = FormBorderStyle.None;//隐藏子窗体边框（去除最大化、最小化、关闭等）
            gmFrm.TopLevel = false;//指示子窗体非顶级窗体

            this.panel1.Controls.Add(gmFrm);//将子窗体载入panel
            gmFrm.Show();
        }

        private void 普通计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Process.Start(Application.StartupPath + Path.DirectorySeparatorChar + "Cal" + Path.DirectorySeparatorChar + "WinCal.exe");
            //Process.start("calc.exe");
            System.Diagnostics.ProcessStartInfo Info = new System.Diagnostics.ProcessStartInfo();
            Info.FileName = "calc.exe ";//"calc.exe"为计算器，"notepad.exe"为记事本
            System.Diagnostics.Process Proc = System.Diagnostics.Process.Start(Info);
        }

        

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info f5 = new Info();
            f5.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditP f6 = new EditP();
            f6.Show();
        }

        private void 切换用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_login f7 = new Form_login();
            f7.Show();
            this.Visible = false;
        }
        


    }
}
