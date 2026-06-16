namespace pryEDSilvaA.Formularios
{
    partial class frmConsultaSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaSQL));
            this.lblConsultaSQL = new System.Windows.Forms.Label();
            this.txtConsultaSQL = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsultaSQL
            // 
            this.lblConsultaSQL.AutoSize = true;
            this.lblConsultaSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSQL.Location = new System.Drawing.Point(12, 25);
            this.lblConsultaSQL.Name = "lblConsultaSQL";
            this.lblConsultaSQL.Size = new System.Drawing.Size(185, 25);
            this.lblConsultaSQL.TabIndex = 4;
            this.lblConsultaSQL.Text = "Consulta en SQL:";
            // 
            // txtConsultaSQL
            // 
            this.txtConsultaSQL.Location = new System.Drawing.Point(12, 53);
            this.txtConsultaSQL.Multiline = true;
            this.txtConsultaSQL.Name = "txtConsultaSQL";
            this.txtConsultaSQL.Size = new System.Drawing.Size(732, 131);
            this.txtConsultaSQL.TabIndex = 5;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(631, 190);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(113, 23);
            this.cmdListar.TabIndex = 6;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 219);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(732, 219);
            this.dgvTabla.TabIndex = 7;
            // 
            // frmConsultaSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.dgvTabla);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtConsultaSQL);
            this.Controls.Add(this.lblConsultaSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en la Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConsultaSQL;
        private System.Windows.Forms.TextBox txtConsultaSQL;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView dgvTabla;
    }
}