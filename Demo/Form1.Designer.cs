namespace Demo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.hylDataGridViewCheckBoxColumn1 = new HYL.DataGridViewX.HylDataGridViewCheckBoxColumn();
            this.pager1 = new HYL.Pager();
            this.progressBarX3 = new HYLControlLibrary.ProgressBarX();
            this.progressBarX2 = new HYLControlLibrary.ProgressBarX();
            this.progressBarX1 = new HYLControlLibrary.ProgressBarX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new HYL.DataGridViewX.HylDataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(322, 44);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(251, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1147, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // hylDataGridViewCheckBoxColumn1
            // 
            this.hylDataGridViewCheckBoxColumn1.HeaderText = "Column1";
            this.hylDataGridViewCheckBoxColumn1.Name = "hylDataGridViewCheckBoxColumn1";
            // 
            // pager1
            // 
            this.pager1.Location = new System.Drawing.Point(536, 469);
            this.pager1.MaximumSize = new System.Drawing.Size(9999, 25);
            this.pager1.MinimumSize = new System.Drawing.Size(330, 25);
            this.pager1.Name = "pager1";
            this.pager1.ReportPageChangeOnInit = false;
            this.pager1.Size = new System.Drawing.Size(498, 25);
            this.pager1.TabIndex = 17;
            // 
            // progressBarX3
            // 
            this.progressBarX3.AnimationColor = System.Drawing.Color.Snow;
            this.progressBarX3.ForeColor = System.Drawing.Color.DarkCyan;
            this.progressBarX3.Location = new System.Drawing.Point(218, 162);
            this.progressBarX3.Name = "progressBarX3";
            this.progressBarX3.Size = new System.Drawing.Size(369, 5);
            this.progressBarX3.TabIndex = 14;
            this.progressBarX3.Text = "progressBarX3";
            // 
            // progressBarX2
            // 
            this.progressBarX2.Location = new System.Drawing.Point(218, 198);
            this.progressBarX2.Name = "progressBarX2";
            this.progressBarX2.Size = new System.Drawing.Size(369, 23);
            this.progressBarX2.TabIndex = 13;
            this.progressBarX2.Text = "progressBarX2";
            this.progressBarX2.Value = 20;
            // 
            // progressBarX1
            // 
            this.progressBarX1.AnimationColor = System.Drawing.Color.Maroon;
            this.progressBarX1.AnimationSpeed = 50;
            this.progressBarX1.AnimationWidth = 200;
            this.progressBarX1.BorderColor = System.Drawing.Color.Black;
            this.progressBarX1.ForeColor = System.Drawing.Color.White;
            this.progressBarX1.Location = new System.Drawing.Point(218, 245);
            this.progressBarX1.Maximum = 1;
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(369, 23);
            this.progressBarX1.Style = HYLControlLibrary.ProgressBarAnimationStyleX.Solid;
            this.progressBarX1.TabIndex = 12;
            this.progressBarX1.Text = "progressBarX1";
            this.progressBarX1.Value = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(104, 363);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(426, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1147, 666);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.progressBarX3);
            this.Controls.Add(this.progressBarX2);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button3;
        private HYLControlLibrary.ProgressBarX progressBarX1;
        private HYLControlLibrary.ProgressBarX progressBarX2;
        private HYLControlLibrary.ProgressBarX progressBarX3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private HYL.Pager pager1;
        private HYL.DataGridViewX.HylDataGridViewCheckBoxColumn hylDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HYL.DataGridViewX.HylDataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}