using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string source = @"data source=LAPTOP-29V8QTU2\SQLEXPRESS;initial catalog=ecobus;integrated security=sspi";
    
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            using (SqlConnection s = new SqlConnection(source))
            {
                s.Open();
                string q = $"select * from Users where Username='{username}' and Password='{password}'";
                using (SqlCommand cmd = new SqlCommand(q, s))
                {
                    
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            Response.Redirect($"select.aspx");
                        }
                    }
                }
            }
        }

        protected void btn_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("signup.aspx");
        }

    }
}



