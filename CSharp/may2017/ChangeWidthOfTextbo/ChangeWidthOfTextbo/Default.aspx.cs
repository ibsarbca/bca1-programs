using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChangeWidthOfTextbo
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Width = Unit.Parse("30");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int width = (int)TextBox1.Width.Value;

            width += 10;
            TextBox1.Width = Unit.Parse(width.ToString());
        }
    }
}