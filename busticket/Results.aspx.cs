using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class Results : System.Web.UI.Page
    {
    string connection = @"data source=LAPTOP-29V8QTU2\SQLEXPRESS;initial catalog = ecobus; integrated security = sspi";
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string from = Request.QueryString["from"];
            string to = Request.QueryString["to"];
            string date = Request.QueryString["date"];
          
            using (SqlConnection s = new SqlConnection(connection))
            {
                s.Open();
                string q = $"select * from searchresultsf where fromc='{from}' and toc='{to}' and tdate='{date}'";

                using (SqlCommand cmd = new SqlCommand(q, s))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                    {
                      
                            
                            string busname = dr["busname"].ToString();
                          string start=dr["fromc"].ToString();
                            string destination=dr["toc"].ToString();
                            string busnumber=dr["busno"].ToString();
                            string timings=dr["timings"].ToString();
                            Response.Write("<table border=1> <tr> <th>Busname</th><th>from</th> <th>destination</th> <th>busnumber</th> <th>bustimings</th><th>book</th> </tr>");
                            Response.Write($"<tr><td>{busname}</td><td>{start}</td><td>{destination}</td> <td>{busnumber}</td> <td>{timings}</td><td><a href='seatbooking.aspx?id={busnumber}&busname={busname}'>Book</a> </tr></table>");

                        }
                   
                    }
                    else
                    {
                        Response.Redirect("noresults.aspx");
                    }
                    dr.Close();

                }
                s.Close();
            }
        }
        
    }
    
}