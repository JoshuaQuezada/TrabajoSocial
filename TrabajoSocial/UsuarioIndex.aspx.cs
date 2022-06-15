using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrabajoSocial.Clases;

namespace TrabajoSocial
{
    public partial class UsuarioIndex : System.Web.UI.Page
    {
        Cls_Utilitarios utilitarios = new Cls_Utilitarios();
        DataSet ds = new DataSet ();

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Codigo_Usuario"] = null;
            if (!IsPostBack)
            {
                ListarTabla();
            }
            else
            {
                string EventTarget = Request["__EVENTTARGET"];
                string x = Request["__EVENTARGUMENT"];
                if ((EventTarget != null) && (EventTarget == "Editar"))
                {
                    Editar(x);
                }
            }
        }

        public void ListarTabla()
        {
            ds = utilitarios.Obtenerds("SELECT Id_Usuario, Nombre_Usuario FROM VW_tbUsuarios", "T");
            StringBuilder html = new StringBuilder ();

            Literal msj = new Literal ();
            foreach (DataRow row in ds.Tables["T"].Rows)
            {
                html.Append(
                    "<tr>" +
                    "<td>" + row["Id_Usuario"] + "</td>" +
                    "<td>" + row["Nombre_Usuario"] + "</td>" +
                    "<td><a href='#' class='btn btn-info' Onclick='Editar(\"" + row["Id_Usuario"] + "\");'><i class='fas fa-edit'></i></a></td>" +
                    "</tr>"
                    );
            }
            msj.Text = html.ToString();
            TablaUsuario.Controls.Add(msj);
        }

        public void Editar(string id)
        {
            Session["Codigo_Usuario"] = id;
            Response.Redirect("UsuarioAdmin.aspx");
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuarioAdmin.aspx");
        }
    }
}