namespace HYL.DataGridViewX
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.Windows.Forms.VisualStyles;

    public class HylDataGridViewCheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        private CheckBoxState checkBoxState;

        private Point checkBoxLocation;

        private Size checkBoxSize;

        private Point cellLocation;

        public event EventHandler<CheckedChangeArgs> OnCheck;
        
        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates dataGridViewElementState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            base.Paint(
                graphics,
                clipBounds,
                cellBounds,
                rowIndex,
                dataGridViewElementState,
                value,
                null,
                errorText,
                cellStyle,
                advancedBorderStyle,
                paintParts);

            this.cellLocation = cellBounds.Location;

            var headerTextSize = graphics.MeasureString(this.OwningColumn.HeaderText, cellStyle.Font).ToSize();
            this.checkBoxSize = CheckBoxRenderer.GetGlyphSize(graphics, this.checkBoxState);
            var totalSize = new Size(
                headerTextSize.Width + this.checkBoxSize.Width,
                Math.Max(headerTextSize.Height, this.checkBoxSize.Height));

            this.checkBoxLocation = new Point
            {
                X = cellBounds.Location.X + (cellBounds.Width / 2) - (totalSize.Width / 2),
                Y = cellBounds.Location.Y + (cellBounds.Height / 2) - (totalSize.Height / 2)
            };

            var textRectangle = new Rectangle(
                new Point(
                    this.checkBoxLocation.X + this.checkBoxSize.Width,
                    this.checkBoxLocation.Y + (Math.Abs(this.checkBoxSize.Height - headerTextSize.Height) / 2)),
                headerTextSize);

            CheckBoxRenderer.DrawCheckBox(
                graphics,
                this.checkBoxLocation,
                textRectangle,
                this.OwningColumn.HeaderText,
                cellStyle.Font,
                false,
                this.checkBoxState);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            Point p = new Point(e.X + this.cellLocation.X, e.Y + this.cellLocation.Y);
            if (p.X >= this.checkBoxLocation.X && p.X <= this.checkBoxLocation.X + this.checkBoxSize.Width
                                               && p.Y >= this.checkBoxLocation.Y
                                               && p.Y <= this.checkBoxLocation.Y + this.checkBoxSize.Height)
            {
                this.checkBoxState = this.checkBoxState == CheckBoxState.CheckedNormal
                                         ? CheckBoxState.UncheckedNormal
                                         : CheckBoxState.CheckedNormal;

                this.OnCheck?.Invoke(
                    this.DataGridView,
                    new CheckedChangeArgs { Checked = this.checkBoxState == CheckBoxState.CheckedNormal });
                this.DataGridView.InvalidateCell(this);
            }

            base.OnMouseClick(e);
        }
    }
}