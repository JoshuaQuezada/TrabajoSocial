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
    public partial class UsuarioAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cls_Utilitarios Util = new Cls_Utilitarios();
            if (!IsPostBack)
            {
                if (Session["Codigo_Usuario"] != null)
                {
                    btnEditar.Visible = true;
                    btnguardar.Visible = false;

                    int Id = int.Parse(Session["Codigo_Usuario"].ToString());
                    DataSet ds = new DataSet();
                    ds = Util.Obtenerds("SELECT Usu_Id, Usu_Username, Usu_Contraseña FROM tbUsuario WHERE Usu_Id = " + Id + "", "T");
                    txtUsername.Value = ds.Tables["T"].Rows[0]["Usu_Username"].ToString();
                    txtContraseña.Value = ds.Tables["T"].Rows[0]["Usu_Contraseña"].ToString();
                }
                else
                {
                    btnEditar.Visible = false;
                    btnguardar.Visible = true;
                }
            }
        }

        protected void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Usuarios Usu = new Cls_Usuarios();
                string sNombre = txtUsername.Value;
                string sContraseña = txtContraseña.Value;
                if (sNombre == " ")
                {
                    msjErrorUsuario.Visible = true;
                }
                else if (sContraseña == " ")
                {
                    msjErrorContraseña.Visible = true;
                }
                else
                {
                    Usu.InsertarRegistro(sNombre, sContraseña);
                    Response.Redirect("UsuarioIndex.aspx");
                }
            }
            catch 
            { 
            
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Usuarios Usu = new Cls_Usuarios();
                string sUsername = txtUsername.Value;
                string sPassword = txtContraseña.Value;
                int Id_Usuario = int.Parse(Session["Codigo_Usuario"].ToString());

                if (sUsername == " ")
                {
                    msjErrorUsuario.Visible = true;
                }
                else if (sPassword == " ")
                {
                    msjErrorContraseña.Visible = true;
                }
                else
                {
                    Usu.EditarRegistro(sUsername, sPassword, Id_Usuario);
                    Response.Redirect("UsuarioIndex.aspx");
                    Session["Codigo_Usuario"] = null;
                }
            }
            catch 
            {
            
            }
            Session["Codigo_Usuario"] = null;
        }
    }
}