namespace HYL
{
    partial class Pager
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBoxPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrev = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxPageIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelRecordCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxPageSize,
            this.toolStripSeparator1,
            this.btnFirst,
            this.btnPrev,
            this.toolStripLabel1,
            this.toolStripTextBoxPageIndex,
            this.toolStripLabel2,
            this.btnNext,
            this.btnLast,
            this.toolStripLabel7,
            this.toolStripLabelRecordCount,
            this.toolStripSeparator3,
            this.toolStripLabel5,
            this.toolStripLabelPageCount,
            this.toolStripSeparator2,
            this.toolStripLabel3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBoxPageSize
            // 
            this.toolStripComboBoxPageSize.AutoCompleteCustomSource.AddRange(new string[] {
            "10",
            "20",
            "30",
            "50",
            "100"});
            this.toolStripComboBoxPageSize.AutoSize = false;
            this.toolStripComboBoxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxPageSize.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "50",
            "100"});
            this.toolStripComboBoxPageSize.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripComboBoxPageSize.Name = "toolStripComboBoxPageSize";
            this.toolStripComboBoxPageSize.Size = new System.Drawing.Size(50, 25);
            this.toolStripComboBoxPageSize.ToolTipText = "每页显示条数";
            this.toolStripComboBoxPageSize.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxPageSize_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnFirst
            // 
            this.btnFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFirst.Enabled = false;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(23, 22);
            this.btnFirst.Text = "toolStripButton1";
            this.btnFirst.ToolTipText = "第一页";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrev.Enabled = false;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(23, 22);
            this.btnPrev.Text = "toolStripButton2";
            this.btnPrev.ToolTipText = "上一页";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel1.Text = "第";
            // 
            // toolStripTextBoxPageIndex
            // 
            this.toolStripTextBoxPageIndex.Name = "toolStripTextBoxPageIndex";
            this.toolStripTextBoxPageIndex.Size = new System.Drawing.Size(30, 25);
            this.toolStripTextBoxPageIndex.Text = "0";
            this.toolStripTextBoxPageIndex.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolStripTextBoxPageIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBoxPageIndex_KeyDown);
            this.toolStripTextBoxPageIndex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.toolStripTextBoxPageIndex_MouseUp);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel2.Text = "页";
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Enabled = false;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(23, 22);
            this.btnNext.Text = "toolStripButton3";
            this.btnNext.ToolTipText = "下一页";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLast.Enabled = false;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(23, 22);
            this.btnLast.Text = "toolStripButton4";
            this.btnLast.ToolTipText = "最后一页";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel7.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel7.Text = "条";
            // 
            // toolStripLabelRecordCount
            // 
            this.toolStripLabelRecordCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelRecordCount.Name = "toolStripLabelRecordCount";
            this.toolStripLabelRecordCount.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabelRecordCount.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel5.Text = "页";
            // 
            // toolStripLabelPageCount
            // 
            this.toolStripLabelPageCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelPageCount.Name = "toolStripLabelPageCount";
            this.toolStripLabelPageCount.Size = new System.Drawing.Size(15, 22);
            this.toolStripLabelPageCount.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel3.Text = "共";
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(9999, 25);
            this.MinimumSize = new System.Drawing.Size(330, 25);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnFirst;
        private System.Windows.Forms.ToolStripButton btnPrev;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPageIndex;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnLast;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPageCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRecordCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxPageSize;
    }
}
