namespace pryEDSilvaA
{
    partial class frmListaSimple
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
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lbListaSimple = new System.Windows.Forms.ListBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEE = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.gbNB = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pbListaSimple = new System.Windows.Forms.PictureBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.gbEE.SuspendLayout();
            this.gbNB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lbListaSimple);
            this.gbListado.Controls.Add(this.dgvListaSimple);
            this.gbListado.Location = new System.Drawing.Point(12, 213);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(620, 225);
            this.gbListado.TabIndex = 11;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lbListaSimple
            // 
            this.lbListaSimple.FormattingEnabled = true;
            this.lbListaSimple.Location = new System.Drawing.Point(6, 19);
            this.lbListaSimple.Name = "lbListaSimple";
            this.lbListaSimple.Size = new System.Drawing.Size(181, 186);
            this.lbListaSimple.TabIndex = 6;
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(203, 19);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.RowHeadersVisible = false;
            this.dgvListaSimple.Size = new System.Drawing.Size(411, 186);
            this.dgvListaSimple.TabIndex = 5;
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
            // gbEE
            // 
            this.gbEE.Controls.Add(this.cmbCodigo);
            this.gbEE.Controls.Add(this.cmdEliminar);
            this.gbEE.Controls.Add(this.lblCodigo2);
            this.gbEE.Location = new System.Drawing.Point(432, 12);
            this.gbEE.Name = "gbEE";
            this.gbEE.Size = new System.Drawing.Size(200, 178);
            this.gbEE.TabIndex = 10;
            this.gbEE.TabStop = false;
            this.gbEE.Text = "Elemento a eliminar";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(100, 37);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(94, 21);
            this.cmbCodigo.TabIndex = 14;
            this.cmbCodigo.SelectedIndexChanged += new System.EventHandler(this.cmbCodigo_SelectedIndexChanged);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(6, 138);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(188, 32);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
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
            this.gbNB.TabIndex = 9;
            this.gbNB.TabStop = false;
            this.gbNB.Text = "Nuevo Elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(6, 138);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(188, 32);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramite.Location = new System.Drawing.Point(94, 103);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(94, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(122, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
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
            // pbListaSimple
            // 
            this.pbListaSimple.Image = global::pryEDSilvaA.Properties.Resources.images1;
            this.pbListaSimple.Location = new System.Drawing.Point(12, 12);
            this.pbListaSimple.Name = "pbListaSimple";
            this.pbListaSimple.Size = new System.Drawing.Size(187, 178);
            this.pbListaSimple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListaSimple.TabIndex = 8;
            this.pbListaSimple.TabStop = false;
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEE);
            this.Controls.Add(this.gbNB);
            this.Controls.Add(this.pbListaSimple);
            this.Name = "frmListaSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinámica Lineal - Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.gbEE.ResumeLayout(false);
            this.gbEE.PerformLayout();
            this.gbNB.ResumeLayout(false);
            this.gbNB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lbListaSimple;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.GroupBox gbEE;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.GroupBox gbNB;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.PictureBox pbListaSimple;
        private System.Windows.Forms.ComboBox cmbCodigo;
    }
}