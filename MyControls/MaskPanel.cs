namespace HYL
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class MaskPanel : UserControl
    {
        private int opacity = 125;

        public MaskPanel()
        {
            this.InitializeComponent();
            this.Visible = false;
        }

        [Bindable(true), Category("Custom"), DefaultValue(125), Description("背景的透明度. 有效值0-255")]
        public int Opacity
        {
            get => this.opacity;
            set
            {
                if (value > 255)
                {
                    value = 255;
                }
                else if (value < 0)
                {
                    value = 0;
                }

                this.opacity = value;
                this.Invalidate();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
                return cp;
            }
        }

        private void MaskPanel_Paint(object sender, PaintEventArgs e)
        {
            Brush b = new SolidBrush(Color.FromArgb(this.opacity, this.Parent.BackColor));
            e.Graphics.FillRectangle(b, 0, 0, this.Width, this.Height);
        }

        private void MaskPanel_SizeChanged(object sender, EventArgs e)
        {
            Point Location = new Point(
                this.Location.X + (this.Width - this.pictureBoxLoading.Width) / 2,
                this.Location.Y + (this.Height - this.pictureBoxLoading.Height) / 2); // 居中
            this.pictureBoxLoading.Location = Location;
        }
    }
}