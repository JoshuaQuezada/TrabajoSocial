using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrabajoSocial.Clases
{
    public class Cls_Usuarios
    {
        TRABAJO_SOCIALEntities TRABAJO_SOCIALEntities = new TRABAJO_SOCIALEntities ();
        tbUsuario Usuario = new tbUsuario ();

        public void InsertarRegistro(string sNombre, string sContraseña)
        {
            TRABAJO_SOCIALEntities.PA_InsertarUsuario(sNombre, sContraseña);
        }
    }
}