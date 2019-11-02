namespace FrontEnd
{
    partial class Front
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Front));
            this.btnGrabar = new System.Windows.Forms.Button();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.btnDescontar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAddRes = new System.Windows.Forms.TextBox();
            this.pbRedBus = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabar
            // 
            this.btnGrabar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGrabar.Location = new System.Drawing.Point(162, 132);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(87, 23);
            this.btnGrabar.TabIndex = 0;
            this.btnGrabar.Text = "Agregar Persona";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(12, 41);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(116, 20);
            this.txtNro.TabIndex = 2;
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(265, 78);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.Size = new System.Drawing.Size(327, 150);
            this.dgvTarjetas.TabIndex = 4;
            this.dgvTarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarjetas_CellClick_1);
            this.dgvTarjetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarjetas_CellContentClick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(9, 303);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(54, 13);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(9, 25);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(71, 13);
            this.lbNumero.TabIndex = 6;
            this.lbNumero.Text = "Nro Tarjeta";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(12, 94);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(116, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(9, 78);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 13);
            this.lblSaldo.TabIndex = 11;
            this.lblSaldo.Text = "Saldo";
            // 
            // btnDescontar
            // 
            this.btnDescontar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDescontar.Location = new System.Drawing.Point(463, 49);
            this.btnDescontar.Name = "btnDescontar";
            this.btnDescontar.Size = new System.Drawing.Size(87, 23);
            this.btnDescontar.TabIndex = 12;
            this.btnDescontar.Text = "Descontar";
            this.btnDescontar.UseVisualStyleBackColor = true;
            this.btnDescontar.Click += new System.EventHandler(this.BtnDescontar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAgregar.Location = new System.Drawing.Point(316, 49);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // txtAddRes
            // 
            this.txtAddRes.Location = new System.Drawing.Point(374, 25);
            this.txtAddRes.Name = "txtAddRes";
            this.txtAddRes.Size = new System.Drawing.Size(116, 20);
            this.txtAddRes.TabIndex = 14;
            // 
            // pbRedBus
            // 
            this.pbRedBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRedBus.BackgroundImage")));
            this.pbRedBus.Location = new System.Drawing.Point(265, 234);
            this.pbRedBus.Name = "pbRedBus";
            this.pbRedBus.Size = new System.Drawing.Size(327, 126);
            this.pbRedBus.TabIndex = 15;
            this.pbRedBus.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(162, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 55);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(604, 362);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pbRedBus);
            this.Controls.Add(this.txtAddRes);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDescontar);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lbNumero);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dgvTarjetas);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.btnGrabar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Front";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Button btnDescontar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtAddRes;
        private System.Windows.Forms.PictureBox pbRedBus;
        private System.Windows.Forms.Button btnUpdate;
    }
}

