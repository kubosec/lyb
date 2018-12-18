namespace Financial
{
    partial class FormFinancialManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFinancialManage));
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
            this.columnHeader_Num = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader＿Income = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Output = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_About = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker_selectForm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_selectTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_selectType = new System.Windows.Forms.ComboBox();
            this.button_Select = new System.Windows.Forms.Button();
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
            this.toolStrip1.Size = new System.Drawing.Size(952, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            this.toolStripSplitButton_Add.ButtonClick += new System.EventHandler(this.toolStripSplitButton_Add_ButtonClick);
            // 
            // ToolStripMenuItem_AddIncome
            // 
            this.ToolStripMenuItem_AddIncome.Name = "ToolStripMenuItem_AddIncome";
            this.ToolStripMenuItem_AddIncome.Size = new System.Drawing.Size(152, 24);
            this.ToolStripMenuItem_AddIncome.Text = "添加收入";
            // 
            // ToolStripMenuItem_AddOutput
            // 
            this.ToolStripMenuItem_AddOutput.Name = "ToolStripMenuItem_AddOutput";
            this.ToolStripMenuItem_AddOutput.Size = new System.Drawing.Size(152, 24);
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
            this.toolStripButton_Del.Click += new System.EventHandler(this.toolStripButton_Del_Click);
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
            this.columnHeader_Date,
            this.columnHeader_Type,
            this.columnHeader＿Income,
            this.columnHeader_Output,
            this.columnHeader_Balance,
            this.columnHeader_About});
            this.listViewTable.Location = new System.Drawing.Point(0, 84);
            this.listViewTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewTable.Name = "listViewTable";
            this.listViewTable.Size = new System.Drawing.Size(951, 496);
            this.listViewTable.TabIndex = 2;
            this.listViewTable.UseCompatibleStateImageBehavior = false;
            this.listViewTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Num
            // 
            this.columnHeader_Num.Text = "序号";
            this.columnHeader_Num.Width = 76;
            // 
            // columnHeader_Date
            // 
            this.columnHeader_Date.Text = "创建日期";
            this.columnHeader_Date.Width = 74;
            // 
            // columnHeader_Type
            // 
            this.columnHeader_Type.Text = "类型";
            this.columnHeader_Type.Width = 70;
            // 
            // columnHeader＿Income
            // 
            this.columnHeader＿Income.Text = "收入";
            this.columnHeader＿Income.Width = 76;
            // 
            // columnHeader_Output
            // 
            this.columnHeader_Output.Text = "支出";
            this.columnHeader_Output.Width = 79;
            // 
            // columnHeader_Balance
            // 
            this.columnHeader_Balance.Text = "余额";
            this.columnHeader_Balance.Width = 71;
            // 
            // columnHeader_About
            // 
            this.columnHeader_About.Text = "备注";
            this.columnHeader_About.Width = 136;
            // 
            // dateTimePicker_selectForm
            // 
            this.dateTimePicker_selectForm.Location = new System.Drawing.Point(113, 51);
            this.dateTimePicker_selectForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_selectForm.Name = "dateTimePicker_selectForm";
            this.dateTimePicker_selectForm.Size = new System.Drawing.Size(156, 25);
            this.dateTimePicker_selectForm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "筛选：从";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "到";
            // 
            // dateTimePicker_selectTo
            // 
            this.dateTimePicker_selectTo.Location = new System.Drawing.Point(317, 51);
            this.dateTimePicker_selectTo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_selectTo.Name = "dateTimePicker_selectTo";
            this.dateTimePicker_selectTo.Size = new System.Drawing.Size(156, 25);
            this.dateTimePicker_selectTo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "类型";
            // 
            // comboBox_selectType
            // 
            this.comboBox_selectType.FormattingEnabled = true;
            this.comboBox_selectType.Location = new System.Drawing.Point(556, 51);
            this.comboBox_selectType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_selectType.Name = "comboBox_selectType";
            this.comboBox_selectType.Size = new System.Drawing.Size(160, 23);
            this.comboBox_selectType.TabIndex = 7;
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(757, 48);
            this.button_Select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(100, 29);
            this.button_Select.TabIndex = 8;
            this.button_Select.Text = "给我筛";
            this.button_Select.UseVisualStyleBackColor = true;
            // 
            // FormFinancialManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 582);
            this.Controls.Add(this.button_Select);
            this.Controls.Add(this.comboBox_selectType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_selectTo);
            this.Controls.Add(this.dateTimePicker_selectForm);
            this.Controls.Add(this.listViewTable);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFinancialManage";
            this.Text = "FormFinancialManage";
            this.Load += new System.EventHandler(this.FormFinancialManage_Load);
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
        private System.Windows.Forms.ColumnHeader columnHeader_Date;
        private System.Windows.Forms.ColumnHeader columnHeader_Type;
        private System.Windows.Forms.ColumnHeader columnHeader＿Income;
        private System.Windows.Forms.ColumnHeader columnHeader_Output;
        private System.Windows.Forms.ColumnHeader columnHeader_Balance;
        private System.Windows.Forms.ColumnHeader columnHeader_About;
        private System.Windows.Forms.DateTimePicker dateTimePicker_selectForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_selectTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_selectType;
        private System.Windows.Forms.Button button_Select;
    }
}