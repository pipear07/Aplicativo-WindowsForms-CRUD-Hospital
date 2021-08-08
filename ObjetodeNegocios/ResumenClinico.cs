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
    public class ResumenClinico
    {
        #region Propiedades
        Int32 idResumenClinico;
        public Int32 IdResumenClinico
        {
            get { return idResumenClinico; }
            set { idResumenClinico = value; }
        }


        string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        #endregion

        #region Constructores
        public ResumenClinico() { }
        #endregion

        #region Metodos
        public DataTable Seleccionar()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proConsultarResumenClinico", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtPersonas;
        }


        public void SeleccionarId()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultaridResumenClinico", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdResumenClinico", SqlDbType.Int).Value = idResumenClinico;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idResumenClinico = Convert.ToInt32(dr["idResumenClinico"]); //llamar la normal y el encapsulado;                                     
                    descripcion = dr["Descripcion"].ToString();
                  
                }

                dr.Close();
                objconexion.desconectar();
            }
            catch (Exception ex) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }



        }
        #endregion

    }
}
