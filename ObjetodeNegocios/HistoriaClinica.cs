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
    public class HistoriaClinica
    {
        #region Propiedades
        Int32 idHistoriaClinica;
        public Int32 IdHistoriaClinica
        {
            get { return idHistoriaClinica; }
            set { idHistoriaClinica = value; }
        }


        Int32 idResumenClinico;
        public Int32 IdResumenClinico
        {
            get { return idResumenClinico; }
            set { idResumenClinico = value; }
        }
       
        
        Int32 idPersona;
        public Int32 IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
   
        
        string codigohistorial;
        public string CodigoHistorial
        {
            get { return codigohistorial; }
            set { codigohistorial = value; }
        }
   

        string evoluciones;
        public string Evoluciones
        {
            get { return evoluciones; }
            set { evoluciones = value; }
        }


        #endregion

        #region Constructores
        public HistoriaClinica() { }
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
                SqlCommand cmd = new SqlCommand("proConsultarHistoriaClinica", objconexion.Sqlconection);
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
                SqlCommand cmd = new SqlCommand("proConsultaridHistoriaClinica", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdHistoriaClinica", SqlDbType.Int).Value = idHistoriaClinica;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idHistoriaClinica = Convert.ToInt32(dr["IdHistoriaClinica"]); //llamar la normal y el encapsulado;                     
                    idResumenClinico = Convert.ToInt32(dr["beta"]);
                    idPersona = Convert.ToInt32(dr["IdPersona"]);
                    codigohistorial = dr["CodigoHistorial"].ToString();
                    evoluciones = dr["Evoluciones"].ToString();
                   
                  

                }

                dr.Close();
                objconexion.desconectar();
            }
            catch (Exception ex) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }



        }


         public bool Insertar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proInsertarHistoriaClinica", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdHistoriaClinica", SqlDbType.Int).Value = idHistoriaClinica;
                cmd.Parameters.Add("IdPersona", SqlDbType.TinyInt).Value = IdPersona;
                cmd.Parameters.Add("IdResumenClinico", SqlDbType.VarChar).Value = idResumenClinico;
                cmd.Parameters.Add("Evoluciones", SqlDbType.TinyInt).Value = evoluciones;

                cmd.ExecuteNonQuery();

                idPersona = Convert.ToInt32((cmd.Parameters["IdPersona"].Value).ToString());
                if (idPersona != 0)
                {
                    resultado = true;
                    objconexion.desconectar();
                }
            }
            catch (Exception exe)
            {

                objconexion.desconectar();

            }
            return resultado;
        }


        #endregion
    }
}
