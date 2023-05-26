using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class signup : System.Web.UI.Page
    {
        string source = @"data source=LAPTOP-29V8QTU2\SQLEXPRESS;initial catalog=ecobus;integrated security=sspi";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
           string name= susername.Text;
            string email = semail.Text;
            string password = spassword.Text;
            using (SqlConnection s = new SqlConnection(source))
            {
                s.Open();
                string q = $"insert into Users(Username,Password,email) values('{name}','{password}','{email}')";
                using (SqlCommand cmd = new SqlCommand(q, s))
                {
                    cmd.ExecuteNonQuery();
                    Response.Redirect("success.aspx");
                }
                s.Close();
            }
        }
    }
}