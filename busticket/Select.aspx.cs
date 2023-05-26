using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace busticket
{
    public partial class Select : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void bookBtn_Click(object sender, EventArgs e)
        {
            string from = ufrom.Text;
            string to = uto.Text;
            string date = Convert.ToString(dt.Value);
            Response.Redirect($"Results.aspx?from={from}&to={to}&date={date}");
           
        }

    }
    }
