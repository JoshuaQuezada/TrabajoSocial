using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoSocial.Clases
{
    public class Cls_Usuarios
    {
        TRABAJO_SOCIALEntities1 TRABAJO_SOCIALEntities = new TRABAJO_SOCIALEntities1 ();
        tbUsuario Usuario = new tbUsuario ();

        public void InsertarRegistro(string sNombre, string sContraseña)
        {
            TRABAJO_SOCIALEntities.PA_InsertarUsuario(sNombre, sContraseña);
        }

        public void EditarRegistro(string sNombre, string sContraseña, int Id)
        {
            TRABAJO_SOCIALEntities.PA_EditarUsuario(Id, sNombre, sContraseña);
        }
    }
}