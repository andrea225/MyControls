using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYL
{
    public partial class MyCanvas : Panel
    {
        private Action<Graphics> draw;

        public MyCanvas()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        public void Render(Action<Graphics> Draw)
        {
            this.draw = Draw;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            this.draw?.Invoke(pe.Graphics);
        }
    }
}
