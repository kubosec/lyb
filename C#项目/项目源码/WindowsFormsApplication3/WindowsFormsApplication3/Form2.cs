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
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class Form_register : Form
    {
        int ax=0;
        public Form_register()
        {
            InitializeComponent();
        }

        private void Form_register_Load(object sender, EventArgs e)
        {

        }
        void check()
        {
            if(textBox3.Text!=textBox4.Text)
            {
                ax++;
                MessageBox.Show("两次密码不相同","提示");
                return;
            }
            else if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                ax++;
                MessageBox.Show("用户ID和密码不能为空", "提示");
                return;
            }
        }
        bool a = false;
        private void btn_ok_Click(object sender, EventArgs e)
        {
            check();
            if (ax == 0)
            {
                //string str = "insert into src(id,username,password) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
               // DBOperation.exesql(str);
                //insert(pictureBox1.Image);
                insert(pictureBox1.Image);
                if (a)
                {
                    MessageBox.Show("注冊成功", "提示");
                    this.Close();
                    //Form_login f2 = new Form_login();
                    //f2.Show();
                }
            }
        }

        private void Form_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
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
             * */
            
            //Form_login f2 = new Form_login();
            //f2.Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
           // Form_login f1 = new Form_login();
           // f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog { Filter = "常见图片|*.jpg;*.gif;*.png;*.bmp|全部文件|*.*" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                //insert(pictureBox1.Image);
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
        void insert(Image image)
        {
            byte[] imageBytes = GetImageBytes(image);

            string connStr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "Insert Into src(id,username,password,images) Values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"',@ImgData) ";
                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    SqlParameter param = new SqlParameter("ImgData", SqlDbType.VarBinary, imageBytes.Length);
                    param.Value = imageBytes;

                    cmd.Parameters.Add(param);
                    

                    cmd.Connection = conn;
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    //MessageBox.Show("注冊成功","提示");
                    //return true;
                    a = true;
                }
            }
        }
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-KDKK51O\SQLEXPRESS;Initial catalog=student;integrated Security=True";
            SqlConnection conn = new SqlConnection(constr);//创建数据库连接
            conn.Open();//打开连接
            //SqlDataAdapter sda = new SqlDataAdapter();//SqlDataAdapter是数据适配器，是数据库和调用者之间的桥梁
            SqlCommand cmd = new SqlCommand();  //SqlCommand表示对数据库要执行的操作命令。
            cmd.CommandText = "select * from src where id='"+textBox1.Text+"'";//cmd要执行的sql操作语句
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
         */
    }
}
