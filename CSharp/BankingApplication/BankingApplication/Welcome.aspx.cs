using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingApplication
{
    public partial class Welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from users where isApproved = 'n'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                TableRow row = new TableRow();
                TableCell usernameCell = new TableCell();
                usernameCell.Text = reader.GetString(0);
                TableCell isApprovedCell = new TableCell();

                Button btn = new Button();
                btn.ID = usernameCell.Text;
                btn.Text = "Approve";
                btn.Click += Btn_Click;
                
                isApprovedCell.Controls.Add(btn);

                row.Cells.Add(usernameCell);
                row.Cells.Add(isApprovedCell);

                table1.Rows.Add(row);
            }
            
            conn.Close();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=AutoLot;Integrated Security=True");
            conn.Open();

            SqlCommand cmd = new SqlCommand(string.Format("update users set isApproved = '{0}' where username = '{1}'", 'y', btn.ID), conn);
            cmd.ExecuteNonQuery();
            btn.Enabled = false;
            conn.Close();
        }
    }
}