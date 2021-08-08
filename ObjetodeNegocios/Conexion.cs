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
    public class Conexion
    {
        #region Propiedades
       

       
        SqlCommand sqlcomand;//este no va encapsulado

        SqlConnection sqlconection = new SqlConnection();
        public SqlConnection Sqlconection
        {
            get { return sqlconection; }
            set { sqlconection = value; }
        }
 
        string strConexion;

        public string StrConexion
        {
            get { return strConexion; }
            set { strConexion = value; }
        }



        #endregion

        #region Constructores

        public Conexion() 
        { }
        #endregion

        #region Metodos
        public bool conectar()
        {
            bool conecta = false;

            try
            {
                StrConexion = @"Data Source=DESKTOP-39U6VSR\AREVALO_OS ; Initial Catalog=ConsultorioMedico; Integrated Security=true ";
              Sqlconection.ConnectionString=StrConexion;
                Sqlconection.Open();
                conecta=true;
            }
            catch (Exception e)
            {
            conecta=false;
            }
            return conecta;
        }

        public bool desconectar()
        {
            bool desconecta = false;
            try {
               
                Sqlconection.Close();
                Sqlconection.Dispose();
                desconecta = true;
            }
            catch (Exception exx) 
            {
                desconecta = false;
            }
            return desconecta;
        }

        #endregion

    }
}
