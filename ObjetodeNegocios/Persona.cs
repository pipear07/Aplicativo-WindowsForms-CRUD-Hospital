using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ObjetodeNegocios
{
    public class Persona 
    {
        #region Propiedades
        int idPersona;

        public int IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
       Int32 idTipoDocumento;

        string strTipoDocumento;

public string StrTipoDocumento
{
  get { return strTipoDocumento; }
  set { strTipoDocumento = value; }
}

        public Int32 IdTipoDocumento
        {
            get { return idTipoDocumento; }
            set { idTipoDocumento = value; }
        }
        Int16 idEstadoCivil;

        public Int16 IdEstadoCivil
        {
            get { return idEstadoCivil; }
            set { idEstadoCivil = value; }
        }

        string tipoestadocivil;

        public string TipoEstadoCivil
        {
            get { return tipoestadocivil; }
            set { tipoestadocivil = value; }
        }

        string PNombre;

        public string PNombre1
        {
            get { return PNombre; }
            set { PNombre = value; }
        }
        string SNombre;

        public string SNombre1
        {
            get { return SNombre; }
            set { SNombre = value; }
        }
        string PApellido;

        public string PApellido1
        {
            get { return PApellido; }
            set { PApellido = value; }
        }
        string SApellido;

        public string SApellido1
        {
            get { return SApellido; }
            set { SApellido = value; }
        }
        string NumeroDocumento;

        public string NumeroDocumento1
        {
            get { return NumeroDocumento; }
            set { NumeroDocumento = value; }
        }
        string Direccion;

        public string Direccion1
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
       
        DateTime FechaNacimiento;

        public DateTime FechaNacimiento1
        {
            get { return FechaNacimiento; }
            set { FechaNacimiento = value; }
        }
        
        string TelefonoFijo;

        public string TelefonoFijo1
        {
            get { return TelefonoFijo; }
            set { TelefonoFijo = value; }
        }
        string TelefonoMovil;

        public string TelefonoMovil1
        {
            get { return TelefonoMovil; }
            set { TelefonoMovil = value; }
        }

        #endregion

        #region Constructores
        public Persona()
        { }

        public Persona(int pIdPersona)
        {
             idPersona = pIdPersona;
             SeleccionarId();
        }

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
                SqlCommand cmd = new SqlCommand("proConsultarPersonas",objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                objconexion.desconectar();
            }
            catch (Exception ex) { }
            finally { objconexion.desconectar(); }
            return dtPersonas;
        }

        public DataTable SeleccionarPersonalizado()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proConsultarPersonas", objconexion.Sqlconection);
                SqlCommand cmd2 = new SqlCommand("proConsultarGrupoSanguineo", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                using (IDataReader dr = cmd.ExecuteReader())
                { dtPersonas.Load(dr); }
                using (IDataReader dr2 = cmd2.ExecuteReader())
                { dtPersonas.Load(dr2); }
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
                SqlCommand cmd = new SqlCommand("proConsultaridPersonas", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdPersona", SqlDbType.Int).Value = idPersona;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                       idPersona = Convert.ToInt32(dr["IdPersona"]); //llamar la normal y el encapsulado;                     
                      idEstadoCivil = Convert.ToInt16(dr["IdEstadoCivil"]);
                       TipoEstadoCivil = dr["EstadoCivil"].ToString();
                       idTipoDocumento = Convert.ToInt16(dr["IdTipoDocumento"]);
                    //   strTipoDocumento = dr["StrTipoDocumento"].ToString();
                       PNombre = dr["PNombre"].ToString();
                       SNombre = dr["SNombre"].ToString();
                       PApellido = dr["PApellido"].ToString();
                       SApellido = dr["SApellido"].ToString();
                       NumeroDocumento = dr["NumeroDocumento"].ToString();
                       Direccion = dr["Direccion"].ToString();
                       FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                       TelefonoMovil = dr["TelefonoMovil"].ToString();
                       TelefonoFijo = dr["TelefonoFijo"].ToString();
                      
                }

              dr.Close();
              objconexion.desconectar();
            }
            catch (Exception ex) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }



        }


        public void SeleccionarCedula()
        {
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                SqlCommand cmd = new SqlCommand("proPersonasConsultarNumeroDocumento", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento1;
                IDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    idPersona = Convert.ToInt32(dr["IdPersona"]); //llamar la normal y el encapsulado;
                   // idTipoDocumento = Convert.ToInt16(dr["Tipo"]);
                    //idEstadoCivil = Convert.ToInt16(dr["Estado Civil"]);
                    //strTipoDocumento = dr["StrTipoDocumento"].ToString();
                 //   PNombre = dr["PNombre"].ToString();
                   // SNombre = dr["SNombre"].ToString();
                    //PApellido = dr["PApellido"].ToString();
                    //SApellido = dr["SApellido"].ToString();
                    NumeroDocumento = dr["NumeroDocumento"].ToString();
                    Direccion = dr["Direccion"].ToString();
                    TelefonoMovil = dr["TelefonoMovil"].ToString();
                    TelefonoFijo = dr["TelefonoFijo"].ToString();
                    FechaNacimiento = Convert.ToDateTime(dr["FechaNacimiento"]);
                }
                dr.Close();
                objconexion.desconectar();
            }
            catch (Exception exr) { objconexion.desconectar(); }
            finally { objconexion.desconectar(); }
        }


        public DataTable SeleccionarCedula1()
        {

            DataTable dtPersonas = new DataTable();
            Conexion objconexion = new Conexion();
            try
            {
                objconexion.conectar();
                //proPersonasConsultar1 ES EL PROCEDIMIENTO ALMACENADO QUE RETORNA TODAS
                //LAS PERSONAS DE LA TABLA PERSONAS
                SqlCommand cmd = new SqlCommand("proPersonasConsultarNumeroDocumento", objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento;
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
                SqlCommand cmd = new SqlCommand("proInsertarPersonas",objconexion.Sqlconection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("IdPersonas", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("IdTipoDocumento", SqlDbType.Int).Value = IdTipoDocumento;
                cmd.Parameters.Add("IdEstadoCivil", SqlDbType.Int).Value = IdEstadoCivil;
                cmd.Parameters.Add("PNombre1", SqlDbType.VarChar).Value = PNombre;
                cmd.Parameters.Add("SNombre", SqlDbType.VarChar).Value = SNombre;
                cmd.Parameters.Add("PApellido", SqlDbType.VarChar).Value = PApellido;
                cmd.Parameters.Add("SApellido", SqlDbType.VarChar).Value = SApellido;
                cmd.Parameters.Add("Direccion", SqlDbType.VarChar).Value = Direccion;
                cmd.Parameters.Add("FechaNacimiento", SqlDbType.DateTime).Value = FechaNacimiento1;
                cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento;
                cmd.Parameters.Add("TelefonoFijo", SqlDbType.VarChar).Value = TelefonoFijo;
                cmd.Parameters.Add("TelefonoMovil", SqlDbType.VarChar).Value = TelefonoMovil;
                cmd.ExecuteNonQuery();
                
                idPersona = Convert.ToInt32((cmd.Parameters["IdPersonas"].Value).ToString());
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
            //}
        }


        public bool Editar()
 {
 bool resultado = false;
 Conexion objconexion = new Conexion();
 try
 {
 objconexion.conectar();
// SqlTransaction ObjTransaccion = objconexion.Sqlconection.BeginTransaction();
     SqlCommand cmd = new SqlCommand("proActualizarPersonas",objconexion.Sqlconection);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("idPersonas", SqlDbType.Int).Value = IdPersona; //CUIDADO CON EL NOMBRE DE LAS VARIABLES DEL PROCEDIMIENTO ALMACENADO, ME LANZO ERROR EL IDPERSONA Y ES QUE ERA QUE ESTABA MAL ESCRITO EN EL PROCEDIMIENTO COMO IDPERSONA Y ERA LLAMADO COMO IDPERSONAS
 cmd.Parameters.Add("idTipoDocumento", SqlDbType.Int).Value = IdTipoDocumento;
 cmd.Parameters.Add("idEstadoCivil", SqlDbType.Int).Value = IdEstadoCivil;
 cmd.Parameters.Add("PNombre", SqlDbType.VarChar).Value = PNombre;
 cmd.Parameters.Add("SNombre", SqlDbType.VarChar).Value = SNombre;
 cmd.Parameters.Add("PApellido", SqlDbType.VarChar).Value = PApellido;
 cmd.Parameters.Add("SApellido", SqlDbType.VarChar).Value = SApellido;
 cmd.Parameters.Add("NumeroDocumento", SqlDbType.VarChar).Value = NumeroDocumento;
 cmd.Parameters.Add("Direccion", SqlDbType.VarChar).Value = Direccion;
 cmd.Parameters.Add("FechaNacimiento", SqlDbType.DateTime).Value = DateTime.Now.ToShortTimeString();
 cmd.Parameters.Add("TelefonoMovil", SqlDbType.VarChar).Value = TelefonoMovil;
 int intRestultado = 0;
 cmd.Parameters.Add("TelefonoFijo", SqlDbType.VarChar).Value = TelefonoFijo;
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
 SqlCommand cmd = new SqlCommand("proEliminarPersonas",objconexion.Sqlconection);
 cmd.CommandType = CommandType.StoredProcedure;
 cmd.Parameters.Add("idPersonas", SqlDbType.Int).Value =IdPersona;
 int intRestultado = 0;
 intRestultado = cmd.ExecuteNonQuery();
 if (intRestultado != 0)
 {
 resultado = true;
 }
 }
 catch (Exception ex) { objconexion.desconectar(); }
 finally { objconexion.desconectar(); }
 return resultado;
 }
        #endregion
    }
}





    


