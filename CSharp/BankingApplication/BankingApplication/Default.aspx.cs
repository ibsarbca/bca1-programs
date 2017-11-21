using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Default : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UserLogin_Authenticate(object sender, AuthenticateEventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("Select * from users where username = '{0}' and password = '{1}'", txtUsername, txtPassword), conn);
            
        }

        protected void UserLogin_LoginError(object sender, EventArgs e)
        {
            lblFail.Text = "FAIL";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("Select * from users where username = '{0}' and password = '{1}'", txtUsername.Text, txtPassword.Text), conn);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 0)
            {
                lblFail.Text = "Login Failed.";
            }
            else
            {
                string usertype = (String)table.Rows[0][3]; // [3] being usertype
                Session["usertype"] = usertype;
                Response.Redirect("~/Welcome.aspx");
            }
        }
    }
}