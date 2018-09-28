using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.dataGridView1.Rows.Add(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pager1.ReportPageChangeOnInit = false;
            this.pager1.PageChanged += Pager1_PageChanged;
            this.pager1.Init(105);


            //Form2 f = new Form2();
            //f.ShowDialog(this);

            //Task.Run(
            //    () =>
            //        {
            //            while (true)
            //            {
            //                System.Threading.Thread.Sleep(500);

            //                var value = this.progressBarX2.Value;
            //                value++;
            //                if (value >= this.progressBarX2.Maximum)
            //                {
            //                    value = 1;
            //                }

            //                this.progressBarX2.Value = value;
            //            }
            //        });
        }

        private void Pager1_PageChanged(object sender, HYL.PageChangedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.progressBarX1.Show();

            Task.Run(
                () =>
                    {
                        while (true)
                        {
                            System.Threading.Thread.Sleep(1 * 1000);

                            this.progressBarX1.PerformStep();

                            //this.customControl11.Text = DateTime.Now.ToString();
                            //this.progressBarX1.Value = DateTime.Now.Second;
                            //if (DateTime.Now.Second % 20 == 0)
                            //{
                            //    this.progressBarX1.AnimationEnable = !this.progressBarX1.AnimationEnable;
                            //}


                            Action action1 = () =>
                                {
                                    this.progressBar1.Value = DateTime.Now.Second;
                                    this.button2.Text = DateTime.Now.Second.ToString();
                                };

                            this.Invoke(action1);


                            //if (DateTime.Now.Second % 20 == 0)
                            //{
                            //    Action action = () =>
                            //        {
                            //            this.progressBarX1.Hide();
                            //        };

                            //    this.progressBarX1.Invoke(action);
                            //    break;
                            //}
                        }
                    });

            //this.maskPanel21.ShowMask();
            //this.progressPanel1.BackColor = Color.Aquamarine;
            //this.progressPanel1.Style = ProgressBarStyle.Marquee;
            //this.progressPanel1.Show();

            //this.maskPanel21.Value = 50;
            //this.maskPanel21.Text = "sdkjfha";

            //Task.Run(
            //    () =>
            //        {
            //            while (true)
            //            {
            //                System.Threading.Thread.Sleep(1 * 1000);
            //                this.progressPanel1.Text = DateTime.Now.ToString();
            //                this.progressPanel1.Value = DateTime.Now.Second;

            //                if (DateTime.Now.Second % 20 == 0)
            //                {
            //                    this.progressPanel1.Hide();
            //                    break;
            //                }
            //            }
            //        });

            ////this.maskPanel21.ProgressBar.Style = ProgressBarStyle.Marquee;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pager1.Init(1);
        }
        
    }
}
