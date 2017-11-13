using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TableRange
{
    public partial class _Default : System.Web.UI.Page
    {
        public List<int> range = new List<int>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGo_Click(object sender, EventArgs e)
        {
            int start = Int32.Parse(txtStart.Text);
            int end = Int32.Parse(txtEnd.Text);

            for (int i = start; i <= end; i++)
            {
                range.Add(i);
                TableCell cell = new TableCell();
                cell.Text = i.ToString();

                TableRow row = new TableRow();
                row.Cells.Add(cell);
                Table1.Rows.Add(row);
            }
        }
    }
}