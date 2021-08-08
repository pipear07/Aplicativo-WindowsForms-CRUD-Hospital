using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ObjetodeNegocios;

namespace nombre
{
    public partial class LaHistoriaClinica : Form
    {
        public LaHistoriaClinica()
        {
            InitializeComponent();
        }

        private void LaHistoriaClinica_Load(object sender, EventArgs e)
        {
            //Instancia la clase Personas
            Persona objPersonas = new Persona();
            Paciente objPaciente = new Paciente();
            HistoriaClinica objHistoria = new HistoriaClinica();
            //Carga la Grilla dgPPersonas desde el metodo Seleccionar de la clase personas, que a su vez consume el procedimiento
            //almacenado proPersonasConsultar1 en mi caso
            //  dgPersonas.DataSource = objPersonas.Seleccionar();
            visor_historia.DataSource = objHistoria.Seleccionar();
            
            //Actualiza la Grilla
            visor_historia.Refresh();
            //Se debe relacionar el numero de columnas que retorne el procedimiento almacenado dando titulo a los encabezados
            //de cada columna.
          //  lblcodigo.Text = visor_historia.Columns[1].HeaderText;
            visor_historia.Columns[0].Visible = false;
            visor_historia.Columns[1].HeaderText = "Codigo";
            visor_historia.Columns[2].HeaderText = "Evoluciones";
            visor_historia.Columns[3].HeaderText = "Resumen Clinico";
            visor_historia.Columns[4].HeaderText = "Direccion Residencia";
            visor_historia.Columns[5].HeaderText = "Tipo de Sangre";
            visor_historia.Columns[6].HeaderText = "Nombre del Paciente";
            visor_historia.Columns[7].HeaderText = "Direccion";
            visor_historia.Columns[8].HeaderText = "Numero de Documento";
            visor_historia.Columns[9].HeaderText = "Telefono Movil";
            visor_historia.Columns[10].HeaderText = "Telefono Fijo";
            visor_historia.Columns[11].HeaderText = "Fecha Nacimiento";
            visor_historia.Columns[12].HeaderText = "Estado Civil";
            visor_historia.Columns[13].HeaderText = "Tipo de Identificacion";





         
        }



        private void visor_historia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona objPersonas = new Persona();
            Paciente objPaciente = new Paciente();
            HistoriaClinica objHistoria = new HistoriaClinica();
            ResumenClinico objResumen = new ResumenClinico();
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                return;
            }
            //obtienes la fila seleccionada

            DataGridViewRow row = visor_historia.Rows[e.RowIndex];          
            //objPaciente.IdPersona = Convert.ToInt32(row.Cells[14].Value.ToString());
            //objPersonas.IdPersona = Convert.ToInt32(row.Cells[6].Value.ToString());
            //objPaciente.IdPersona = Convert.ToInt32(row.Cells[6].Value.ToString());
            objHistoria.IdHistoriaClinica = Convert.ToInt32(row.Cells[0].Value.ToString());
            objResumen.IdResumenClinico = Convert.ToInt32(row.Cells[0].Value.ToString());
            objHistoria.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());
            // hace uso del metodo Seleccionar IdPersona, que a su vez hace uso del procedimiento almacenado PersonasSeleccionarId
            objPersonas.SeleccionarId(); //RECUERDE QUE TOCA MODIFICAR EL PROCEDIMIENTO ALMACENADO PROCONSULTARIDPACIENTE
            objPaciente.SeleccionarId();
            objHistoria.SeleccionarId();
            objResumen.SeleccionarId();
            //carga en el label lblIdPersona el Id de la persona seleccionada, para usarlo mas adelante, este label debe aparecer invisible
            //en sus propiedades para evitar enseñarlo al usuario
            lblcodigo.Text = objHistoria.IdHistoriaClinica.ToString();
            //carga cada una de las cajas de texto con los datos que retorna el procedimiento almacenado

            TipoDocumento ti = new TipoDocumento();
            //       ti.IdTipoDocumento = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtevoluciones.Text = objHistoria.Evoluciones;
           
            txtresumenclinico.Text = objResumen.Descripcion;
            

        }

        private void button1_Click(object sender, EventArgs e) //guardar
        {
            
            //Instancia la clase personas en el objeto ObjePersonas
            Persona objPersonas = new Persona();
            GrupoSanguineo objSangre = new GrupoSanguineo();
            Paciente objPaciente = new Paciente();
            HistoriaClinica objHistoria = new HistoriaClinica();
            ResumenClinico objResumen = new ResumenClinico();
            lblpaciente.Text=objPaciente.IdPersona.ToString();
            //Envia los valores seleccionados en los combos y cajas de texto a la clase personas
            objHistoria.Evoluciones = txtevoluciones.Text;
            objResumen.Descripcion = txtresumenclinico.Text;
     
           // objHistoria.IdPersona = objPaciente.IdPersona; 
           
        }


       

    }
}
