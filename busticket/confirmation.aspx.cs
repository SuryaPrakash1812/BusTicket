using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class confirmation : System.Web.UI.Page
    {
        string seatnumber;
        string busnumber;
        string busname;
        string source = @"data source=LAPTOP-29V8QTU2\SQLEXPRESS;initial catalog=ecobus;integrated security=sspi";
        protected void Page_Load(object sender, EventArgs e)
        {
            string sno = Request.QueryString["seatnumber"].ToString();
            string bno = Request.QueryString["busno"].ToString();

            Response.Write($"<table border='1'> <tr><th>bus number={bno}</th> <th> seat number={sno}</th></tr></table>");
            Response.Write($"<h1></h1>");

        }


        protected void btnbook_Click(object sender, EventArgs e)
        {
            int count1;
            int count2;

            seatnumber = Request.QueryString["seatnumber"].ToString();
             busname =   seatnumber = Request.QueryString["seatnumber"].ToString();


            busnumber = Request.QueryString["busno"];
            string name=  passname.Text;
           long number= Convert.ToInt64(passnumber.Text);
            using (SqlConnection s = new SqlConnection(source))
            {
                s.Open();
                string details = $"insert into passengerdetails(name,number,seatnumber,busnumber,busname) values('{name}','{number}','{seatnumber}','{busnumber}','{busname}')";
                string update = $"update searchresultsf set {seatnumber}='booked' where busno='{busnumber}'";
                using (SqlCommand cmd = new SqlCommand(details, s))
                {
                   count1= cmd.ExecuteNonQuery();
                }

                using (SqlCommand cmd = new SqlCommand(update, s))
                {
                     count2 = cmd.ExecuteNonQuery();
                }
                if(count1>0 && count2>0)
                {
                    Response.Redirect("bookingsuccess.aspx");
                }
                s.Close();
            }
            
        }
    }
}