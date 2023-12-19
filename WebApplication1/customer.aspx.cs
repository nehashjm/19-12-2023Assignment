using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                Lbltxt.Visible = true;
                Lbltxt.Text = "welcome"+TxtName.Text;
                Lbltxt.Text += "your email" + TxtEmail.Text;
                Lbltxt.Text += "your mobile" + TextMobile.Text;
                Lbltxt.Text += "your password " + TxtPaswd.Text;
                
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var input = TxtName.Text;
            args.IsValid = (input.Length > 5);
        }
    }
}