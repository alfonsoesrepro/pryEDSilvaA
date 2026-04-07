namespace pryEDSilvaA
{
    partial class frmColores
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtColores = new System.Windows.Forms.TextBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.lstColores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(33, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtColores
            // 
            this.txtColores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtColores.Location = new System.Drawing.Point(177, 60);
            this.txtColores.Name = "txtColores";
            this.txtColores.Size = new System.Drawing.Size(175, 20);
            this.txtColores.TabIndex = 1;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(36, 169);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(126, 23);
            this.cmdListar.TabIndex = 2;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(259, 169);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(126, 23);
            this.cmdGrabar.TabIndex = 3;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lstColores
            // 
            this.lstColores.FormattingEnabled = true;
            this.lstColores.Location = new System.Drawing.Point(12, 220);
            this.lstColores.Name = "lstColores";
            this.lstColores.Size = new System.Drawing.Size(373, 212);
            this.lstColores.TabIndex = 4;
            // 
            // frmColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.lstColores);
            this.Controls.Add(this.cmdGrabar);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.txtColores);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmColores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtColores;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.ListBox lstColores;
    }
}