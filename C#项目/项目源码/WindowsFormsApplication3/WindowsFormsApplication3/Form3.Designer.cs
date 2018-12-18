namespace WindowsFormsApplication3
{
    partial class Form_select
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
            this.btn_ret_login = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_income = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ret_login
            // 
            this.btn_ret_login.FlatAppearance.BorderSize = 0;
            this.btn_ret_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ret_login.Location = new System.Drawing.Point(13, 13);
            this.btn_ret_login.Name = "btn_ret_login";
            this.btn_ret_login.Size = new System.Drawing.Size(153, 23);
            this.btn_ret_login.TabIndex = 0;
            this.btn_ret_login.Text = "返回登录界面";
            this.btn_ret_login.UseVisualStyleBackColor = false;
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(12, 42);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(269, 105);
            this.btn_borrow.TabIndex = 1;
            this.btn_borrow.Text = "借贷管理";
            this.btn_borrow.UseVisualStyleBackColor = true;
            // 
            // btn_account
            // 
            this.btn_account.Location = new System.Drawing.Point(179, 147);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(269, 105);
            this.btn_account.TabIndex = 2;
            this.btn_account.Text = "账户管理";
            this.btn_account.UseVisualStyleBackColor = true;
            // 
            // btn_income
            // 
            this.btn_income.Location = new System.Drawing.Point(314, 258);
            this.btn_income.Name = "btn_income";
            this.btn_income.Size = new System.Drawing.Size(269, 105);
            this.btn_income.TabIndex = 3;
            this.btn_income.Text = "收支管理";
            this.btn_income.UseVisualStyleBackColor = true;
            // 
            // Form_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(627, 398);
            this.Controls.Add(this.btn_income);
            this.Controls.Add(this.btn_account);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_ret_login);
            this.Name = "Form_select";
            this.Text = "  ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ret_login;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_income;
    }
}