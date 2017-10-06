using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace CustomerDetails
{
    public partial class _Default : System.Web.UI.Page
    {
        DataSet DS { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            DS = new DataSet("DS");
        }

        protected void btnSpecificDate_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=custdetails;Integrated Security=True;Pooling=False");
            conn.Open();

            DateTime date = DateTime.ParseExact(txtSpecificDate.Text, "dd/MM/yyyy", null);
            string cmd = "SELECT * FROM customer_order WHERE order_date='" + date.ToString("yyyy-MM-dd") + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(DS);

            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();
        }

        protected void btnDateRange_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=custdetails;Integrated Security=True;Pooling=False");
            conn.Open();

            DateTime startDate = DateTime.ParseExact(txtStartDate.Text, "dd/MM/yyyy", null);
            DateTime endDate = DateTime.ParseExact(txtEndDate.Text, "dd/MM/yyyy", null);

            string cmd = "SELECT * FROM customer_order WHERE order_date>='" + startDate.ToString("yyyy-MM-dd") + "' and order_date <= '" + endDate.ToString("yyyy-MM-dd") + "'" ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(DS);

            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();
        }

        protected void btnProductNo_Click(object sender, EventArgs e)
        {

            GridView1.DataSource = null;
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=custdetails;Integrated Security=True;Pooling=False");
            conn.Open();

            string cmd = "SELECT * FROM customer_order WHERE product_no ='" + txtProductNo.Text+ "'";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd, conn);
            adapter.Fill(DS);

            GridView1.DataSource = DS.Tables[0];
            GridView1.DataBind();
        }
    }
}