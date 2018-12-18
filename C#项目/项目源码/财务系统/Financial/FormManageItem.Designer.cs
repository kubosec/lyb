namespace Financial
{
    partial class FormManageItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Info = new System.Windows.Forms.Label();
            this.label_Debit = new System.Windows.Forms.Label();
            this.label_Income = new System.Windows.Forms.Label();
            this.label_Account = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label_Info);
            this.panel1.Controls.Add(this.label_Debit);
            this.panel1.Controls.Add(this.label_Income);
            this.panel1.Controls.Add(this.label_Account);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 290);
            this.panel1.TabIndex = 0;
            // 
            // label_Info
            // 
            this.label_Info.Location = new System.Drawing.Point(233, 30);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(296, 208);
            this.label_Info.TabIndex = 1;
            // 
            // label_Debit
            // 
            this.label_Debit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Debit.Location = new System.Drawing.Point(33, 189);
            this.label_Debit.Name = "label_Debit";
            this.label_Debit.Size = new System.Drawing.Size(149, 49);
            this.label_Debit.TabIndex = 0;
            this.label_Debit.Text = "借贷管理";
            this.label_Debit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Debit.MouseLeave += new System.EventHandler(this.label_Account_MouseLeave);
            this.label_Debit.Click += new System.EventHandler(this.label_Debit_Click);
            this.label_Debit.MouseEnter += new System.EventHandler(this.label_Debit_MouseEnter);
            // 
            // label_Income
            // 
            this.label_Income.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Income.Location = new System.Drawing.Point(33, 111);
            this.label_Income.Name = "label_Income";
            this.label_Income.Size = new System.Drawing.Size(149, 49);
            this.label_Income.TabIndex = 0;
            this.label_Income.Text = "收支管理";
            this.label_Income.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Income.MouseLeave += new System.EventHandler(this.label_Account_MouseLeave);
            this.label_Income.Click += new System.EventHandler(this.label_Income_Click);
            this.label_Income.MouseEnter += new System.EventHandler(this.label_Income_MouseEnter);
            // 
            // label_Account
            // 
            this.label_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Account.Location = new System.Drawing.Point(33, 30);
            this.label_Account.Name = "label_Account";
            this.label_Account.Size = new System.Drawing.Size(149, 49);
            this.label_Account.TabIndex = 0;
            this.label_Account.Text = "帐户管理";
            this.label_Account.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Account.MouseLeave += new System.EventHandler(this.label_Account_MouseLeave);
            this.label_Account.Click += new System.EventHandler(this.label_Account_Click);
            this.label_Account.MouseEnter += new System.EventHandler(this.label_Account_MouseEnter);
            // 
            // FormManageItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManageItem";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理";
            this.Activated += new System.EventHandler(this.FormManageItem_Activated);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Debit;
        private System.Windows.Forms.Label label_Income;
        private System.Windows.Forms.Label label_Account;
        private System.Windows.Forms.Label label_Info;
    }
}