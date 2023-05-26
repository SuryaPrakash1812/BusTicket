using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class seatbooking : System.Web.UI.Page
    {
      
        string connection = @"data source=LAPTOP-29V8QTU2\SQLEXPRESS;initial catalog = ecobus; integrated security = sspi";

        protected void Page_Load(object sender, EventArgs e)
        {
            string busname = Request.QueryString["busname"];

            string busnumber = Request.QueryString["id"];
            using (SqlConnection s = new SqlConnection(connection))
            {
                s.Open();
                string q = $"select * from searchresultsf where busno='{busnumber}'";

                using (SqlCommand cmd = new SqlCommand(q, s))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr.HasRows)
                        {
                            Response.Write("<table> <tr> <th>a1</th> <th>a2</th> <th>a3</th> <th>b1</th><th>b2</th><th>b3</th><th>c1</th><th>c2</th><th>c3</th></tr>");
                            string a1 = dr["Seata1"].ToString();
                            
                            if (a1.Equals("empty"))
                            {

                                string seatnumber = "Seata1";
                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}&busname={busname}>book<a></td>");
                                
                            }
                            else
                            {
                                Response.Write("<td>booked</td>");
                            }
                            string a2 = dr["Seata2"].ToString();
                            if (a2.Equals("empty"))
                            {
                                string seatnumber = "Seata2";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}&seatnumberu={seatnumber}'>book<a></td>");

                            }
                            else
                            {
                                Response.Write("<td>booked</td>");


                            }
                            string a3 = dr["Seata3"].ToString();
                            if (a3.Equals("empty"))
                            {
                                string seatnumber = "Seata3";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");
                                Response.Write("<br>");


                            }
                            else
                            {

                                Response.Write("<td>booked</td>");
                                Response.Write("<br>");

                            }
                           
                            string b1 = dr["Seatb1"].ToString();
                            if (b1.Equals("empty"))
                            {
                                string seatnumber = "Seatb1";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");

                            }
                            else
                            {
                                Response.Write("<td>booked</td>");

                            }
                            string b2 = dr["Seatb2"].ToString();
                            if (b2.Equals("empty"))
                            {
                                string seatnumber = "Seatb2";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");

                            }
                            else
                            {
                                Response.Write("<td>booked</td>");

                            }
                            string b3 = dr["Seatb3"].ToString();
                            if (b3.Equals("empty"))
                            {
                                string seatnumber = "Seatb3";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");
                                Response.Write("<br>");


                            }
                            else
                            {
                                Response.Write("<td>booked</td>");
                                Response.Write("<br>");


                            }
                            
                            string c1 = dr["Seatc1"].ToString();
                            if (c1.Equals("empty"))
                            {
                                string seatnumber = "Seatc1";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");



                            }
                            else
                            {
                                Response.Write("<td>booked</td>");
                            }
                            string c2 = dr["Seatc2"].ToString();
                            if (c2.Equals("empty"))
                            {
                                string seatnumber = "Seatc2";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");

                            }
                            else
                            {
                                Response.Write("<td>booked</td>");

                            }
                            string c3 = dr["Seatc3"].ToString();
                            if (c3.Equals("empty"))
                            {
                                string seatnumber = "Seatc3";

                                Response.Write($"<td><a href='confirmation.aspx?busno={busnumber}&seatnumber={seatnumber}'>book<a></td>");
                                Response.Write("<br>");


                            }
                            else
                            {
                                Response.Write("<td>booked</td>");
                                Response.Write("<br>");

                            }
                            Response.Write("</tr>");



                        }
                    }
                    dr.Close();

                }
                s.Close();
           
        }

        }

        protected void btn_Click(object sender, EventArgs e)
        {
           
            
          
        }
    }
}