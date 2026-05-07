namespace pryEDSilvaA
{
    partial class frmDatosDesarrollador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatosDesarrollador));
            this.pbDesarrollador = new System.Windows.Forms.PictureBox();
            this.lblDesarrollador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDesarrollador)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDesarrollador
            // 
            this.pbDesarrollador.Image = global::pryEDSilvaA.Properties.Resources._61tOwAlN1iL__AC_SL1497_;
            this.pbDesarrollador.Location = new System.Drawing.Point(12, 12);
            this.pbDesarrollador.Name = "pbDesarrollador";
            this.pbDesarrollador.Size = new System.Drawing.Size(471, 297);
            this.pbDesarrollador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDesarrollador.TabIndex = 0;
            this.pbDesarrollador.TabStop = false;
            // 
            // lblDesarrollador
            // 
            this.lblDesarrollador.AutoSize = true;
            this.lblDesarrollador.Location = new System.Drawing.Point(123, 336);
            this.lblDesarrollador.Name = "lblDesarrollador";
            this.lblDesarrollador.Size = new System.Drawing.Size(250, 26);
            this.lblDesarrollador.TabIndex = 1;
            this.lblDesarrollador.Text = "© 2026 McLOVIN. Todos los derechos reservados.\r\n\r\n";
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 371);
            this.Controls.Add(this.lblDesarrollador);
            this.Controls.Add(this.pbDesarrollador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pbDesarrollador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDesarrollador;
        private System.Windows.Forms.Label lblDesarrollador;
    }
}