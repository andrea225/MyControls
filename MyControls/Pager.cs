namespace HYL
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    public partial class Pager : UserControl
    {
        private bool inited = false;

        private int pageCount;

        private int pageIndex = 1;

        private int pageSize = 20;

        private int recordCount = 0;

        public Pager()
        {
            this.InitializeComponent();
        }

        [Category("Pager"), Description("在页码或每页显示条数发生改变时发生")]
        public event EventHandler<PageChangedEventArgs> PageChanged;


        /// <summary>
        /// 是否在初始化时触发PageChanged事件
        /// </summary>
        public bool ReportPageChangeOnInit { get; set; }

        private int PageCount
        {
            get => this.pageCount;
            set
            {
                this.pageCount = value;
                this.toolStripLabelPageCount.Text = value.ToString();
            }
        }

        private int PageIndex
        {
            get => this.pageIndex;
            set
            {
                this.pageIndex = value < 1 ? 1 : value;
                this.toolStripTextBoxPageIndex.Text = this.PageIndex.ToString();
                this.PageIndexChange();
                this.ReportPageChange();
            }
        }

        private int PageSize
        {
            get => this.pageSize;
            set
            {
                this.pageSize = value;
                this.toolStripComboBoxPageSize.Text = this.pageSize.ToString();
                this.CalculatePageCount();
                this.ReportPageChange();
            }
        }

        private int RecordCount
        {
            get => this.recordCount;
            set
            {
                this.recordCount = value < 0 ? 0 : value;
                this.toolStripLabelRecordCount.Text = this.recordCount.ToString();
                this.CalculatePageCount();
                this.ReportPageChange();
            }
        }

        /// <summary>
        /// 获取当前Pager信息。
        /// </summary>
        /// <returns>
        /// The <see cref="PagerInfo"/>.
        /// </returns>
        public PagerInfo GetPageInfo()
        {
            return new PagerInfo
                       {
                           PageCount = this.PageCount,
                           PageIndex = this.PageIndex,
                           PageSize = this.PageSize,
                           RecordCount = this.RecordCount
                       };
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="recordCount">
        /// 总条数
        /// </param>
        /// <param name="pageSize">
        /// 每页数量
        /// </param>
        /// <param name="pageIndex">
        /// 默认页码
        /// </param>
        public void Init(int recordCount, int pageSize = 20, int pageIndex = 1)
        {
            this.RecordCount = recordCount;
            this.PageSize = pageSize;
            this.CalculatePageCount();

            this.PageIndex = pageIndex > this.PageCount ? this.PageCount : pageIndex;
            this.PageIndexChange();
            this.inited = true;
            if (this.ReportPageChangeOnInit)
            {
                this.ReportPageChange();
            }
        }

        /// <summary>
        /// 设置可供选择的每页显示数量，默认为10 20 30 50 100
        /// </summary>
        /// <param name="list">
        /// The list.
        /// </param>
        public void SetPageSizeList(object[] items)
        {
            this.toolStripComboBoxPageSize.Items.Clear();
            this.toolStripComboBoxPageSize.Items.AddRange(items);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.PageIndex = 1;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.PageIndex = this.PageCount;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.PageIndex++;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.PageIndex--;
        }

        private void CalculatePageCount()
        {
            if (this.RecordCount == 0 || this.pageSize == 0)
            {
                this.PageCount = 0;
            }
            else
            {
                this.PageCount = (int)Math.Ceiling(Convert.ToDouble(this.RecordCount / (double)this.PageSize));
            }
        }

        private void PageIndexChange()
        {
            this.SetButtonEnable();
        }

        private void ReportPageChange()
        {
            if (this.inited && this.PageIndex <= Math.Ceiling(this.RecordCount / (double)this.PageSize))
            {
                this.PageChanged?.Invoke(this, new PageChangedEventArgs(this.pageSize, this.PageIndex));
            }
        }

        private void SetButtonEnable()
        {
            if (this.PageCount <= 1)
            {
                this.btnFirst.Enabled = false;
                this.btnPrev.Enabled = false;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
            else
            {
                if (this.PageIndex == 1)
                {
                    this.btnPrev.Enabled = false;
                    this.btnFirst.Enabled = false;
                    this.btnNext.Enabled = true;
                    this.btnLast.Enabled = true;
                }
                else if (this.PageIndex == this.PageCount)
                {
                    this.btnPrev.Enabled = true;
                    this.btnFirst.Enabled = true;
                    this.btnNext.Enabled = false;
                    this.btnLast.Enabled = false;
                }
                else
                {
                    this.btnPrev.Enabled = true;
                    this.btnFirst.Enabled = true;
                    this.btnNext.Enabled = true;
                    this.btnLast.Enabled = true;
                }
            }
        }

        private void toolStripComboBoxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.toolStrip1.Focus();
            if (this.toolStripComboBoxPageSize.Text == this.PageSize.ToString())
            {
                return;
            }

            this.PageSize = Convert.ToInt32(this.toolStripComboBoxPageSize.Text);
            if (this.PageIndex > this.PageCount)
            {
                this.PageIndex = this.PageCount;
                this.toolStripTextBoxPageIndex.Text = this.PageIndex.ToString();
            }
            else
            {
                this.SetButtonEnable();
            }
        }

        private void toolStripTextBoxPageIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(this.toolStripTextBoxPageIndex.Text.Trim(), out var num) && num > 0)
                {
                    if (num <= this.PageCount)
                    {
                        this.PageIndex = num;
                    }
                    else
                    {
                        this.PageIndex = this.PageCount;
                        this.toolStripTextBoxPageIndex.Text = this.PageCount.ToString();
                    }
                }
            }
        }

        private void toolStripTextBoxPageIndex_MouseUp(object sender, MouseEventArgs e)
        {
            this.toolStripTextBoxPageIndex.SelectAll();
        }

        public class PagerInfo
        {
            public int PageCount;

            public int PageIndex;

            public int PageSize;

            public int RecordCount;
        }
    }

    public class PageChangedEventArgs : EventArgs
    {
        public PageChangedEventArgs(int pageSize, int pageIndex)
        {
            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
        }

        public int PageIndex { get; }

        public int PageSize { get; }
    }
}