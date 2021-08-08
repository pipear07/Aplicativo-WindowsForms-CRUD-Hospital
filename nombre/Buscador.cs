using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; //estas son nuevas
using System.Windows.Forms;
using ObjetodeNegocios;

namespace nombre
{
    public partial class Buscador : Form
    {
        btnEditar esa2 = new btnEditar();
        public Persona ClienteSeleccionado { get; set; }
        public Buscador()
        {
            InitializeComponent();
         
           
        }

        private void btn_buscador_Click(object sender, EventArgs e)
        {
             Persona objPersonas = new Persona();
            objPersonas.NumeroDocumento1 = txtbuscador.Text;
            objPersonas.SeleccionarCedula();
             dbBuscaPersona.DataSource = objPersonas.SeleccionarCedula1();
             dbBuscaPersona.Refresh();
             //Se debe relacionar el numero de columnas que retorne el procedimiento almacenado dando titulo a los encabezados
             //de cada columna.
             dbBuscaPersona.Columns[0].Visible = false;
             dbBuscaPersona.Columns[1].HeaderText = "Motivo de Consulta";
             dbBuscaPersona.Columns[2].HeaderText = "Tipo de Sangre";
             dbBuscaPersona.Columns[3].HeaderText = "Nombre";
             dbBuscaPersona.Columns[4].HeaderText = "Direccion Residencia";
             dbBuscaPersona.Columns[5].HeaderText = "Numero de Documento";
             dbBuscaPersona.Columns[6].HeaderText = "Telefono Movil";
             dbBuscaPersona.Columns[7].HeaderText = "Telefono Fijo";
             dbBuscaPersona.Columns[8].HeaderText = "Fecha de Nacimiento";
             dbBuscaPersona.Columns[9].HeaderText = "Estado Civil";
             dbBuscaPersona.Columns[10].HeaderText = "Tipo Documento";
     //        dbBuscaPersona.Columns[11].HeaderText = "Telefono fijo";
        }

        private void dbBuscaPersona_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se instancia la clase personas en el objeto objPersonas
            Persona objPersonas = new Persona();
            Paciente objPaciente = new Paciente();
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                return;
            }
            //obtienes la fila seleccionada
            DataGridViewRow row = dbBuscaPersona.Rows[e.RowIndex];
            objPersonas.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());
            objPaciente.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());

            // hace uso del metodo Seleccionar IdPersona, que a su vez hace uso del procedimiento almacenado PersonasSeleccionarId
            objPersonas.SeleccionarCedula(); //RECUERDE QUE TOCA MODIFICAR EL PROCEDIMIENTO ALMACENADO PROCONSULTARIDPACIENTE
            objPaciente.SeleccionarCedula1();
            //carga en el label lblIdPersona el Id de la persona seleccionada, para usarlo mas adelante, este label debe aparecer invisible
            //en sus propiedades para evitar enseñarlo al usuario
            lblIdPersona.Text = objPaciente.IdPersona.ToString();
            //carga cada una de las cajas de texto con los datos que retorna el procedimiento almacenado

            TipoDocumento ti = new TipoDocumento();
            //       ti.IdTipoDocumento = Convert.ToInt32(row.Cells[0].Value.ToString());

            btnEditar editar = new btnEditar();
            editar.mostrarbuscador();
            
        }

        private void Buscador_Load(object sender, EventArgs e)
        {

        }
            
        }

       

    }

