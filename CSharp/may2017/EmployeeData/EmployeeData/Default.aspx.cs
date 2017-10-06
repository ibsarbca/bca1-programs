using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace EmployeeData
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;Pooling=False");
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO emp VALUES('" + txtPAN.Text + "', '" + txtName.Text + "', '" + txtAddress.Text + "');", conn);
            cmd.ExecuteNonQuery();
            conn.Close();

            Response.Redirect("Page2.aspx");
        }
    }
}