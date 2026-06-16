namespace pryEDSilvaA.Formularios
{
    partial class frmConsultasConOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultasConOperaciones));
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblConsultaSQL = new System.Windows.Forms.Label();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(12, 27);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(200, 13);
            this.lblOperacion.TabIndex = 0;
            this.lblOperacion.Text = "Operación a realizar en la base de datos:";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(218, 19);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(396, 21);
            this.cmbOperacion.TabIndex = 1;
            // 
            // lblConsultaSQL
            // 
            this.lblConsultaSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsultaSQL.Location = new System.Drawing.Point(12, 54);
            this.lblConsultaSQL.Name = "lblConsultaSQL";
            this.lblConsultaSQL.Size = new System.Drawing.Size(721, 106);
            this.lblConsultaSQL.TabIndex = 3;
            this.lblConsultaSQL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 176);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(732, 262);
            this.dgvTabla.TabIndex = 8;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(631, 12);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(113, 23);
            this.cmdListar.TabIndex = 9;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // frmConsultasConOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.lblConsultaSQL);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.lblOperacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultasConOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblConsultaSQL;
        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button cmdListar;
    }
}