namespace WindowsFormsApplication3
{
    partial class Form_sel_model
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ret_login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入密保";
            // 
            // btn_ret_login
            // 
            this.btn_ret_login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ret_login.FlatAppearance.BorderSize = 0;
            this.btn_ret_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ret_login.Location = new System.Drawing.Point(12, 12);
            this.btn_ret_login.Name = "btn_ret_login";
            this.btn_ret_login.Size = new System.Drawing.Size(114, 23);
            this.btn_ret_login.TabIndex = 1;
            this.btn_ret_login.Text = "返回登录界面";
            this.btn_ret_login.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 25);
            this.textBox1.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(182, 180);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // Form_sel_model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 349);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ret_login);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_sel_model";
            this.Text = "选择模块";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ret_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_ok;
    }
}