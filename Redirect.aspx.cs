using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormDisplay
{
    public partial class Redirect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string name = Session["USERNAME"].ToString();
                string email = Session["EMAIL"].ToString();
                string address = Session["ADDRESS"].ToString();

                Label1.Text = name;
                Label2.Text = email;
                Label3.Text = address;
            }
            catch(Exception ex) { 
            
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }
    }
}