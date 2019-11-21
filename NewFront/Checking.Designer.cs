namespace NewFront
{
    partial class Checking
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
            this.txtNroTar = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblNroTar = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnTarjetas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNroTar
            // 
            this.txtNroTar.Location = new System.Drawing.Point(9, 72);
            this.txtNroTar.Name = "txtNroTar";
            this.txtNroTar.Size = new System.Drawing.Size(116, 20);
            this.txtNroTar.TabIndex = 0;
            this.txtNroTar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtNroTar_MouseClick);
            this.txtNroTar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroTar_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(9, 144);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(116, 20);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDNI_MouseClick);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(9, 337);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(116, 20);
            this.txtSaldo.TabIndex = 2;
            this.txtSaldo.Text = "0";
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(9, 378);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRes
            // 
            this.btnRes.Enabled = false;
            this.btnRes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRes.Location = new System.Drawing.Point(76, 378);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(55, 23);
            this.btnRes.TabIndex = 4;
            this.btnRes.Text = "Pagar";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblNroTar
            // 
            this.lblNroTar.AutoSize = true;
            this.lblNroTar.Location = new System.Drawing.Point(6, 47);
            this.lblNroTar.Name = "lblNroTar";
            this.lblNroTar.Size = new System.Drawing.Size(93, 13);
            this.lblNroTar.TabIndex = 5;
            this.lblNroTar.Text = "Ingrese Tarjeta";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 115);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(75, 13);
            this.lblDNI.TabIndex = 6;
            this.lblDNI.Text = "Ingrese DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(14, 179);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(11, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "-";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 295);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(42, 13);
            this.lblMonto.TabIndex = 8;
            this.lblMonto.Text = "Monto";
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.Maroon;
            this.btnVerify.ForeColor = System.Drawing.Color.Transparent;
            this.btnVerify.Location = new System.Drawing.Point(9, 205);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(122, 60);
            this.btnVerify.TabIndex = 9;
            this.btnVerify.Text = "Verificar";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnTarjetas
            // 
            this.btnTarjetas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTarjetas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTarjetas.Location = new System.Drawing.Point(229, 144);
            this.btnTarjetas.Name = "btnTarjetas";
            this.btnTarjetas.Size = new System.Drawing.Size(75, 180);
            this.btnTarjetas.TabIndex = 10;
            this.btnTarjetas.Text = "Ver Tarjetas";
            this.btnTarjetas.UseVisualStyleBackColor = false;
            this.btnTarjetas.Click += new System.EventHandler(this.btnTarjetas_Click_1);
            // 
            // Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.btnTarjetas);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNroTar);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNroTar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Checking";
            this.Text = "RedBus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNroTar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblNroTar;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnTarjetas;
    }
}

