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
    public class Enfermedades
    {
        #region Propiedades
        Int32 idEnfermedades;

        public Int32 IdEnfermedades
        {
            get { return idEnfermedades; }
            set { idEnfermedades = value; }
        }
        Int32 idPersona;

        public Int32 IdPersona
        {
            get { return idPersona; }
            set { idPersona = value; }
        }
        string Nombre;

        public string Nombre1
        {
            get { return Nombre; }
            set { Nombre = value; }
        }


        #endregion

        #region Constructores
        public Enfermedades() { }
        #endregion

        #region Metodos

      

        #endregion
    }
}
