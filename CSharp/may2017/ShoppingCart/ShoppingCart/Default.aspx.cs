using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingCart
{
    public partial class _Default : System.Web.UI.Page
    {
        public HttpCookie cookie;
            
        protected void Page_Load(object sender, EventArgs e)
        {
        //    cookie = new HttpCookie("cart");
        //    cookie.Values.Add("Tables", "0");
        //    cookie.Values.Add("Chair", "0");
        //    cookie.Values.Add("Bottles", "0");

        //    Response.Cookies.Add(cookie);
        }

        protected void AddToCart(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["cart"];

            Button btn = (Button)sender;

            string id = btn.ID;

            if (id == "btnTable")
            {
                int amt = Int32.Parse(cookie.Values.Get("Tables"));
                amt++;
                cookie.Values.Set("Tables", amt.ToString());
            }

            if (id == "btnChair")
            {
                int amt = Int32.Parse(cookie.Values.Get("Chair"));
                amt++;
                cookie.Values.Set("Chair", amt.ToString());
            }

            if (id == "btnBottle")
            {
                int amt = Int32.Parse(cookie.Values.Get("Bottles"));
                amt++;
                cookie.Values.Set("Bottles", amt.ToString());
            }

            Response.Cookies.Add(cookie);
        }
    }
}