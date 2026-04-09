namespace pryEDSilvaA
{
    partial class frmCarreras
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
            this.lstCarreras = new System.Windows.Forms.ListBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.cmdListar = new System.Windows.Forms.Button();
            this.txtCarreras = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCarreras
            // 
            this.lstCarreras.FormattingEnabled = true;
            this.lstCarreras.Location = new System.Drawing.Point(19, 221);
            this.lstCarreras.Name = "lstCarreras";
            this.lstCarreras.Size = new System.Drawing.Size(373, 212);
            this.lstCarreras.TabIndex = 14;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(266, 170);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(126, 23);
            this.cmdGrabar.TabIndex = 13;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(43, 170);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(126, 23);
            this.cmdListar.TabIndex = 12;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // txtCarreras
            // 
            this.txtCarreras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCarreras.Location = new System.Drawing.Point(184, 61);
            this.txtCarreras.Name = "txtCarreras";
            this.txtCarreras.Size = new System.Drawing.Size(175, 20);
            this.txtCarreras.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre:";
            // 
            // frmCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.lstCarreras);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtCarreras);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmCarreras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carreras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCarreras;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.TextBox txtCarreras;
        private System.Windows.Forms.Label lblNombre;
    }
}