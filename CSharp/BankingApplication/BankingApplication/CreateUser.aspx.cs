using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");
            conn.Open();
            
                 
            SqlCommand cmd = new SqlCommand(string.Format("insert into users(username, password, type, isApproved) values('{0}', '{1}', '{2}', '{3}')",
                txtUsername.Text,
                txtPassword1.Text,
                userType.SelectedValue,
                'n'), conn);

            cmd.ExecuteNonQuery();
            conn.Close();
            Session["usertype"] = userType.SelectedValue;
            Response.Redirect("~/Default.aspx");
        }
    }
}