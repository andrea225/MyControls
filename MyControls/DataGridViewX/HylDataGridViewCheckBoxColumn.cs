using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HYL.DataGridViewX
{
    using System.Windows.Forms;

    public class HylDataGridViewCheckBoxColumn : DataGridViewCheckBoxColumn
    {
        public HylDataGridViewCheckBoxColumn()
        {
            var headerCell = new HylDataGridViewCheckBoxHeaderCell();
            this.HeaderCell = headerCell;
            headerCell.OnCheck += this.HeaderCell_OnCheck;
        }

        private void HeaderCell_OnCheck(object sender, CheckedChangeArgs e)
        {
            var currentCell = this.DataGridView.CurrentCell;
            this.DataGridView.CurrentCell = null;
            foreach (DataGridViewRow row in this.DataGridView.Rows)
            {
                row.Cells[this.Index].Value = e.Checked;
            }

            this.DataGridView.CurrentCell = currentCell;
        }
    }
}
