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
    public class GrupoSanguineo
    {
        #region Propiedades
        Int32 idGrupoSanguineo;

        public Int32 IdGrupoSanguineo
        {
            get { return idGrupoSanguineo; }
            set { idGrupoSanguineo = value; }
        }
        
        string nombregruposanguineo;

        public string NombreGrupoSanguineo
        {
            get { return nombregruposanguineo; }
            set { nombregruposanguineo = value; }
        }
        #endregion

        #region Constructores
        public GrupoSanguineo() { }
        #endregion

        #region Metodos

        public DataTable Seleccionar()
        {
            DataTable dtTipos = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultarGrupoSanguineo", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtTipos.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception exi) { }
            finally { objconexion.desconectar(); }
            return dtTipos;
        }


        public void SeleccionarId()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultaridGrupoSanguineo",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdGrupoSanguineo", SqlDbType.Int).Value = idGrupoSanguineo;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idGrupoSanguineo = Convert.ToInt32(dr["IdGrupoSanguineo"]);
                    NombreGrupoSanguineo = dr["Nombre"].ToString();
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
                SqlCommand cmd = new SqlCommand("proInsertarGrupoSanguineo",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdGrupoSanguineo", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = NombreGrupoSanguineo;
                cmd.ExecuteNonQuery();
                idGrupoSanguineo = Convert.ToInt32((cmd.Parameters["idGrupoSanguineo"].Value).ToString());
                if (idGrupoSanguineo != 0)
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
                SqlCommand cmd = new SqlCommand("proActualizarGrupoSanguineo",
               objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdGrupoSanguineo", SqlDbType.Int).Value = idGrupoSanguineo;
                cmd.Parameters.Add("Nombre", SqlDbType.VarChar).Value = NombreGrupoSanguineo;
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
        }



        public bool Eliminar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proEliminarGrupoSanguineo",
               objconexion.Sqlconection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdGrupoSanguineo", SqlDbType.Int).Value = idGrupoSanguineo;
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
