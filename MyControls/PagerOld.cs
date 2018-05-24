// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pager.cs" company="hyl">
//   黄云龙
// </copyright>
// <summary>
//   分页控件
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HYL
{
    using System;
    using System.Windows.Forms;

    public partial class PagerOld : UserControl
    {

        #region 页码变化触发事件

        // public event Action<PagerEventArgs> OnPageChanged;
        public event Action OnPageChanged;

        #endregion

        #region 分页字段和属性

        private int pageIndex = 1;

        /// <summary>
        /// 当前页面
        /// </summary>
        public virtual int PageIndex
        {
            get => this.pageIndex < 1 ? 1 : this.pageIndex;
            set => this.pageIndex = value;
        }

        private int pageSize = 20;

        /// <summary>
        /// 每页记录数
        /// </summary>
        public virtual int PageSize
        {
            get => this.pageSize;
            set => this.pageSize = value;
        }

        private int recordCount = 0;

        /// <summary>
        /// 总记录数
        /// </summary>
        public virtual int RecordCount
        {
            get => this.recordCount;
            set => this.recordCount = value;
        }

        private int pageCount = 0;

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (this.pageSize != 0)
                {
                    this.pageCount = this.GetPageCount();
                }

                return this.pageCount;
            }
        }


        #endregion

        public PagerOld()
        {
            this.InitializeComponent();
            this.cbbPageSize.SelectedIndex = 2;
        }


        #region 分页及相关事件功能实现

        private void SetFormCtrEnabled()
        {
            this.btnFirst.Enabled = true;
            this.btnPrev.Enabled = true;
            this.btnNext.Enabled = true;
            this.btnLast.Enabled = true;
            this.txtPageIndex.Enabled = true;
        }

        /// <summary>
        /// 计算总页数
        /// </summary>
        /// <returns></returns>
        private int GetPageCount()
        {
            if (this.PageSize == 0)
            {
                return 0;
            }

            int pageCount = this.RecordCount / this.PageSize;
            if (this.RecordCount % this.PageSize == 0)
            {
                pageCount = this.RecordCount / this.PageSize;
            }
            else
            {
                pageCount = this.RecordCount / this.PageSize + 1;
            }

            return pageCount;
        }

        /// <summary>
        /// 外部调用
        /// </summary>
        public void Bind(int count)
        {
            this.recordCount = count;
            this.DrawControl(false);
        }

        /// <summary>
        /// 页面控件呈现
        /// </summary>
        private void DrawControl(bool callEvent)
        {
            this.txtPageIndex.Text = this.PageIndex.ToString();
            this.lbPageCount.Text = this.PageCount.ToString();
            this.lbTotalCount.Text = this.RecordCount.ToString();

            // todo
            // this.cbbPageSize.Text = PageSize.ToString();
            if (callEvent)
            {
                // this.OnPageChanged?.Invoke(new PagerEventArgs(new PageInfo
                // {
                // PageCount = this.PageCount,
                // PageIndex = this.PageIndex,
                // PageSize = this.PageSize,
                // TotalCount = this.RecordCount

                // }));
                this.OnPageChanged?.Invoke();
            }

            this.SetFormCtrEnabled();

            if (this.PageCount <= 1)
            {
                // 有且仅有一页
                this.btnFirst.Enabled = false;
                this.btnPrev.Enabled = false;
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
                this.txtPageIndex.Enabled = false;
            }
            else if (this.PageIndex == 1)
            {
                // 第一页
                this.btnFirst.Enabled = false;
                this.btnPrev.Enabled = false;
            }
            else if (this.PageIndex == this.PageCount)
            {
                // 最后一页
                this.btnNext.Enabled = false;
                this.btnLast.Enabled = false;
            }
        }

        #endregion

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.PageIndex = 1;
            this.DrawControl(true);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.PageIndex = Math.Max(1, this.PageIndex - 1);
            this.DrawControl(true);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.PageIndex = Math.Min(this.PageCount, this.PageIndex + 1);
            this.DrawControl(true);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.PageIndex = this.PageCount;
            this.DrawControl(true);
        }

        private void cbbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PageSize = Convert.ToInt32(this.cbbPageSize.SelectedItem.ToString());
            this.btnFirst_Click(null, null);

            // DrawControl(true);
        }

        private void txtPageIndex_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int num = 0;
                if (int.TryParse(this.txtPageIndex.Text.Trim(), out num) && num > 0)
                {
                    if (num > this.PageCount)
                    {
                        this.txtPageIndex.Text = this.PageCount.ToString();
                        this.PageIndex = this.PageCount;
                    }
                    else
                    {
                        this.PageIndex = num;
                    }

                    this.DrawControl(true);
                }
            }
        }
    }

    // public class PagerEventArgs : EventArgs
    // {
    // public PageInfo PageInfo { get; }

    // public PagerEventArgs(PageInfo pageInfo)
    // {
    // this.PageInfo = pageInfo;
    // }
    // }

    // public class PageInfo
    // {
    // public int PageSize { get; set; }

    // public int PageIndex { get; set; }

    // public int PageCount { get; set; }

    // public int TotalCount { get; set; }
    // }
}