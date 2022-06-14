using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TrabajoSocial.Clases
{
    public class Cls_Utilitarios
    {
        SqlConnection con = new SqlConnection();
        Cls_ConexionDB DB = new Cls_ConexionDB();

        public DataSet Obtenerds(string squery, string Table)
        {
            con = DB.ObtenerConexion();
            DataSet dsObtenerDataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(squery, con);

            dataAdapter.Fill(dsObtenerDataSet, Table);
            con.Close();

            return dsObtenerDataSet;
        }
    }
}