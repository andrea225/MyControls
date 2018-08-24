namespace HYL
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    using HYLControlLibrary;

    public partial class MaskPanel2 : UserControl
    {
        private readonly FormProgressBar formProgressBar;

        public MaskPanel2()
        {
            this.InitializeComponent();
            this.Visible = false;
            this.CenterProgressBar();
        }

        [Bindable(true), Category("Style"), DefaultValue(typeof(Color), "ControlLight"), Description("背景颜色")]
        public new Color BackColor
        {
            get => this.formProgressBar.BackColor;
            set => this.formProgressBar.BackColor = value;
        }

        [Bindable(true), Category("Style"), Description("进图条颜色")]
        public Color ProgressBarColor
        {
            get => this.formProgressBar.ProgressBarColor;
            set => this.formProgressBar.ProgressBarColor = value;
        }

        [Bindable(true), Category("Style"), Description("进图条背景色")]
        public Color ProgressBarBackColor
        {
            get => this.formProgressBar.ProgressBarBackColor;
            set => this.formProgressBar.ProgressBarBackColor = value;
        }

        [Bindable(true), Category("Style"), Description("进图条样式")]
        public ProgressBarStyleX Style
        {
            get => this.formProgressBar.Style;
            set => this.formProgressBar.Style = value;
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条的值")]
        public int Value
        {
            get => this.progressBarX1.Value;
            set
            {
                this.progressBarX1.InvokeAction(() => { this.progressBarX1.Value = value; });
            }
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条最大值")]
        public int Maximum
        {
            get => this.formProgressBar.Maximum;
            set => this.formProgressBar.Maximum = value;
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条最小值")]
        public int Minimum
        {
            get => this.formProgressBar.Minimum;
            set => this.formProgressBar.Minimum = value;
        }

        [Bindable(true), Category("ProgressBar"), Description("进度条上的文字")]
        public new string Text
        {
            get => this.label1.Text;
            set
            {
                this.label1.InvokeAction(() => { this.label1.Text = value; });
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

        public void ShowMask()
        {
            Task.Run(
                () =>
                {
                    Action action = () =>
                    {
                        this.formProgressBar.ShowDialog(this);

                        this.Visible = false;
                    };
                    this.Invoke(action);
                });
        }

        public void HideMask()
        {
            Task.Run(
                () =>
                {
                    Action action = () => { this.formProgressBar.Close(); };
                    this.Invoke(action);
                });
        }

        private void CenterProgressBar()
        {
            Point location = new Point(
                (this.Width - this.progressBarX1.Width) / 2,
                (this.Height - this.progressBarX1.Height) / 2); // 居中
            this.progressBarX1.Location = location;
            this.label1.Location = new Point(location.X - 10, location.Y - 30);
        }


    }


}