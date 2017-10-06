using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cookie
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("cookie", txtCookie.Text);
            Response.Cookies.Add(cookie);
        }
    }
}