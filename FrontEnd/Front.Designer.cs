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
            this.dgvTarjetas = new System.Windows.Forms.DataGridView();
            this.pbRedBus = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBus)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarjetas
            // 
            this.dgvTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarjetas.Location = new System.Drawing.Point(12, 12);
            this.dgvTarjetas.Name = "dgvTarjetas";
            this.dgvTarjetas.Size = new System.Drawing.Size(305, 247);
            this.dgvTarjetas.TabIndex = 4;
            this.dgvTarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarjetas_CellClick_1);
            // 
            // pbRedBus
            // 
            this.pbRedBus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRedBus.BackgroundImage")));
            this.pbRedBus.Location = new System.Drawing.Point(12, 265);
            this.pbRedBus.Name = "pbRedBus";
            this.pbRedBus.Size = new System.Drawing.Size(305, 126);
            this.pbRedBus.TabIndex = 15;
            this.pbRedBus.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(323, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 138);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnDelete.Location = new System.Drawing.Point(323, 156);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 103);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(430, 411);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pbRedBus);
            this.Controls.Add(this.dgvTarjetas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Name = "Front";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRedBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTarjetas;
        private System.Windows.Forms.PictureBox pbRedBus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

