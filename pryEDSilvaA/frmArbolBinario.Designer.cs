namespace pryEDSilvaA
{
    partial class frmArbolBinario
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
            this.dgvArbolBinario = new System.Windows.Forms.DataGridView();
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
            this.pbListaDoble = new System.Windows.Forms.PictureBox();
            this.twArbolBinario = new System.Windows.Forms.TreeView();
            this.cmdEquilibrar = new System.Windows.Forms.Button();
            this.optInOrden = new System.Windows.Forms.RadioButton();
            this.optPreOrden = new System.Windows.Forms.RadioButton();
            this.optPostOrden = new System.Windows.Forms.RadioButton();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).BeginInit();
            this.gbEE.SuspendLayout();
            this.gbNB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDoble)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.optPostOrden);
            this.gbListado.Controls.Add(this.optPreOrden);
            this.gbListado.Controls.Add(this.optInOrden);
            this.gbListado.Controls.Add(this.dgvArbolBinario);
            this.gbListado.Location = new System.Drawing.Point(12, 213);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(620, 225);
            this.gbListado.TabIndex = 20;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado del árbol";
            // 
            // dgvArbolBinario
            // 
            this.dgvArbolBinario.AllowUserToAddRows = false;
            this.dgvArbolBinario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbolBinario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvArbolBinario.Location = new System.Drawing.Point(203, 19);
            this.dgvArbolBinario.Name = "dgvArbolBinario";
            this.dgvArbolBinario.ReadOnly = true;
            this.dgvArbolBinario.RowHeadersVisible = false;
            this.dgvArbolBinario.Size = new System.Drawing.Size(411, 186);
            this.dgvArbolBinario.TabIndex = 5;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 137;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.ReadOnly = true;
            this.clmNombre.Width = 137;
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Trámite";
            this.clmTramite.Name = "clmTramite";
            this.clmTramite.ReadOnly = true;
            this.clmTramite.Width = 137;
            // 
            // gbEE
            // 
            this.gbEE.Controls.Add(this.cmbCodigo);
            this.gbEE.Controls.Add(this.cmdEliminar);
            this.gbEE.Controls.Add(this.lblCodigo2);
            this.gbEE.Location = new System.Drawing.Point(432, 12);
            this.gbEE.Name = "gbEE";
            this.gbEE.Size = new System.Drawing.Size(200, 111);
            this.gbEE.TabIndex = 19;
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
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(6, 71);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(188, 32);
            this.cmdEliminar.TabIndex = 13;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
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
            this.gbNB.TabIndex = 18;
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
            // 
            // txtTramite
            // 
            this.txtTramite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTramite.Location = new System.Drawing.Point(94, 103);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(94, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(122, 38);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(72, 20);
            this.txtCodigo.TabIndex = 3;
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
            // pbListaDoble
            // 
            this.pbListaDoble.Image = global::pryEDSilvaA.Properties.Resources.listadoblementeencadenada_portada;
            this.pbListaDoble.Location = new System.Drawing.Point(12, 12);
            this.pbListaDoble.Name = "pbListaDoble";
            this.pbListaDoble.Size = new System.Drawing.Size(187, 178);
            this.pbListaDoble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbListaDoble.TabIndex = 17;
            this.pbListaDoble.TabStop = false;
            // 
            // twArbolBinario
            // 
            this.twArbolBinario.Location = new System.Drawing.Point(12, 12);
            this.twArbolBinario.Name = "twArbolBinario";
            this.twArbolBinario.Size = new System.Drawing.Size(187, 178);
            this.twArbolBinario.TabIndex = 7;
            // 
            // cmdEquilibrar
            // 
            this.cmdEquilibrar.Location = new System.Drawing.Point(438, 150);
            this.cmdEquilibrar.Name = "cmdEquilibrar";
            this.cmdEquilibrar.Size = new System.Drawing.Size(188, 32);
            this.cmdEquilibrar.TabIndex = 21;
            this.cmdEquilibrar.Text = "Equilibrar";
            this.cmdEquilibrar.UseVisualStyleBackColor = true;
            // 
            // optInOrden
            // 
            this.optInOrden.AutoSize = true;
            this.optInOrden.Location = new System.Drawing.Point(27, 48);
            this.optInOrden.Name = "optInOrden";
            this.optInOrden.Size = new System.Drawing.Size(66, 17);
            this.optInOrden.TabIndex = 6;
            this.optInOrden.TabStop = true;
            this.optInOrden.Text = "In-Orden";
            this.optInOrden.UseVisualStyleBackColor = true;
            // 
            // optPreOrden
            // 
            this.optPreOrden.AutoSize = true;
            this.optPreOrden.Location = new System.Drawing.Point(27, 99);
            this.optPreOrden.Name = "optPreOrden";
            this.optPreOrden.Size = new System.Drawing.Size(73, 17);
            this.optPreOrden.TabIndex = 7;
            this.optPreOrden.TabStop = true;
            this.optPreOrden.Text = "Pre-Orden";
            this.optPreOrden.UseVisualStyleBackColor = true;
            // 
            // optPostOrden
            // 
            this.optPostOrden.AutoSize = true;
            this.optPostOrden.Location = new System.Drawing.Point(27, 150);
            this.optPostOrden.Name = "optPostOrden";
            this.optPostOrden.Size = new System.Drawing.Size(78, 17);
            this.optPostOrden.TabIndex = 8;
            this.optPostOrden.TabStop = true;
            this.optPostOrden.Text = "Post-Orden";
            this.optPostOrden.UseVisualStyleBackColor = true;
            // 
            // frmArbolBinario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.cmdEquilibrar);
            this.Controls.Add(this.twArbolBinario);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbEE);
            this.Controls.Add(this.gbNB);
            this.Controls.Add(this.pbListaDoble);
            this.Name = "frmArbolBinario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura No Lineal - Árbol Binario";
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbolBinario)).EndInit();
            this.gbEE.ResumeLayout(false);
            this.gbEE.PerformLayout();
            this.gbNB.ResumeLayout(false);
            this.gbNB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbListaDoble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvArbolBinario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.GroupBox gbEE;
        private System.Windows.Forms.ComboBox cmbCodigo;
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
        private System.Windows.Forms.PictureBox pbListaDoble;
        private System.Windows.Forms.TreeView twArbolBinario;
        private System.Windows.Forms.Button cmdEquilibrar;
        private System.Windows.Forms.RadioButton optPostOrden;
        private System.Windows.Forms.RadioButton optPreOrden;
        private System.Windows.Forms.RadioButton optInOrden;
    }
}