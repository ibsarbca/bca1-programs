using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AddRemoveList
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedItem == null)
                return;

            string item = ListBox1.SelectedItem.ToString();
            ListBox1.Items.Remove(ListBox1.SelectedItem);
            ListBox2.Items.Add(item);
        }

        protected void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (ListBox2.SelectedItem == null)
                return;
            string item = ListBox2.SelectedItem.ToString();
            ListBox2.Items.Remove(ListBox2.SelectedItem);
            ListBox1.Items.Add(item);
        }
    }
}