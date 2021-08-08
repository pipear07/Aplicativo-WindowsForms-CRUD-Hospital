namespace nombre
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.btn_buscador = new System.Windows.Forms.Button();
            this.dbBuscaPersona = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblIdPersona = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbBuscaPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cedula:";
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(439, 73);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(116, 20);
            this.txtbuscador.TabIndex = 1;
            // 
            // btn_buscador
            // 
            this.btn_buscador.Location = new System.Drawing.Point(424, 114);
            this.btn_buscador.Name = "btn_buscador";
            this.btn_buscador.Size = new System.Drawing.Size(131, 31);
            this.btn_buscador.TabIndex = 2;
            this.btn_buscador.Text = "Buscar";
            this.btn_buscador.UseVisualStyleBackColor = true;
            this.btn_buscador.Click += new System.EventHandler(this.btn_buscador_Click);
            // 
            // dbBuscaPersona
            // 
            this.dbBuscaPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBuscaPersona.Location = new System.Drawing.Point(3, 173);
            this.dbBuscaPersona.Name = "dbBuscaPersona";
            this.dbBuscaPersona.Size = new System.Drawing.Size(974, 167);
            this.dbBuscaPersona.TabIndex = 3;
            this.dbBuscaPersona.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbBuscaPersona_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "N* Registro:";
            // 
            // lblIdPersona
            // 
            this.lblIdPersona.AutoSize = true;
            this.lblIdPersona.Location = new System.Drawing.Point(709, 9);
            this.lblIdPersona.Name = "lblIdPersona";
            this.lblIdPersona.Size = new System.Drawing.Size(41, 13);
            this.lblIdPersona.TabIndex = 29;
            this.lblIdPersona.Text = "label10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscador de Pacientes";
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 381);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblIdPersona);
            this.Controls.Add(this.dbBuscaPersona);
            this.Controls.Add(this.btn_buscador);
            this.Controls.Add(this.txtbuscador);
            this.Controls.Add(this.label1);
            this.Name = "Buscador";
            this.Text = "Buscador";
            this.Load += new System.EventHandler(this.Buscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBuscaPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Button btn_buscador;
        private System.Windows.Forms.DataGridView dbBuscaPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIdPersona;
        private System.Windows.Forms.Label label2;
    }
}