using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.ShowInTaskbar = false;

            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //this.BackColor = Color.FromArgb(50, 255, 255, 255);
            this.Opacity = 0.5;
            this.TransparencyKey = Color.White;
            this.BackColor = Color.White;
            this.progressBar1.Style = ProgressBarStyle.Marquee;
            

        }
    }
}
