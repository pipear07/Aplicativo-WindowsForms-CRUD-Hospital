using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ObjetodeNegocios
{
   public class TipoDocumento
    {
        #region Propiedades
        decimal idTipoDocumento;
        public decimal IdTipoDocumento
        {
            get { return idTipoDocumento; }
            set { idTipoDocumento = value; }
        }
        string tipo_TI;
        public string Tipo_TI
        {
            get { return tipo_TI; }
            set { tipo_TI = value; }
        }
        #endregion
   
       #region Constructores
 public TipoDocumento()
 {
 }
 #endregion


        #region Metodos
 public DataTable Seleccionar()
 {
     DataTable dtTipos = new DataTable();
     Conexion objconexion = new Conexion();
     try
     {
         objconexion.conectar();
         SqlCommand cmd = new SqlCommand("proConsultarTipoDocumento", objconexion.Sqlconection);
         cmd.CommandType = CommandType.StoredProcedure;
         using (IDataReader dr = cmd.ExecuteReader())
         { dtTipos.Load(dr); }
         objconexion.desconectar();
     }
     catch (Exception exi) { }
     finally { objconexion.desconectar(); }
     return dtTipos;
 }       public void SeleccionarId()
 {
 Conexion objconexion = new Conexion();
 try
 {
 objconexion.conectar();
 SqlCommand cmd = new SqlCommand("proConsultaridTipoDocumento",
objconexion.Sqlconection);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("IdTipoDocumento", SqlDbType.SmallInt).Value =idTipoDocumento;
 IDataReader dr = cmd.ExecuteReader();
 while (dr.Read())
 {
     idTipoDocumento = Convert.ToByte(dr["IdTipoDocumento"]);
     tipo_TI = dr["Nombre"].ToString();
 }
 dr.Close();
 objconexion.desconectar();

 }
 catch (Exception exew) { }
 finally { objconexion.desconectar(); }
 }



       public bool Insertar()
       {
           bool resultado = false;
           Conexion objconexion = new Conexion();
           try
           {
               objconexion.conectar();
               SqlCommand cmd = new SqlCommand("proInsertarTipoDocumento",
              objconexion.Sqlconection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add("IdTiposIdentificacion",
              SqlDbType.SmallInt).Direction = ParameterDirection.Output;
               cmd.Parameters.Add("Tipo_TI", SqlDbType.VarChar).Value = tipo_TI;
               cmd.ExecuteNonQuery();
               idTipoDocumento = Convert.ToByte((cmd.Parameters["IdTipoDocumento"].Value).ToString());
               if (idTipoDocumento != 0)
               {
                   resultado = true;
               }
               objconexion.desconectar();
           }
           catch (Exception exqw) { }
           finally { objconexion.desconectar(); }
           return resultado;
       }


       public bool Editar()
       {
           bool resultado = false;
           Conexion objconexion = new Conexion();
           try
           {
               objconexion.conectar();
               SqlCommand cmd = new SqlCommand("proActualizarTipoDocumento",
              objconexion.Sqlconection);
               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.Add("IdTiposIdentificacion", SqlDbType.SmallInt).Value = idTipoDocumento;
               cmd.Parameters.Add("Tipo_TI", SqlDbType.VarChar).Value = tipo_TI;
               int intRestultado = 0;
               intRestultado = cmd.ExecuteNonQuery();
               if (intRestultado != 0)
               {
                   resultado = true;
               }
           }
           catch (Exception exwq) { }
           finally { objconexion.desconectar(); }
           return resultado;
       }       public bool Eliminar()
 {
 bool resultado = false;
 Conexion objconexion = new Conexion();
 try
 {
 objconexion.conectar();
 SqlCommand cmd = new SqlCommand("proEliminarTipoDocumento",
objconexion.Sqlconection);

 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("IdTiposIdentificacion", SqlDbType.SmallInt).Value = idTipoDocumento;
 int intRestultado = 0;
 intRestultado = cmd.ExecuteNonQuery();
 if (intRestultado != 0)
 {
     resultado = true;
 }
 }
 catch (Exception exqs) { }
 finally { }
 return resultado;
 }

        #endregion
    }
}
