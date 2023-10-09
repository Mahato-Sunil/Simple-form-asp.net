using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormDisplay
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String username = TextBox1.Text;
            String email = TextBox2.Text;
            String address = TextBox3.Text;

            // storig the items into the session 
            Session["USERNAME"] = username;
            Session["EMAIL"] = email;
            Session["ADDRESS"] = address;
            Response.Redirect("Redirect.aspx");
        }
    }
}