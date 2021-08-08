namespace nombre
{
    partial class btnEditar
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnEditar));
            this.txtmotivoconsulta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cboTiposIdentificacion = new System.Windows.Forms.ComboBox();
            this.txtPNombre = new System.Windows.Forms.TextBox();
            this.txtSNombre = new System.Windows.Forms.TextBox();
            this.txtPApellido = new System.Windows.Forms.TextBox();
            this.txtSApellido = new System.Windows.Forms.TextBox();
            this.txtNumeroIdentificacion = new System.Windows.Forms.TextBox();
            this.txtFijo = new System.Windows.Forms.TextBox();
            this.txtMovil = new System.Windows.Forms.TextBox();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.combo_estado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.combo_tiposangre = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.motivos = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.historiaClinicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label15 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtmotivoconsulta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmotivoconsulta
            // 
            this.txtmotivoconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtmotivoconsulta.Location = new System.Drawing.Point(-12, 369);
            this.txtmotivoconsulta.Name = "txtmotivoconsulta";
            this.txtmotivoconsulta.Size = new System.Drawing.Size(1042, 150);
            this.txtmotivoconsulta.TabIndex = 0;
            this.txtmotivoconsulta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellclick2);
            this.txtmotivoconsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtmotivoconsulta_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Primer Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Segundo Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Telefono Movil";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Numero Identificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Telefono Fijo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tipo Identificacion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fecha Nacimiento";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(160, 534);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(109, 41);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(320, 532);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 43);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(601, 532);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 43);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cboTiposIdentificacion
            // 
            this.cboTiposIdentificacion.FormattingEnabled = true;
            this.cboTiposIdentificacion.Location = new System.Drawing.Point(160, 208);
            this.cboTiposIdentificacion.Name = "cboTiposIdentificacion";
            this.cboTiposIdentificacion.Size = new System.Drawing.Size(162, 21);
            this.cboTiposIdentificacion.TabIndex = 14;
            // 
            // txtPNombre
            // 
            this.txtPNombre.Location = new System.Drawing.Point(153, 91);
            this.txtPNombre.Name = "txtPNombre";
            this.txtPNombre.Size = new System.Drawing.Size(228, 20);
            this.txtPNombre.TabIndex = 19;
            this.txtPNombre.TextChanged += new System.EventHandler(this.txtPNombre_TextChanged);
            // 
            // txtSNombre
            // 
            this.txtSNombre.Location = new System.Drawing.Point(153, 119);
            this.txtSNombre.Name = "txtSNombre";
            this.txtSNombre.Size = new System.Drawing.Size(228, 20);
            this.txtSNombre.TabIndex = 20;
            // 
            // txtPApellido
            // 
            this.txtPApellido.Location = new System.Drawing.Point(153, 149);
            this.txtPApellido.Name = "txtPApellido";
            this.txtPApellido.Size = new System.Drawing.Size(228, 20);
            this.txtPApellido.TabIndex = 21;
            // 
            // txtSApellido
            // 
            this.txtSApellido.Location = new System.Drawing.Point(153, 179);
            this.txtSApellido.Name = "txtSApellido";
            this.txtSApellido.Size = new System.Drawing.Size(228, 20);
            this.txtSApellido.TabIndex = 22;
            // 
            // txtNumeroIdentificacion
            // 
            this.txtNumeroIdentificacion.Location = new System.Drawing.Point(172, 240);
            this.txtNumeroIdentificacion.Name = "txtNumeroIdentificacion";
            this.txtNumeroIdentificacion.Size = new System.Drawing.Size(192, 20);
            this.txtNumeroIdentificacion.TabIndex = 23;
            // 
            // txtFijo
            // 
            this.txtFijo.Location = new System.Drawing.Point(130, 302);
            this.txtFijo.Name = "txtFijo";
            this.txtFijo.Size = new System.Drawing.Size(149, 20);
            this.txtFijo.TabIndex = 25;
            // 
            // txtMovil
            // 
            this.txtMovil.Location = new System.Drawing.Point(130, 330);
            this.txtMovil.Name = "txtMovil";
            this.txtMovil.Size = new System.Drawing.Size(149, 20);
            this.txtMovil.TabIndex = 26;
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Location = new System.Drawing.Point(721, 98);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(41, 13);
            this.lblIdPersona.TabIndex = 27;
            this.lblIdPersona.Text = "label10";
            this.lblIdPersona.Click += new System.EventHandler(this.lblIdPersona_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(651, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "N* Registro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 123);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Estado Civil:";
            // 
            // combo_estado
            // 
            this.combo_estado.FormattingEnabled = true;
            this.combo_estado.Location = new System.Drawing.Point(693, 122);
            this.combo_estado.Name = "combo_estado";
            this.combo_estado.Size = new System.Drawing.Size(121, 21);
            this.combo_estado.TabIndex = 30;
            this.combo_estado.SelectedIndexChanged += new System.EventHandler(this.combo_estado_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(604, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 16);
            this.label12.TabIndex = 31;
            this.label12.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(693, 152);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 20);
            this.txtDireccion.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 33;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(590, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 16);
            this.label13.TabIndex = 34;
            this.label13.Text = "Grupo Sanguineo:";
            // 
            // combo_tiposangre
            // 
            this.combo_tiposangre.FormattingEnabled = true;
            this.combo_tiposangre.Location = new System.Drawing.Point(721, 205);
            this.combo_tiposangre.Name = "combo_tiposangre";
            this.combo_tiposangre.Size = new System.Drawing.Size(121, 21);
            this.combo_tiposangre.TabIndex = 35;
            // 
            // fecha
            // 
            this.fecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha.Location = new System.Drawing.Point(153, 271);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(243, 22);
            this.fecha.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(598, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 16);
            this.label14.TabIndex = 37;
            this.label14.Text = "Motivo Consulta:";
            // 
            // motivos
            // 
            this.motivos.Location = new System.Drawing.Point(724, 246);
            this.motivos.Multiline = true;
            this.motivos.Name = "motivos";
            this.motivos.Size = new System.Drawing.Size(233, 47);
            this.motivos.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaClinicaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // historiaClinicaToolStripMenuItem
            // 
            this.historiaClinicaToolStripMenuItem.Name = "historiaClinicaToolStripMenuItem";
            this.historiaClinicaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.historiaClinicaToolStripMenuItem.Text = "Historia Clinica";
            this.historiaClinicaToolStripMenuItem.Click += new System.EventHandler(this.historiaClinicaToolStripMenuItem_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(16, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 34);
            this.label15.TabIndex = 41;
            this.label15.Text = "Pacientes";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1042, 586);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.motivos);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.combo_tiposangre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.combo_estado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.txtMovil);
            this.Controls.Add(this.txtFijo);
            this.Controls.Add(this.txtNumeroIdentificacion);
            this.Controls.Add(this.txtSApellido);
            this.Controls.Add(this.txtPApellido);
            this.Controls.Add(this.txtSNombre);
            this.Controls.Add(this.txtPNombre);
            this.Controls.Add(this.cboTiposIdentificacion);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmotivoconsulta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "btnEditar";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load2);
            ((System.ComponentModel.ISupportInitialize)(this.txtmotivoconsulta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView txtmotivoconsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboTiposIdentificacion;
        private System.Windows.Forms.TextBox txtPNombre;
        private System.Windows.Forms.TextBox txtSNombre;
        private System.Windows.Forms.TextBox txtPApellido;
        private System.Windows.Forms.TextBox txtSApellido;
        private System.Windows.Forms.TextBox txtNumeroIdentificacion;
        private System.Windows.Forms.TextBox txtFijo;
        private System.Windows.Forms.TextBox txtMovil;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox combo_estado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox combo_tiposangre;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox motivos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem historiaClinicaToolStripMenuItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

