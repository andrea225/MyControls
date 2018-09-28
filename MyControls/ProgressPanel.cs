namespace HYL
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    using HYLControlLibrary;

    public partial class ProgressPanel : UserControl
    {
        public ProgressPanel()
        {
            this.InitializeComponent();
            this.Center();
            this.Visible = false;
        }

        [Bindable(true), Category("Style"), DefaultValue(typeof(Color), "ControlLight"), Description("背景颜色")]
        public new Color BackColor
        {
            get => this.panel1.BackColor;
            set => this.panel1.InvokeAction(() => { this.panel1.BackColor = value; });
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条最大值")]
        public int Maximum
        {
            get => this.progressBarX1.Maximum;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.Maximum = value; });
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条最小值")]
        public int Minimum
        {
            get => this.progressBarX1.Minimum;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.Minimum = value; });
        }

        [Bindable(true), Category("Style"), Description("进图条背景色")]
        public Color ProgressBarBackColor
        {
            get => this.progressBarX1.BackColor;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.BackColor = value; });
        }

        [Bindable(true), Category("Style"), Description("进图条颜色")]
        public Color ProgressBarColor
        {
            get => this.progressBarX1.ForeColor;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.ForeColor = value; });
        }

        [Bindable(true), Category("Style"), Description("进图条样式")]
        public ProgressBarAnimationStyleX Style
        {
            get => this.progressBarX1.Style;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.Style = value; });
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条上的文字")]
        public new string Text
        {
            get => this.label1.Text;
            set => this.label1.InvokeAction(() => { this.label1.Text = value; });
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条的值")]
        public int Value
        {
            get => this.progressBarX1.Value;
            set => this.progressBarX1.InvokeAction(() => { this.progressBarX1.Value = value; });
        }

        private void Center()
        {
            this.panel1.Location = GetLocation(this.panel1);
            var progressBarLoaction = GetLocation(this.progressBarX1);
            this.progressBarX1.Location = progressBarLoaction;
            this.label1.Location = new Point(progressBarLoaction.X - 10, progressBarLoaction.Y - 30);

            Point GetLocation(Control c)
            {
                return new Point((c.Parent.Width - c.Width) / 2, (c.Parent.Height - c.Height) / 2);
            }
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
            this.Center();
        }

        private void progressBarX1_SizeChanged(object sender, EventArgs e)
        {
            this.Center();
        }

        private void ProgressPanel_SizeChanged(object sender, EventArgs e)
        {
            this.Center();
            this.Hide();
            this.SetFakeMask();
            this.Show();
        }

        public new void Show()
        {
            this.Dock = DockStyle.Fill;
            this.SetFakeMask();
            base.Show();
        }

        public new void Hide()
        {
            this.InvokeAction(() => { base.Hide(); });
        }

        private void SetFakeMask()
        {
            var pf = this.ParentForm;

            Bitmap bit1 = new Bitmap(pf.Width, pf.Height);
            pf.DrawToBitmap(bit1, new Rectangle(0, 0, pf.Width, pf.Height));
            int border = (pf.Width - pf.ClientSize.Width) / 2;//边框宽度
            int caption = (pf.Height - pf.ClientSize.Height) - border;//标题栏高度
            Bitmap bit2 = bit1.Clone(new Rectangle(border, caption, pf.ClientSize.Width, pf.ClientSize.Height), System.Drawing.Imaging.PixelFormat.DontCare);
            this.BackgroundImage = bit2;
            this.BackgroundImageLayout = ImageLayout.None;
        }
    }
}