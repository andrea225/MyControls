namespace HYLControlLibrary
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ProgressBarX : Control
    {
        private bool animationEnable;

        private int animationLeft;

        private int animationSpeed;

        private Color backColor;

        private Padding borderSize;

        private Rectangle bounds;

        private Color foreColor;

        private int maximum;

        private int minimum;

        private int value;

        private bool visible;

        public ProgressBarX()
        {
            this.InitializeComponent();
            this.Size = new Size(200, 23);
            this.visible = true;

            this.foreColor = Color.DodgerBlue;
            this.backColor = Color.White;
            this.BorderColor = Color.White;
            this.AnimationColor = Color.White;
            this.borderSize.All = 1;
            this.BorderStyle = BorderStyle.Single;
            this.Style = ProgressBarStyleX.Linear;

            this.maximum = 100;
            this.value = 50;
            this.Step = 10;

            this.AnimationEnable = true;
            this.animationSpeed = 20;

            this.SetAnimationPosition();
        }

        [Category("Style")]
        [DefaultValue(typeof(Color), "#FFFFFFFF")]
        [Description("动画颜色")]
        public Color AnimationColor { get; set; }

        [Category("Style"), DefaultValue(true), Description("启用进度条动画")]
        public bool AnimationEnable
        {
            get => this.animationEnable;
            set
            {
                this.animationEnable = value;
                if (value)
                {
                    this.SetAnimationPosition();
                }

                this.Invalidate();
            }
        }

        [Category("Style"), DefaultValue(20), Description("动画速度，取值范围 1 - 100")]
        public int AnimationSpeed
        {
            get => this.animationSpeed;
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.AnimationSpeed), "动画速度取值范围应在 1 - 100 之间");
                }

                this.animationSpeed = value;
            }
        }

        [Category("Style")]
        [DefaultValue(60)]
        [Description("动画宽度")]
        public int AnimationWidth { get; set; } = 60;

        [Category("Style")]
        [DefaultValue(typeof(Color), "#FFFFFFFF")]
        [Description("进度条背景色")]
        public override Color BackColor
        {
            get => this.backColor;
            set => this.backColor = value;
        }

        [Category("Style")]
        [DefaultValue(typeof(Color), "#FFFFFFFF")]
        [Description("边框颜色")]
        public Color BorderColor { get; set; }

        [Category("Style")]
        [DefaultValue(typeof(Padding), "1,1,1,1")]
        [Description("边框大小")]
        public Padding BorderSize
        {
            get => this.borderSize;

            set
            {
                this.animationLeft = value.Left;
                this.borderSize = value;
            }
        }

        [Category("Style"), DefaultValue(BorderStyle.Single), Description("边框样式")]
        public BorderStyle BorderStyle { get; set; }

        [Category("Style")]
        [DefaultValue(typeof(Color), "#FF1E90FF")]
        [Description("进度条前景色")]
        public override Color ForeColor
        {
            get => this.foreColor;
            set => this.foreColor = value;
        }

        [Category("ProgressBar")]
        [DefaultValue(100)]
        [Description("最大值")]
        public int Maximum
        {
            get => this.maximum;
            set
            {
                this.maximum = value;
                this.Invalidate();
            }
        }

        [Category("ProgressBar")]
        [DefaultValue(0)]
        [Description("最小值")]
        public int Minimum
        {
            get => this.minimum;
            set
            {
                this.minimum = value;
                this.Invalidate();
            }
        }

        [Category("ProgressBar")]
        [DefaultValue(10)]
        [Description("每次调用 PerformStep 方法增加进度栏时所根据的数量")]
        public int Step { get; set; }

        [Category("Style")]
        [Description("进度条样式")]
        [DefaultValue(ProgressBarStyleX.Linear)]
        public ProgressBarStyleX Style { get; set; }

        [Category("ProgressBar"), DefaultValue(50)]
        public int Value
        {
            get => this.value;
            set
            {
                if (value < this.minimum || value > this.maximum)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.Value), @"“Value”应介于 'minimum' 和 'maximum' 之间。");
                }

                this.value = value;
                this.Invalidate();
            }
        }

        [DefaultValue(true)]
        public new bool Visible
        {
            get => this.visible;
            set
            {
                base.Visible = value;
                this.visible = value;
                if (value)
                {
                    this.SetAnimationPosition();
                }
            }
        }

        private Padding RealBorderSize => this.BorderStyle == BorderStyle.None ? new Padding(0) : this.borderSize;

        /// <summary>
        /// 按指定的数量增加进度栏的当前位置。
        /// </summary>
        /// <param name="value">增加进度栏的当前位置所根据的数量。</param>
        public void Increment(int value)
        {
            var foo = this.Value + value;

            if (foo > this.Maximum)
            {
                this.value = this.Maximum;
            }
        }

        /// <summary>
        /// 按照 Step 属性的数量增加进度栏的当前位置。
        /// </summary>
        public void PerformStep()
        {
            var foo = this.Value + this.Step;

            if (foo > this.Maximum)
            {
                this.value = this.Maximum;
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            this.SetStyle(
                ControlStyles.DoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint,
                true);

            this.bounds = new Rectangle(
                this.RealBorderSize.Left,
                this.RealBorderSize.Top,
                (int)((this.Width - this.RealBorderSize.Left - this.RealBorderSize.Right)
                      * ((float)this.value / (this.maximum - this.minimum))),
                this.Height - this.RealBorderSize.Top - this.RealBorderSize.Bottom);

            SolidBrush progressBrush = new SolidBrush(this.ForeColor);
            pe.Graphics.FillRectangle(progressBrush, this.bounds);

            if (this.animationLeft != this.RealBorderSize.Left - this.AnimationWidth && this.animationEnable)
            {
                if (this.Style == ProgressBarStyleX.Solid)
                {
                    Brush brush = new SolidBrush(this.AnimationColor);
                    pe.Graphics.FillRectangle(
                        brush,
                        this.animationLeft,
                        this.bounds.Top,
                        Math.Min(this.AnimationWidth, this.bounds.Right - this.animationLeft),
                        this.bounds.Height);
                }
                else
                {
                    var halfAnimationWidth = this.AnimationWidth / 2;

                    // LinearGradientBrush abug https://stackoverflow.com/questions/110081/lineargradientbrush-artifact-workaround
                    LinearGradientBrush leftBrush = new LinearGradientBrush(
                        new Point(this.animationLeft - 1, 0),
                        new Point(this.animationLeft + halfAnimationWidth + 1, 0),
                        this.ForeColor,
                        this.AnimationColor);
                    LinearGradientBrush rightBrush = new LinearGradientBrush(
                        new Point(this.animationLeft + halfAnimationWidth - 1, 0),
                        new Point(this.animationLeft + this.AnimationWidth + 1, 0),
                        this.AnimationColor,
                        this.ForeColor);
                    pe.Graphics.FillRectangle(
                        leftBrush,
                        this.animationLeft,
                        this.bounds.Top,
                        Math.Min(halfAnimationWidth, this.bounds.Right - this.animationLeft),
                        this.bounds.Height);
                    pe.Graphics.FillRectangle(
                        rightBrush,
                        this.animationLeft + halfAnimationWidth,
                        this.bounds.Top,
                        Math.Min(halfAnimationWidth, this.bounds.Right - this.animationLeft - halfAnimationWidth),
                        this.bounds.Height);
                }
            }

            var borderBrush = new SolidBrush(this.BorderColor);

            pe.Graphics.FillRectangle(borderBrush, 0, 0, this.borderSize.Left, this.Height);
            pe.Graphics.FillRectangle(borderBrush, 0, 0, this.Width, this.RealBorderSize.Top);
            pe.Graphics.FillRectangle(
                borderBrush,
                this.Width - this.borderSize.Right,
                0,
                this.borderSize.Right,
                this.Height);
            pe.Graphics.FillRectangle(
                borderBrush,
                0,
                this.Height - this.borderSize.Bottom,
                this.Width,
                this.RealBorderSize.Bottom);
        }

        private void SetAnimationPosition()
        {
            Task.Run(
                () =>
                    {
                        while (this.Visible && this.animationEnable)
                        {
                            lock (this)
                            {
                                Thread.Sleep(100 / this.animationSpeed);

                                this.animationLeft++;
                                if (this.animationLeft > this.bounds.Right)
                                {
                                    this.animationLeft = this.RealBorderSize.Left - this.AnimationWidth;
                                    Thread.Sleep(1000);
                                    continue;
                                }

                                this.Invalidate();
                            }
                        }
                    });
        }
    }
}