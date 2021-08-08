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
    public class Paciente
    {
        #region Propiedades
        Int32 idPersona;
        public Int32 IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        

        Int32 idEnfermedades;
        public Int32 IdEnfermedades
        {
            get { return idEnfermedades; }
            set { idEnfermedades = value; }
        }
        

        string motivoconsulta;
        public string MotivoConsulta
        {
            get { return motivoconsulta; }
            set { motivoconsulta = value; }
        }

        Int32 idgruposanguineo;

        public Int32 IdGrupoSanguineo
        {
            get { return idgruposanguineo; }
            set { idgruposanguineo = value; }
        }
        #endregion

        #region Constructores
        public Paciente() { }
        #endregion

        #region Metodos
        public DataTable Seleccionar()
        {
            DataTable dtTipos = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proConsultarPaciente", objconexion.Sqlconection);
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
                SqlCommand cmd = new SqlCommand("proConsultaridPaciente", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdPersona", SqlDbType.Int).Value = idPersona;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idPersona = Convert.ToInt32(dr["IdPersona"]); //llamar la normal y el encapsulado;                     
                    idgruposanguineo = Convert.ToInt32(dr["IdGrupoSanguineo"]);
                    motivoconsulta = dr["Motivo de la Consulta"].ToString();
                  //  idEnfermedades = Convert.ToInt16(dr["IdEnfermedad"]);
                   

                }

                dr.Close();
                objconexion.desconectar();
            }
            catch (Exception ex) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }



        }



        public DataTable SeleccionarCedula1()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            Persona person = new Persona();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proPersonasConsultarNumeroDocumento", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = person.NumeroDocumento1;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtPersonas;
        }


        public bool Insertar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proInsertarPaciente", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdPersona", SqlDbType.Int).Value = idPersona;
                cmd.Parameters.Add("IdGrupoSanguineo", SqlDbType.TinyInt).Value = IdGrupoSanguineo;
                cmd.Parameters.Add("MotivoConsulta", SqlDbType.VarChar).Value = motivoconsulta;
                cmd.Parameters.Add("IdEnfermedad", SqlDbType.TinyInt).Value = idEnfermedades;
           
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


        public bool Editar()
        {
            bool resultado = false;
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proActualizarPaciente", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("idPersona", SqlDbType.Int).Value = IdPersona; //CUIDADO CON EL NOMBRE DE LAS VARIABLES DEL PROCEDIMIENTO ALMACENADO, ME LANZO ERROR EL IDPERSONA Y ES QUE ERA QUE ESTABA MAL ESCRITO EN EL PROCEDIMIENTO COMO IDPERSONA Y ERA LLAMADO COMO IDPERSONAS
                cmd.Parameters.Add("idGrupoSanguineo", SqlDbType.TinyInt).Value = IdGrupoSanguineo;
                cmd.Parameters.Add("MotivoConsulta", SqlDbType.VarChar).Value = motivoconsulta;
                cmd.Parameters.Add("idEnfermedad", SqlDbType.TinyInt).Value = idEnfermedades;
               
                int intRestultado = 0;
              
                intRestultado = cmd.ExecuteNonQuery();
                if (intRestultado != 0)
                {
                    resultado = true;
                    objconexion.desconectar();
                }
            }
            catch (Exception exqw)
            {
                objconexion.desconectar();
            }
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
                SqlCommand cmd = new SqlCommand("proEliminarPaciente", objconexion.Sqlconection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdPersona", SqlDbType.Int).Value = IdPersona;
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
