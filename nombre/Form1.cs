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
    public partial class btnEditar : Form
    {
        public btnEditar()
        {
            InitializeComponent();
        }

        int contador = 1;

        /*
        Thread Hilo;//hace una instanciacion en memoria en esa clase Thread que crea los hilos
        int codigo = 9;
        public void Mover2()
        {
            while (codigo == 9)
            {
               
                Thread.Sleep(1200); //detengo al hilo 100 milisegundos
            }
        }

         */

        private void Form1_Load2(object sender, EventArgs e)
        {
            //Instancia la clase Personas
            Persona objPersonas = new Persona();
            Paciente objPaciente = new Paciente();
            //Carga la Grilla dgPPersonas desde el metodo Seleccionar de la clase personas, que a su vez consume el procedimiento
            //almacenado proPersonasConsultar1 en mi caso
          //  dgPersonas.DataSource = objPersonas.Seleccionar();
            txtmotivoconsulta.DataSource = objPaciente.Seleccionar();
            //Actualiza la Grilla
            txtmotivoconsulta.Refresh();
            //Se debe relacionar el numero de columnas que retorne el procedimiento almacenado dando titulo a los encabezados
            //de cada columna.
       
            txtmotivoconsulta.Columns[0].Visible = false;
            txtmotivoconsulta.Columns[1].HeaderText = "Motivo de Consulta";
            txtmotivoconsulta.Columns[2].HeaderText = "Tipo de Sangre";
            txtmotivoconsulta.Columns[3].HeaderText = "Nombre del Paciente";
            txtmotivoconsulta.Columns[4].HeaderText = "Direccion Residencia";
            txtmotivoconsulta.Columns[5].HeaderText = "Numero de Documento";
            txtmotivoconsulta.Columns[6].HeaderText = "Telefono Movil";
            txtmotivoconsulta.Columns[7].HeaderText = "Telefono Fijo";
            txtmotivoconsulta.Columns[8].HeaderText = "Fecha de Nacimiento";
            txtmotivoconsulta.Columns[9].HeaderText = "Estado Civil";
            txtmotivoconsulta.Columns[10].HeaderText = "Tipo Documento";
        



            //dgPersonas.Columns[12].HeaderText = "Telefono Fijo";
            //Carga el Combot Box Tipos de Identificacion
            //instancia la clase tipos identificacion
            //INSTANCIACION
            TipoDocumento objTiposIdentificacion = new TipoDocumento();
            EstadoCivil objEstadoCivil = new EstadoCivil();
            GrupoSanguineo objSangre = new GrupoSanguineo();
           
            //llama al metodo seleccionar de la clase tipos identificacion y el resultado se lo asigna al combobox
            //LLAMAR AL METODO DE SELECCION
            cboTiposIdentificacion.DataSource = objTiposIdentificacion.Seleccionar();
            combo_estado.DataSource = objEstadoCivil.Seleccionar();
            combo_tiposangre.DataSource = objSangre.Seleccionar();
            //indica al combo cual columna debe mostrar al usuario
            //SELECCIONE LA COLUMNA A MOSTRAR
            cboTiposIdentificacion.DisplayMember = "Tipo";
            combo_estado.DisplayMember = "Estado Civil";

            //indica al combo cual columna debe asignar como id
            cboTiposIdentificacion.ValueMember = "IdTipoDocumento";
            combo_estado.ValueMember = "IdEstadoCivil";

            combo_tiposangre.DisplayMember = "Nombre";
            combo_tiposangre.ValueMember = "IdGrupoSanguineo";
        }


        private void dgPersonas_CellClick(object sender, DataGridViewCellEventArgs e) { 
        
            
        
        }

        private void btnNuevo_Click(object sender, System.EventArgs e)
        {
        //Limpia todos las cajas de texto del formulario y envia el foco a la caja llamada txtNumero Identificacion
            txtNumeroIdentificacion.Text = "";
            txtPNombre.Text = "";
            txtSNombre.Text = "";
            txtPApellido.Text = "";
            txtSApellido.Text = "";
            txtDireccion.Text = "";
            txtMovil.Text = "";
            txtFijo.Text = "";
            fecha.ResetText();
            motivos.Text = "";
 txtNumeroIdentificacion.Focus();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            //Instancia la clase personas en el objeto ObjePersonas
 Persona objPersonas = new Persona();
 GrupoSanguineo objSangre = new GrupoSanguineo();
 Paciente objPaciente = new Paciente();
 //Envia los valores seleccionados en los combos y cajas de texto a la clase personas
 objPersonas.IdTipoDocumento = Convert.ToInt16(cboTiposIdentificacion.SelectedValue);
 objPersonas.IdEstadoCivil = Convert.ToInt16(combo_estado.SelectedValue);
 objPersonas.NumeroDocumento1 = txtNumeroIdentificacion.Text;
 objPersonas.PNombre1 = txtPNombre.Text;
 objPersonas.SNombre1 = txtSNombre.Text;
 objPersonas.PApellido1 = txtPApellido.Text;
 objPersonas.SApellido1 = txtSApellido.Text;
 objPersonas.Direccion1 = txtDireccion.Text;
            
 objPersonas.TelefonoMovil1 = txtMovil.Text;
 objPersonas.TelefonoFijo1 = txtFijo.Text;
 objPersonas.FechaNacimiento1 = Convert.ToDateTime(fecha.Value);
 //GRUPO SANGUINEO
 objPersonas.Insertar();
 objPaciente.IdPersona = objPersonas.IdPersona;
 objPaciente.IdGrupoSanguineo = Convert.ToInt16(combo_tiposangre.SelectedValue);
 objPaciente.MotivoConsulta = motivos.Text;
 objPaciente.IdEnfermedades = 5;
 //llama al metodo insertar que a su vez hace uso del procedimiento almacenado proPersonasInsertar

 objPaciente.Insertar();
 //if (objPersonas.Insertar())
// {
  //   MessageBox.Show("fue guardado");
 //}
 txtmotivoconsulta.Refresh();
 txtmotivoconsulta.DataSource = objPaciente.Seleccionar();
 if (contador == 1)
 {
     notifyIcon1.Visible = true;
     notifyIcon1.ShowBalloonTip(20000, "Informativo", "RECUERDA, verificar los registro que se van guardado", ToolTipIcon.Info);//este era el error
     contador++;
 }
            }

        private void button3_Click(object sender, System.EventArgs e)
        {
            Paciente objPaciente = new Paciente();
            //Instancia la clase personas en el objeto ObjePersonas
 Persona objPersonas = new Persona();

 //Envia los valores seleccionados en los combos y cajas de texto a la clase personas
 objPersonas.IdPersona = Convert.ToInt32(lblIdPersona.Text);
objPersonas.IdTipoDocumento = Convert.ToInt32(cboTiposIdentificacion.SelectedValue);
objPersonas.IdEstadoCivil = Convert.ToInt16(combo_estado.SelectedValue);
 objPersonas.NumeroDocumento1 = txtNumeroIdentificacion.Text;
 objPersonas.PNombre1 = txtPNombre.Text;
 objPersonas.SNombre1 = txtSNombre.Text;
 objPersonas.PApellido1 = txtPApellido.Text;
 objPersonas.SApellido1 = txtSApellido.Text;
 objPersonas.Direccion1 = txtDireccion.Text;
 objPersonas.TelefonoMovil1 = txtMovil.Text;
 objPersonas.TelefonoFijo1 = txtFijo.Text;
 objPersonas.FechaNacimiento1 = Convert.ToDateTime(fecha.Value);
 objPaciente.IdPersona = Convert.ToInt32(lblIdPersona.Text);
 objPaciente.IdGrupoSanguineo = Convert.ToInt16(combo_tiposangre.SelectedValue);
 objPaciente.MotivoConsulta = motivos.Text;
 objPaciente.IdEnfermedades = 5;
 //llama al metodo Editar que a su vez hace uso del procedimiento almacenado proPersonasActualizar
 objPersonas.Editar();
 txtmotivoconsulta.Refresh();
 objPaciente.Editar();
 txtmotivoconsulta.Refresh();
 txtmotivoconsulta.DataSource = objPaciente.Seleccionar();
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            //Instancia la clase personas en el objeto ObjePersonas
 Persona objPersonas = new Persona();
 Paciente objPaciente = new Paciente();
 //envia el id de la persona a eliminar guardado en el label lblIdPersona oculto en el formulario
 objPersonas.IdPersona = Convert.ToInt32(lblIdPersona.Text);
 objPaciente.IdPersona = Convert.ToInt32(lblIdPersona.Text);
 //LLama al metodo eliminar que a su vez hace uso del procedimiento almacenado proPersonasEliminar

 objPaciente.Eliminar();
 objPersonas.Eliminar();
 txtmotivoconsulta.Refresh();
 txtmotivoconsulta.DataSource = objPaciente.Seleccionar();
        }

        public void mostrarbuscador() {
            Persona objPersonas = new Persona();
            Paciente objPaciente = new Paciente();
            combo_estado.SelectedValue = objPersonas.IdEstadoCivil;
            cboTiposIdentificacion.SelectedValue = objPersonas.IdTipoDocumento;
            txtNumeroIdentificacion.Text = objPersonas.NumeroDocumento1;
            txtPNombre.Text = objPersonas.PNombre1;
            txtSNombre.Text = objPersonas.SNombre1;
            txtPApellido.Text = objPersonas.PApellido1;
            txtSApellido.Text = objPersonas.SApellido1;
            txtDireccion.Text = objPersonas.Direccion1;
            txtMovil.Text = objPersonas.TelefonoMovil1;
            txtFijo.Text = objPersonas.TelefonoFijo1;
            motivos.Text = objPaciente.MotivoConsulta;

            combo_tiposangre.SelectedValue = objPaciente.IdGrupoSanguineo;

       //     fecha.Value = Convert.ToDateTime(objPersonas.FechaNacimiento1.ToString());
            txtmotivoconsulta.Refresh(); 
        }

        private void cellclick2(object sender, DataGridViewCellEventArgs e)
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
            DataGridViewRow row = txtmotivoconsulta.Rows[e.RowIndex];
            objPersonas.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());
            objPaciente.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());
            
            // hace uso del metodo Seleccionar IdPersona, que a su vez hace uso del procedimiento almacenado PersonasSeleccionarId
            objPersonas.SeleccionarId(); //RECUERDE QUE TOCA MODIFICAR EL PROCEDIMIENTO ALMACENADO PROCONSULTARIDPACIENTE
            objPaciente.SeleccionarId();
            //carga en el label lblIdPersona el Id de la persona seleccionada, para usarlo mas adelante, este label debe aparecer invisible
            //en sus propiedades para evitar enseñarlo al usuario
            lblIdPersona.Text = objPaciente.IdPersona.ToString();
            //carga cada una de las cajas de texto con los datos que retorna el procedimiento almacenado

            TipoDocumento ti = new TipoDocumento();
     //       ti.IdTipoDocumento = Convert.ToInt32(row.Cells[0].Value.ToString());
        
            combo_estado.SelectedValue = objPersonas.IdEstadoCivil;
            cboTiposIdentificacion.SelectedValue = objPersonas.IdTipoDocumento;
            txtNumeroIdentificacion.Text = objPersonas.NumeroDocumento1;
            txtPNombre.Text = objPersonas.PNombre1;
            txtSNombre.Text = objPersonas.SNombre1;
            txtPApellido.Text = objPersonas.PApellido1;
            txtSApellido.Text = objPersonas.SApellido1;
            txtDireccion.Text = objPersonas.Direccion1;
            txtMovil.Text = objPersonas.TelefonoMovil1;
            txtFijo.Text = objPersonas.TelefonoFijo1;
            motivos.Text = objPaciente.MotivoConsulta;
        
           combo_tiposangre.SelectedValue = objPaciente.IdGrupoSanguineo;
            
            fecha.Value = Convert.ToDateTime(objPersonas.FechaNacimiento1.ToString());
            txtmotivoconsulta.Refresh();        
        }

        private void txtPNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscador buscador_instanciado = new Buscador();
            buscador_instanciado.ShowDialog();//esto es para que llame al otro windows form cuando presione el boton buscar, este abra
           // Persona objPersonas = new Persona();
            //objPersonas.NumeroDocumento1 = txtNumeroIdentificacion.Text;
            //objPersonas.SeleccionarCedula();
        }

        private void historiaClinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaHistoriaClinica clinica = new LaHistoriaClinica();
            clinica.ShowDialog();
        }

        private void txtmotivoconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void combo_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblIdPersona_Click(object sender, EventArgs e)
        {

        }
    }
}
