namespace Financial
{
    partial class FormRegistNewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Psw = new System.Windows.Forms.TextBox();
            this.textBox_Psw2 = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "重输密码";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(128, 54);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(184, 21);
            this.textBox_UserName.TabIndex = 1;
            // 
            // textBox_Psw
            // 
            this.textBox_Psw.Location = new System.Drawing.Point(128, 90);
            this.textBox_Psw.Name = "textBox_Psw";
            this.textBox_Psw.PasswordChar = '●';
            this.textBox_Psw.Size = new System.Drawing.Size(184, 21);
            this.textBox_Psw.TabIndex = 2;
            // 
            // textBox_Psw2
            // 
            this.textBox_Psw2.Location = new System.Drawing.Point(128, 130);
            this.textBox_Psw2.Name = "textBox_Psw2";
            this.textBox_Psw2.PasswordChar = '●';
            this.textBox_Psw2.Size = new System.Drawing.Size(184, 21);
            this.textBox_Psw2.TabIndex = 3;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(46, 18);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(161, 12);
            this.label_Info.TabIndex = 2;
            this.label_Info.Text = "注册新用户：请填写注册信息";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(287, 178);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(92, 27);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "注册";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(212, 178);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(69, 27);
            this.button_Cancel.TabIndex = 5;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormRegistNewUser
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(401, 217);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.textBox_Psw2);
            this.Controls.Add(this.textBox_Psw);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormRegistNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册新用户";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_OK;
        public System.Windows.Forms.TextBox textBox_UserName;
        public System.Windows.Forms.TextBox textBox_Psw;
        public System.Windows.Forms.TextBox textBox_Psw2;
        private System.Windows.Forms.Button button_Cancel;
    }
}