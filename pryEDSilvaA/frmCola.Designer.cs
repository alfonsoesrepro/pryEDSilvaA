namespace pryEDSilvaA
{
    partial class frmCola
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
            this.gbNB = new System.Windows.Forms.GroupBox();
            this.gbEE = new System.Windows.Forms.GroupBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.pbCola = new System.Windows.Forms.PictureBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblRCodigo = new System.Windows.Forms.Label();
            this.lblRNombre = new System.Windows.Forms.Label();
            this.lblRTramite = new System.Windows.Forms.Label();
            this.lbListado = new System.Windows.Forms.ListBox();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNB.SuspendLayout();
            this.gbEE.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNB
            // 
            this.gbNB.Controls.Add(this.cmdAgregar);
            this.gbNB.Controls.Add(this.txtTramite);
            this.gbNB.Controls.Add(this.txtNombre);
            this.gbNB.Controls.Add(this.txtCodigo);
            this.gbNB.Controls.Add(this.lblTramite);
            this.gbNB.Controls.Add(this.lblNombre);
            this.gbNB.Controls.Add(this.lblCodigo);
            this.gbNB.Location = new System.Drawing.Point(215, 12);
            this.gbNB.Name = "gbNB";
            this.gbNB.Size = new System.Drawing.Size(200, 178);
            this.gbNB.TabIndex = 1;
            this.gbNB.TabStop = false;
            this.gbNB.Text = "Nuevo Elemento";
            // 
            // gbEE
            // 
            this.gbEE.Controls.Add(this.lblRTramite);
            this.gbEE.Controls.Add(this.lblRNombre);
            this.gbEE.Controls.Add(this.lblRCodigo);
            this.gbEE.Controls.Add(this.cmdEliminar);
            this.gbEE.Controls.Add(this.textBox1);
            this.gbEE.Controls.Add(this.textBox2);
            this.gbEE.Controls.Add(this.textBox3);
            this.gbEE.Controls.Add(this.lblTramite2);
            this.gbEE.Controls.Add(this.lblNombre2);
            this.gbEE.Controls.Add(this.lblCodigo2);
            this.gbEE.Location = new System.Drawing.Point(432, 12);
            this.gbEE.Name = "gbEE";
            this.gbEE.Size = new System.Drawing.Size(200, 178);
            this.gbEE.TabIndex = 2;
            this.gbEE.TabStop = false;
            this.gbEE.Text = "Elemento Eliminado";
            this.gbEE.Enter += new System.EventHandler(this.gbEE_Enter);
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lbListado);
            this.gbListado.Controls.Add(this.dgvCola);
            this.gbListado.Location = new System.Drawing.Point(12, 213);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(620, 225);
            this.gbListado.TabIndex = 3;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvCola.Location = new System.Drawing.Point(203, 19);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersVisible = false;
            this.dgvCola.Size = new System.Drawing.Size(411, 186);
            this.dgvCola.TabIndex = 5;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 41);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 106);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(45, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Trámite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(122, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(94, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTramite
            // 
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramite.Location = new System.Drawing.Point(94, 103);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(6, 138);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(188, 32);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // pbCola
            // 
            this.pbCola.Image = global::pryEDSilvaA.Properties.Resources.b10;
            this.pbCola.Location = new System.Drawing.Point(12, 12);
            this.pbCola.Name = "pbCola";
            this.pbCola.Size = new System.Drawing.Size(187, 178);
            this.pbCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCola.TabIndex = 0;
            this.pbCola.TabStop = false;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(6, 138);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(188, 32);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(94, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(94, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(122, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(72, 20);
            this.textBox3.TabIndex = 10;
            // 
            // lblTramite2
            // 
            this.lblTramite2.AutoSize = true;
            this.lblTramite2.Location = new System.Drawing.Point(6, 106);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(45, 13);
            this.lblTramite2.TabIndex = 9;
            this.lblTramite2.Text = "Trámite:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(6, 74);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(47, 13);
            this.lblNombre2.TabIndex = 8;
            this.lblNombre2.Text = "Nombre:";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.AutoSize = true;
            this.lblCodigo2.Location = new System.Drawing.Point(6, 41);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo2.TabIndex = 7;
            this.lblCodigo2.Text = "Código:";
            // 
            // lblRCodigo
            // 
            this.lblRCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRCodigo.Location = new System.Drawing.Point(122, 38);
            this.lblRCodigo.Name = "lblRCodigo";
            this.lblRCodigo.Size = new System.Drawing.Size(72, 23);
            this.lblRCodigo.TabIndex = 14;
            this.lblRCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRNombre
            // 
            this.lblRNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRNombre.Location = new System.Drawing.Point(94, 71);
            this.lblRNombre.Name = "lblRNombre";
            this.lblRNombre.Size = new System.Drawing.Size(100, 23);
            this.lblRNombre.TabIndex = 15;
            this.lblRNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRNombre.Click += new System.EventHandler(this.lblRNombre_Click);
            // 
            // lblRTramite
            // 
            this.lblRTramite.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRTramite.Location = new System.Drawing.Point(94, 103);
            this.lblRTramite.Name = "lblRTramite";
            this.lblRTramite.Size = new System.Drawing.Size(100, 23);
            this.lblRTramite.TabIndex = 16;
            this.lblRTramite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbListado
            // 
            this.lbListado.FormattingEnabled = true;
            this.lbListado.Location = new System.Drawing.Point(6, 19);
            this.lbListado.Name = "lbListado";
            this.lbListado.Size = new System.Drawing.Size(181, 186);
            this.lbListado.TabIndex = 6;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 137;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 137;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.Width = 137;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEE);
            this.Controls.Add(this.gbNB);
            this.Controls.Add(this.pbCola);
            this.Name = "frmCola";
            this.Text = "Estructura Dinámica Lineal - Cola";
            this.gbNB.ResumeLayout(false);
            this.gbNB.PerformLayout();
            this.gbEE.ResumeLayout(false);
            this.gbEE.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCola;
        private System.Windows.Forms.GroupBox gbNB;
        private System.Windows.Forms.GroupBox gbEE;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblRCodigo;
        private System.Windows.Forms.Label lblRTramite;
        private System.Windows.Forms.Label lblRNombre;
        private System.Windows.Forms.ListBox lbListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
    }
}