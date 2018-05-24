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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pager1 = new HYL.Pager();
            this.maskPanel1 = new HYL.MaskPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 334);
            this.textBox1.TabIndex = 5;
            // 
            // pager1
            // 
            this.pager1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager1.Location = new System.Drawing.Point(0, 481);
            this.pager1.MaximumSize = new System.Drawing.Size(9999, 25);
            this.pager1.MinimumSize = new System.Drawing.Size(330, 25);
            this.pager1.Name = "pager1";
            this.pager1.ReportPageChangeOnInit = false;
            this.pager1.Size = new System.Drawing.Size(908, 25);
            this.pager1.TabIndex = 6;
            this.pager1.PageChanged += new System.EventHandler<HYL.PageChangedEventArgs>(this.pager1_PageChanged);
            // 
            // maskPanel1
            // 
            this.maskPanel1.Location = new System.Drawing.Point(689, 106);
            this.maskPanel1.Name = "maskPanel1";
            this.maskPanel1.Opacity = 200;
            this.maskPanel1.Size = new System.Drawing.Size(63, 97);
            this.maskPanel1.TabIndex = 3;
            this.maskPanel1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 506);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskPanel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private HYL.MaskPanel maskPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private HYL.Pager pager1;
    }
}