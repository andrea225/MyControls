using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    using System.Threading;

    using HYL;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pager1_OnPageChanged()
        {
            MessageBox.Show("Test");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.maskPanel1.Dock = DockStyle.Fill;
            this.maskPanel1.Show();
            await this.DoAsync();

            this.maskPanel1.Hide();
        }

        private void Do()
        {
            Thread.Sleep(2000);
        }

        private async Task DoAsync()
        {
            //return await Task.Run(() => { Do(); });
            await Task.Run(() => this.Do());
        }

        private void pager1_PageChanged(object sender, PageChangedEventArgs e)
        {
            this.textBox1.AppendText($"\r\nPageSize:{e.PageSize} PageIndex:{e.PageIndex}");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pager1.ReportPageChangeOnInit = true;
            //this.pager1.SetPageSizeList(new[] { 1, 2, 3 });
            this.pager1.Init(450, 50);
        }
    }
}
