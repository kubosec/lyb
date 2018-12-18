namespace Financial
{
    partial class FormLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Log = new System.Windows.Forms.Button();
            this.button_Tips = new System.Windows.Forms.Button();
            this.textBox_Psw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_UserName = new System.Windows.Forms.ComboBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.labe3 = new System.Windows.Forms.Label();
            this.linkLabel_Regist = new System.Windows.Forms.LinkLabel();
            this.toolTip_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox_Title = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_Info);
            this.groupBox1.Controls.Add(this.button_Log);
            this.groupBox1.Controls.Add(this.button_Tips);
            this.groupBox1.Controls.Add(this.textBox_Psw);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_UserName);
            this.groupBox1.Location = new System.Drawing.Point(19, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(527, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆";
            // 
            // label_Info
            // 
            this.label_Info.Location = new System.Drawing.Point(117, 162);
            this.label_Info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(361, 29);
            this.label_Info.TabIndex = 5;
            // 
            // button_Log
            // 
            this.button_Log.Location = new System.Drawing.Point(375, 120);
            this.button_Log.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Log.Name = "button_Log";
            this.button_Log.Size = new System.Drawing.Size(127, 29);
            this.button_Log.TabIndex = 4;
            this.button_Log.Text = "登陆";
            this.button_Log.UseVisualStyleBackColor = true;
            this.button_Log.Click += new System.EventHandler(this.button_Log_Click);
            // 
            // button_Tips
            // 
            this.button_Tips.Location = new System.Drawing.Point(67, 131);
            this.button_Tips.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Tips.Name = "button_Tips";
            this.button_Tips.Size = new System.Drawing.Size(45, 29);
            this.button_Tips.TabIndex = 3;
            this.button_Tips.Text = "...";
            this.toolTip_Info.SetToolTip(this.button_Tips, "密码提示");
            this.button_Tips.UseVisualStyleBackColor = true;
            this.button_Tips.Click += new System.EventHandler(this.button_Tips_Click);
            this.button_Tips.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_Tips_MouseDown);
            // 
            // textBox_Psw
            // 
            this.textBox_Psw.Location = new System.Drawing.Point(120, 120);
            this.textBox_Psw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Psw.Name = "textBox_Psw";
            this.textBox_Psw.PasswordChar = '●';
            this.textBox_Psw.Size = new System.Drawing.Size(231, 25);
            this.textBox_Psw.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            // 
            // comboBox_UserName
            // 
            this.comboBox_UserName.FormattingEnabled = true;
            this.comboBox_UserName.Location = new System.Drawing.Point(120, 51);
            this.comboBox_UserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_UserName.Name = "comboBox_UserName";
            this.comboBox_UserName.Size = new System.Drawing.Size(357, 23);
            this.comboBox_UserName.TabIndex = 0;
            this.comboBox_UserName.SelectedIndexChanged += new System.EventHandler(this.comboBox_UserName_SelectedIndexChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(413, 330);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(107, 29);
            this.button_Cancel.TabIndex = 1;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // labe3
            // 
            this.labe3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labe3.AutoSize = true;
            this.labe3.Location = new System.Drawing.Point(95, 344);
            this.labe3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(52, 15);
            this.labe3.TabIndex = 2;
            this.labe3.Text = "新用户";
            // 
            // linkLabel_Regist
            // 
            this.linkLabel_Regist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_Regist.AutoSize = true;
            this.linkLabel_Regist.Location = new System.Drawing.Point(48, 344);
            this.linkLabel_Regist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_Regist.Name = "linkLabel_Regist";
            this.linkLabel_Regist.Size = new System.Drawing.Size(37, 15);
            this.linkLabel_Regist.TabIndex = 3;
            this.linkLabel_Regist.TabStop = true;
            this.linkLabel_Regist.Text = "注册";
            this.linkLabel_Regist.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_Regist_LinkClicked);
            // 
            // pictureBox_Title
            // 
            this.pictureBox_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Title.Location = new System.Drawing.Point(16, 31);
            this.pictureBox_Title.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_Title.Name = "pictureBox_Title";
            this.pictureBox_Title.Size = new System.Drawing.Size(531, 81);
            this.pictureBox_Title.TabIndex = 4;
            this.pictureBox_Title.TabStop = false;
            this.pictureBox_Title.Click += new System.EventHandler(this.pictureBox_Title_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.button_Log;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 379);
            this.Controls.Add(this.pictureBox_Title);
            this.Controls.Add(this.linkLabel_Regist);
            this.Controls.Add(this.labe3);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登陆";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Tips;
        private System.Windows.Forms.TextBox textBox_Psw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_UserName;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.LinkLabel linkLabel_Regist;
        private System.Windows.Forms.Button button_Log;
        private System.Windows.Forms.ToolTip toolTip_Info;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.PictureBox pictureBox_Title;
        private System.Windows.Forms.Timer timer1;
    }
}