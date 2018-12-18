namespace Financial
{
    partial class FormDebitManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebitManage));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton_Add = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItem_AddIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddOutput = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Del = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Modify = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Print = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Statistic = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_DataInput = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_DataOutput = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Exit = new System.Windows.Forms.ToolStripButton();
            this.listViewTable = new System.Windows.Forms.ListView();
            this.columnHeader_Num = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Name = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Date = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Borrow = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_Lend = new System.Windows.Forms.ColumnHeader();
            this.columnHeader_About = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton_Add,
            this.toolStripButton_Del,
            this.toolStripButton_Modify,
            this.toolStripSeparator1,
            this.toolStripButton_Print,
            this.toolStripButton_Statistic,
            this.toolStripSeparator2,
            this.toolStripButton_DataInput,
            this.toolStripButton_DataOutput,
            this.toolStripSeparator3,
            this.toolStripButton_Exit});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(714, 37);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton_Add
            // 
            this.toolStripSplitButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddIncome,
            this.ToolStripMenuItem_AddOutput});
            this.toolStripSplitButton_Add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton_Add.Image")));
            this.toolStripSplitButton_Add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton_Add.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripSplitButton_Add.Name = "toolStripSplitButton_Add";
            this.toolStripSplitButton_Add.Size = new System.Drawing.Size(76, 34);
            this.toolStripSplitButton_Add.Text = "添加";
            // 
            // ToolStripMenuItem_AddIncome
            // 
            this.ToolStripMenuItem_AddIncome.Name = "ToolStripMenuItem_AddIncome";
            this.ToolStripMenuItem_AddIncome.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItem_AddIncome.Text = "添加收入";
            // 
            // ToolStripMenuItem_AddOutput
            // 
            this.ToolStripMenuItem_AddOutput.Name = "ToolStripMenuItem_AddOutput";
            this.ToolStripMenuItem_AddOutput.Size = new System.Drawing.Size(118, 22);
            this.ToolStripMenuItem_AddOutput.Text = "添加支出";
            // 
            // toolStripButton_Del
            // 
            this.toolStripButton_Del.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Del.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Del.Image")));
            this.toolStripButton_Del.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Del.Name = "toolStripButton_Del";
            this.toolStripButton_Del.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Del.Text = "删除";
            // 
            // toolStripButton_Modify
            // 
            this.toolStripButton_Modify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Modify.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Modify.Image")));
            this.toolStripButton_Modify.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Modify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Modify.Name = "toolStripButton_Modify";
            this.toolStripButton_Modify.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Modify.Text = "修改";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton_Print
            // 
            this.toolStripButton_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Print.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Print.Image")));
            this.toolStripButton_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Print.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Print.Name = "toolStripButton_Print";
            this.toolStripButton_Print.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Print.Text = "打印";
            // 
            // toolStripButton_Statistic
            // 
            this.toolStripButton_Statistic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Statistic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Statistic.Image")));
            this.toolStripButton_Statistic.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Statistic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Statistic.Name = "toolStripButton_Statistic";
            this.toolStripButton_Statistic.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Statistic.Text = "统计";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton_DataInput
            // 
            this.toolStripButton_DataInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DataInput.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DataInput.Image")));
            this.toolStripButton_DataInput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_DataInput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DataInput.Name = "toolStripButton_DataInput";
            this.toolStripButton_DataInput.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_DataInput.Text = "数据导入";
            // 
            // toolStripButton_DataOutput
            // 
            this.toolStripButton_DataOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_DataOutput.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_DataOutput.Image")));
            this.toolStripButton_DataOutput.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_DataOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_DataOutput.Name = "toolStripButton_DataOutput";
            this.toolStripButton_DataOutput.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_DataOutput.Text = "数据导出";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripButton_Exit
            // 
            this.toolStripButton_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Exit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Exit.Image")));
            this.toolStripButton_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Exit.Name = "toolStripButton_Exit";
            this.toolStripButton_Exit.Size = new System.Drawing.Size(64, 34);
            this.toolStripButton_Exit.Text = "退出";
            // 
            // listViewTable
            // 
            this.listViewTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Num,
            this.columnHeader_Name,
            this.columnHeader_Date,
            this.columnHeader_Borrow,
            this.columnHeader_Lend,
            this.columnHeader_About});
            this.listViewTable.Location = new System.Drawing.Point(0, 40);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(714, 426);
            this.listViewTable.TabIndex = 3;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Num
            // 
            this.columnHeader_Num.Text = "序号";
            this.columnHeader_Num.Width = 75;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "姓名";
            this.columnHeader_Name.Width = 94;
            // 
            // columnHeader_Date
            // 
            this.columnHeader_Date.Text = "日期";
            this.columnHeader_Date.Width = 116;
            // 
            // columnHeader_Borrow
            // 
            this.columnHeader_Borrow.Text = "借入金额";
            this.columnHeader_Borrow.Width = 89;
            // 
            // columnHeader_Lend
            // 
            this.columnHeader_Lend.Text = "借出金额";
            this.columnHeader_Lend.Width = 86;
            // 
            // columnHeader_About
            // 
            this.columnHeader_About.Text = "备注";
            this.columnHeader_About.Width = 205;
            // 
            // FormDebitManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 466);
            this.Controls.Add(this.listViewTable);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormDebitManage";
            this.Text = "FormDebitManage";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton_Add;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddIncome;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddOutput;
        private System.Windows.Forms.ToolStripButton toolStripButton_Del;
        private System.Windows.Forms.ToolStripButton toolStripButton_Modify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_Print;
        private System.Windows.Forms.ToolStripButton toolStripButton_Statistic;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton_DataInput;
        private System.Windows.Forms.ToolStripButton toolStripButton_DataOutput;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton_Exit;
        private System.Windows.Forms.ListView listViewTable;
        private System.Windows.Forms.ColumnHeader columnHeader_Num;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_Borrow;
        private System.Windows.Forms.ColumnHeader columnHeader_Lend;
        private System.Windows.Forms.ColumnHeader columnHeader_About;
    }
}