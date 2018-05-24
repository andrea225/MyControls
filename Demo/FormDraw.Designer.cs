namespace Demo
{
    partial class FormDraw
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
            this.myCanvas1 = new HYL.MyCanvas();
            this.SuspendLayout();
            // 
            // myCanvas1
            // 
            this.myCanvas1.BackColor = System.Drawing.Color.Transparent;
            this.myCanvas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myCanvas1.Location = new System.Drawing.Point(0, 0);
            this.myCanvas1.Name = "myCanvas1";
            this.myCanvas1.Size = new System.Drawing.Size(711, 356);
            this.myCanvas1.TabIndex = 0;
            this.myCanvas1.Text = "myCanvas1";
            // 
            // FormDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 356);
            this.Controls.Add(this.myCanvas1);
            this.Name = "FormDraw";
            this.Text = "FormDraw";
            this.Load += new System.EventHandler(this.FormDraw_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HYL.MyCanvas myCanvas1;
    }
}