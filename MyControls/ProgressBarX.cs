namespace HYL
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class ProgressBarX : UserControl
    {
        private int value;

        private int maximum = 100;

        public ProgressBarX()
        {
            this.InitializeComponent();
        }

        public Color Color
        {
            get => this.panel1.BackColor;
            set => this.panel1.BackColor = value;
        }
        
        public int Value
        {
            get => this.value;
            set => this.SetValue(value);
        }

        public int Maximum
        {
            get => maximum;
            set => maximum = value;
        }

        private void SetValue(int v)
        {
            this.value = v;
            this.panel1.Width = v * this.Width / this.maximum;
        }
    }
}