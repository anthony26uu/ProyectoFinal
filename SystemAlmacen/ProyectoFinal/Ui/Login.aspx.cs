using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoFinal
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           // FormsAuthentication.RedirectFromLoginPage("Anthony", true);

           

        }



        protected void Button3_Click1(object sender, EventArgs e)
        {


        }

        protected void Inicio_Click(object sender, EventArgs e)
        {

            if (BLL.UserBLL.Authenticate(Textid.Text, TextPass.Text) == false)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "scripts", "<script>alert('Campos Incorrectos');</script>");


            }
            else
            {
                FormsAuthentication.RedirectFromLoginPage("Anthony", true);


            }
        }


    }


}