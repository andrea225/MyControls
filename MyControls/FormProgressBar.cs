namespace HYL
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    using HYLControlLibrary;

    public partial class FormProgressBar : Form
    {
        public FormProgressBar()
        {
            this.InitializeComponent();
            this.ShowInTaskbar = false;
            this.CenterProgressBar();
        }

        public new string Text
        {
            get => this.label1.Text;
            set
            {
                Action action = () => { this.label1.Text = value; };

                if (this.label1.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action.Invoke();
                }
            }
        }

        public int Value
        {
            get => this.progressBarX1.Value;
            set
            {
                Action action = () => { this.progressBarX1.Value = value; };

                if (this.progressBarX1.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action.Invoke();
                }
            }
        }

        public int Maximum
        {
            get => this.progressBarX1.Maximum;
            set
            {
                Action action = () => { this.progressBarX1.Maximum = value; };

                if (this.progressBarX1.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action.Invoke();
                }
            }
        }

        public int Minimum
        {
            get => this.progressBarX1.Minimum;
            set
            {
                Action action = () => { this.progressBarX1.Minimum = value; };

                if (this.progressBarX1.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action.Invoke();
                }
            }
        }

        public Color ProgressBarColor
        {
            get => this.progressBarX1.ForeColor;
            set
            {
                {
                    Action action = () => { this.progressBarX1.ForeColor = value; };

                    if (this.progressBarX1.InvokeRequired)
                    {
                        this.Invoke(action);
                    }
                    else
                    {
                        action.Invoke();
                    }
                }
            }
        }

        public ProgressBarStyleX Style
        {
            get => this.progressBarX1.Style;
            set
            {
                {
                    Action action = () => { this.progressBarX1.Style = value; };

                    if (this.progressBarX1.InvokeRequired)
                    {
                        this.Invoke(action);
                    }
                    else
                    {
                        action.Invoke();
                    }
                }
            }
        }

        public Color ProgressBarBackColor
        {
            get => this.progressBarX1.BackColor;
            set
            {
                {
                    Action action = () => { this.progressBarX1.BackColor = value; };

                    if (this.InvokeRequired)
                    {
                        this.Invoke(action);
                    }
                    else
                    {
                        action.Invoke();
                    }
                }
            }
        }


        private void CenterProgressBar()
        {
            Point location = new Point(
                (this.Width - this.progressBarX1.Width) / 2,
                (this.Height - this.progressBarX1.Height) / 2); // 居中
            this.progressBarX1.Location = location;
            this.label1.Location = new Point(location.X - 10, location.Y - 30);
        }

        private void FormProgressBar_SizeChanged(object sender, EventArgs e)
        {
            this.CenterProgressBar();
        }

        private void progressBar1_SizeChanged(object sender, EventArgs e)
        {
            this.CenterProgressBar();
        }
    }
}