namespace HYL
{
    partial class MaskPanel
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
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLoading.Image = global::HYL.Properties.Resources.loading;
            this.pictureBoxLoading.Location = new System.Drawing.Point(47, 39);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(39, 39);
            this.pictureBoxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxLoading.TabIndex = 0;
            this.pictureBoxLoading.TabStop = false;
            // 
            // MaskPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxLoading);
            this.Name = "MaskPanel";
            this.Size = new System.Drawing.Size(132, 116);
            this.SizeChanged += new System.EventHandler(this.MaskPanel_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MaskPanel_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLoading;
    }
}
