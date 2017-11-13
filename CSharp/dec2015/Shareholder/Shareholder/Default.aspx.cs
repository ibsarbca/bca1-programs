using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Shareholder
{
    public partial class _Default : System.Web.UI.Page
    {
        public DataSet DS;
        protected void Page_Load(object sender, EventArgs e)
        {
            DS = new DataSet("DS");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=shareholder;Integrated Security=True;Pooling=False");

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM shareholder", conn);
            adapter.Fill(DS);

            SqlCommandBuilder builer = new SqlCommandBuilder(adapter);
            
            DataTable table = DS.Tables[0];
            DataRow row = table.NewRow();

            row["hname"] = txtName.Text;
            row["address"] = txtAddress.Text;
            row["no_of_shares"] = txtShares.Text;
            row["share_serial_no_start"] = txtShareSrStart.Text;
            row["share_serial_no_end"] = txtShareSrEnd.Text;

            table.Rows.Add(row);

            adapter.InsertCommand = builer.GetInsertCommand();
            adapter.Update(DS);

            GridView1.DataSource = DS;
            GridView1.DataBind();
        }
    }
}