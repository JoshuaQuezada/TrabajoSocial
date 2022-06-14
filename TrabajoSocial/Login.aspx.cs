using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrabajoSocial.Clases;

namespace TrabajoSocial
{
    public partial class Login : System.Web.UI.Page
    {
        Cls_Utilitarios util = new Cls_Utilitarios ();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string sUsername = txtUsername.Value;
            string sPassword = txtPassword.Value;
            ds = util.Obtenerds("SELECT COUNT(*) AS DATO FROM tbUsuario WHERE Usu_UserName = '" + sUsername + "' AND Usu_Password = '" + sPassword + "'", "T");
            string sConteo = ds.Tables["T"].Rows[0]["Dato"].ToString();

            if (sUsername.Contains("'") && sPassword.Contains("'") || sUsername.Contains("or") && sPassword.Contains("or") || sUsername.Contains("OR") && sPassword.Contains("OR"))
            {
                Error.Visible = true;
            }
            else if (sConteo == "0")
            {
                Error.Visible = true;
            }
            else
            {
                Error.Visible = false;
                ds = util.Obtenerds("SELECT Usu_UserName FROM tbUsuario WHERE Usu_UserName = '" + sUsername + "' AND Usu_Password = '" + sPassword + "'", "Nombres");
                Session["UserName"] = ds.Tables["Nombres"].Rows[0]["Usu_UserName"].ToString();
            }

            Response.Redirect("Index.aspx");
        }
    }
}