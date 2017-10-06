using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeData
{
    public partial class Page2 : System.Web.UI.Page
    {
        public DataSet ds { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DEFIANT\SQLEXPRESS;Initial Catalog=employee;Integrated Security=True;Pooling=False");
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM emp", conn);
            ds = new DataSet("emp");
            adapter.Fill(ds);

            
        }
    }
}