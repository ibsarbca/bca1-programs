using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HitCounter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int hitcounter = Convert.ToInt32(Application["hitcounter"]);
            hitcounter++;
            Application["hitcounter"] = hitcounter;
        }
    }
}