using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmit(object sender, EventArgs e)
        {
            String email = TextBoxEmail.Text.ToLower();
            String password = TextBoxPassword.Text;
            if (email.Trim() != "" && password.Trim() != "")
            {
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                return;
            }
        }
    }       
}