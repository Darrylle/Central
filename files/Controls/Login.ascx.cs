using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CentralCode;

namespace central.Controls
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
               /*
                * Dave: 
                * This code replaces commented 'if' code below.
                * pnlLogin   checks for result of session being null,
                * pnlWelcome checks for result of session NOT being null.
                * This isn't simply 'clever' coding; it replaces 4 references 
                * with 2, so if it changes - there are only 2 changes to be 
                * made rather than 4.
                * Delete all comments / code when you 'get' it, then COMMIT the
                * change, and we'll see if we're using GIT correctly ;-)
                */
                pnlLogin.Visible = Session["UserID"] == null;
                pnlWelcome.Visible = Session["UserID"] != null;
                /*
                if (Session["UserID"] == null)
                {
                    pnlLogin.Visible = true;
                    pnlWelcome.Visible = false;
                }
                else
                {
                    pnlLogin.Visible = false;
                    pnlWelcome.Visible = true;
                }*/
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            LoginUser usr = new LoginUser();
            string UserID = usr.Login(
                                txtUsername.Text,
                                txtPassword.Text);
            if(UserID == "")
            {
                lblError.Text = "Username / password not recognised. Please try again.";
            }
            else
            {
                Session.Add("UserID", UserID);                     //Store for later use.
                pnlLogin.Visible = false;
                pnlWelcome.Visible = true;
            }
        }
    }
}