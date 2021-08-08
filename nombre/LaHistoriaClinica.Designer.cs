namespace nombre
{
    partial class LaHistoriaClinica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtresumenclinico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtevoluciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.visor_historia = new System.Windows.Forms.DataGridView();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblpaciente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visor_historia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtresumenclinico
            // 
            this.txtresumenclinico.Location = new System.Drawing.Point(68, 99);
            this.txtresumenclinico.Multiline = true;
            this.txtresumenclinico.Name = "txtresumenclinico";
            this.txtresumenclinico.Size = new System.Drawing.Size(187, 59);
            this.txtresumenclinico.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resumen Clinico";
            // 
            // txtevoluciones
            // 
            this.txtevoluciones.Location = new System.Drawing.Point(457, 83);
            this.txtevoluciones.Multiline = true;
            this.txtevoluciones.Name = "txtevoluciones";
            this.txtevoluciones.Size = new System.Drawing.Size(232, 95);
            this.txtevoluciones.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Evoluciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Codigo Historial #";
            // 
            // visor_historia
            // 
            this.visor_historia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visor_historia.Location = new System.Drawing.Point(0, 196);
            this.visor_historia.Name = "visor_historia";
            this.visor_historia.Size = new System.Drawing.Size(762, 150);
            this.visor_historia.TabIndex = 8;
            this.visor_historia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.visor_historia_CellClick);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(482, 56);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(35, 13);
            this.lblcodigo.TabIndex = 7;
            this.lblcodigo.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblpaciente
            // 
            this.lblpaciente.AutoSize = true;
            this.lblpaciente.Location = new System.Drawing.Point(416, 9);
            this.lblpaciente.Name = "lblpaciente";
            this.lblpaciente.Size = new System.Drawing.Size(77, 13);
            this.lblpaciente.TabIndex = 15;
            this.lblpaciente.Text = "Id del paciente";
            // 
            // LaHistoriaClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 402);
            this.Controls.Add(this.lblpaciente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtresumenclinico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtevoluciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.visor_historia);
            this.Controls.Add(this.lblcodigo);
            this.Name = "LaHistoriaClinica";
            this.Text = "LaHistoriaClinica";
            this.Load += new System.EventHandler(this.LaHistoriaClinica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.visor_historia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresumenclinico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtevoluciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView visor_historia;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblpaciente;
    }
}