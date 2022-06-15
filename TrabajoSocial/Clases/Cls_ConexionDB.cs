using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;

namespace TrabajoSocial.Clases
{
    public class Cls_ConexionDB
    {
        TRABAJO_SOCIALEntities1 TS = new TRABAJO_SOCIALEntities1();
        SqlConnection Conexionsql = new SqlConnection();

        public SqlConnection ObtenerConexion()
        {
            string sConexion = ConfigurationManager.ConnectionStrings["TRABAJO_SOCIALEntities1"].ToString();
            string sProvider = new EntityConnectionStringBuilder(sConexion).ProviderConnectionString;
            SqlConnection Conexion = new SqlConnection(sProvider);
            
            return Conexion;
        }
    }
}