namespace HYL
{
    partial class PagerOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagerOld));
            this.bar1 = new DevComponents.DotNetBar.Bar();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.cbbPageSize = new DevComponents.DotNetBar.ComboBoxItem();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.btnFirst = new DevComponents.DotNetBar.ButtonItem();
            this.btnPrev = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.txtPageIndex = new DevComponents.DotNetBar.TextBoxItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.btnNext = new DevComponents.DotNetBar.ButtonItem();
            this.btnLast = new DevComponents.DotNetBar.ButtonItem();
            this.labelItem3 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.lbTotalCount = new DevComponents.DotNetBar.LabelItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.lbPageCount = new DevComponents.DotNetBar.LabelItem();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.AntiAlias = true;
            this.bar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bar1.IsMaximized = false;
            this.bar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem5,
            this.cbbPageSize,
            this.btnFirst,
            this.btnPrev,
            this.labelItem1,
            this.txtPageIndex,
            this.labelItem2,
            this.btnNext,
            this.btnLast,
            this.labelItem3,
            this.labelItem4,
            this.lbTotalCount,
            this.labelItem7,
            this.lbPageCount,
            this.labelItem8,
            this.labelItem6});
            this.bar1.Location = new System.Drawing.Point(0, 0);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(635, 29);
            this.bar1.Stretch = true;
            this.bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar1.TabIndex = 0;
            this.bar1.TabStop = false;
            // 
            // labelItem5
            // 
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Width = 20;
            // 
            // cbbPageSize
            // 
            this.cbbPageSize.ComboWidth = 60;
            this.cbbPageSize.DropDownHeight = 100;
            this.cbbPageSize.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Center;
            this.cbbPageSize.ItemHeight = 18;
            this.cbbPageSize.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3,
            this.comboItem4,
            this.comboItem5});
            this.cbbPageSize.Name = "cbbPageSize";
            this.cbbPageSize.SelectedIndexChanged += new System.EventHandler(this.cbbPageSize_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "10";
            this.comboItem1.Value = "10";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "15";
            this.comboItem2.Value = "20";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "20";
            this.comboItem3.Value = "30";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "50";
            this.comboItem4.Value = "50";
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "100";
            this.comboItem5.Value = "100";
            // 
            // btnFirst
            // 
            this.btnFirst.BeginGroup = true;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Text = "buttonItem1";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Text = "buttonItem2";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // labelItem1
            // 
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.Text = "第";
            // 
            // txtPageIndex
            // 
            this.txtPageIndex.Name = "txtPageIndex";
            this.txtPageIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageIndex.TextBoxWidth = 40;
            this.txtPageIndex.WatermarkColor = System.Drawing.SystemColors.GrayText;
            this.txtPageIndex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageIndex_KeyDown);
            // 
            // labelItem2
            // 
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "页";
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Name = "btnNext";
            this.btnNext.Text = "buttonItem3";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Name = "btnLast";
            this.btnLast.Text = "buttonItem4";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // labelItem3
            // 
            this.labelItem3.Name = "labelItem3";
            this.labelItem3.Stretch = true;
            // 
            // labelItem4
            // 
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.Text = "共";
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.BeginGroup = true;
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Text = "{0}";
            this.lbTotalCount.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "条";
            // 
            // lbPageCount
            // 
            this.lbPageCount.BeginGroup = true;
            this.lbPageCount.Name = "lbPageCount";
            this.lbPageCount.Text = "{1}";
            this.lbPageCount.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelItem8
            // 
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.Text = "页";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Width = 20;
            // 
            // PagerOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bar1);
            this.Name = "PagerOld";
            this.Size = new System.Drawing.Size(635, 30);
            ((System.ComponentModel.ISupportInitialize)(this.bar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Bar bar1;
        private DevComponents.DotNetBar.ComboBoxItem cbbPageSize;
        private DevComponents.DotNetBar.ButtonItem btnFirst;
        private DevComponents.DotNetBar.ButtonItem btnPrev;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.TextBoxItem txtPageIndex;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.ButtonItem btnNext;
        private DevComponents.DotNetBar.ButtonItem btnLast;
        private DevComponents.DotNetBar.LabelItem labelItem3;
        private DevComponents.DotNetBar.LabelItem lbTotalCount;
        private DevComponents.DotNetBar.LabelItem lbPageCount;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.Editors.ComboItem comboItem5;
    }
}
