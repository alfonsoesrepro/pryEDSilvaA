namespace pryEDSilvaA.Formularios
{
    partial class frmGrafo
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
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.cmdVerTodos = new System.Windows.Forms.Button();
            this.cmdListarOrigenes = new System.Windows.Forms.Button();
            this.cmbDestinoListado = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmdListarDestinos = new System.Windows.Forms.Button();
            this.cmbOrigenListado = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.lblPrecioConsulta = new System.Windows.Forms.Label();
            this.cmbDestinoConsulta = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.lblDestino2 = new System.Windows.Forms.Label();
            this.cmbOrigenConsulta = new System.Windows.Forms.ComboBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.lblOrigen2 = new System.Windows.Forms.Label();
            this.gbCarga = new System.Windows.Forms.GroupBox();
            this.cmdBorrarTodo = new System.Windows.Forms.Button();
            this.cmbDestinoCarga = new System.Windows.Forms.ComboBox();
            this.cmbOrigenCarga = new System.Windows.Forms.ComboBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtPrecioCarga = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.pbGrafo = new System.Windows.Forms.PictureBox();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.gbConsulta.SuspendLayout();
            this.gbCarga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(14, 138);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(100, 32);
            this.cmdConsultar.TabIndex = 27;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.cmdVerTodos);
            this.gbListado.Controls.Add(this.cmdListarOrigenes);
            this.gbListado.Controls.Add(this.cmbDestinoListado);
            this.gbListado.Controls.Add(this.lblHasta);
            this.gbListado.Controls.Add(this.cmdListarDestinos);
            this.gbListado.Controls.Add(this.cmbOrigenListado);
            this.gbListado.Controls.Add(this.lblDesde);
            this.gbListado.Controls.Add(this.dgvGrafo);
            this.gbListado.Location = new System.Drawing.Point(12, 211);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(740, 303);
            this.gbListado.TabIndex = 26;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listar viajes .....";
            // 
            // cmdVerTodos
            // 
            this.cmdVerTodos.Location = new System.Drawing.Point(628, 32);
            this.cmdVerTodos.Name = "cmdVerTodos";
            this.cmdVerTodos.Size = new System.Drawing.Size(106, 23);
            this.cmdVerTodos.TabIndex = 12;
            this.cmdVerTodos.Text = "Ver todos los viajes";
            this.cmdVerTodos.UseVisualStyleBackColor = true;
            // 
            // cmdListarOrigenes
            // 
            this.cmdListarOrigenes.Location = new System.Drawing.Point(483, 32);
            this.cmdListarOrigenes.Name = "cmdListarOrigenes";
            this.cmdListarOrigenes.Size = new System.Drawing.Size(98, 23);
            this.cmdListarOrigenes.TabIndex = 11;
            this.cmdListarOrigenes.Text = "Listar Orígenes";
            this.cmdListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoListado
            // 
            this.cmbDestinoListado.FormattingEnabled = true;
            this.cmbDestinoListado.Location = new System.Drawing.Point(371, 34);
            this.cmbDestinoListado.Name = "cmbDestinoListado";
            this.cmbDestinoListado.Size = new System.Drawing.Size(96, 21);
            this.cmbDestinoListado.TabIndex = 10;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(319, 38);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 9;
            this.lblHasta.Text = "Hasta:";
            // 
            // cmdListarDestinos
            // 
            this.cmdListarDestinos.Location = new System.Drawing.Point(177, 33);
            this.cmdListarDestinos.Name = "cmdListarDestinos";
            this.cmdListarDestinos.Size = new System.Drawing.Size(98, 23);
            this.cmdListarDestinos.TabIndex = 8;
            this.cmdListarDestinos.Text = "Listar Destinos";
            this.cmdListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbOrigenListado
            // 
            this.cmbOrigenListado.FormattingEnabled = true;
            this.cmbOrigenListado.Location = new System.Drawing.Point(66, 34);
            this.cmbOrigenListado.Name = "cmbOrigenListado";
            this.cmbOrigenListado.Size = new System.Drawing.Size(96, 21);
            this.cmbOrigenListado.TabIndex = 7;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(6, 38);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.AllowUserToAddRows = false;
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(6, 83);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.ReadOnly = true;
            this.dgvGrafo.RowHeadersVisible = false;
            this.dgvGrafo.Size = new System.Drawing.Size(728, 210);
            this.dgvGrafo.TabIndex = 5;
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.cmdConsultar);
            this.gbConsulta.Controls.Add(this.lblPrecioConsulta);
            this.gbConsulta.Controls.Add(this.cmbDestinoConsulta);
            this.gbConsulta.Controls.Add(this.textBox1);
            this.gbConsulta.Controls.Add(this.textBox2);
            this.gbConsulta.Controls.Add(this.lblPrecio2);
            this.gbConsulta.Controls.Add(this.lblDestino2);
            this.gbConsulta.Controls.Add(this.cmbOrigenConsulta);
            this.gbConsulta.Controls.Add(this.cmdBorrar);
            this.gbConsulta.Controls.Add(this.lblOrigen2);
            this.gbConsulta.Location = new System.Drawing.Point(481, 10);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(271, 178);
            this.gbConsulta.TabIndex = 25;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos";
            // 
            // lblPrecioConsulta
            // 
            this.lblPrecioConsulta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecioConsulta.Location = new System.Drawing.Point(94, 103);
            this.lblPrecioConsulta.Name = "lblPrecioConsulta";
            this.lblPrecioConsulta.Size = new System.Drawing.Size(165, 23);
            this.lblPrecioConsulta.TabIndex = 22;
            this.lblPrecioConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbDestinoConsulta
            // 
            this.cmbDestinoConsulta.FormattingEnabled = true;
            this.cmbDestinoConsulta.Location = new System.Drawing.Point(94, 70);
            this.cmbDestinoConsulta.Name = "cmbDestinoConsulta";
            this.cmbDestinoConsulta.Size = new System.Drawing.Size(165, 21);
            this.cmbDestinoConsulta.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(94, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(94, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 19;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.AutoSize = true;
            this.lblPrecio2.Location = new System.Drawing.Point(11, 106);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio2.TabIndex = 18;
            this.lblPrecio2.Text = "Precio:";
            // 
            // lblDestino2
            // 
            this.lblDestino2.AutoSize = true;
            this.lblDestino2.Location = new System.Drawing.Point(11, 74);
            this.lblDestino2.Name = "lblDestino2";
            this.lblDestino2.Size = new System.Drawing.Size(46, 13);
            this.lblDestino2.TabIndex = 17;
            this.lblDestino2.Text = "Destino:";
            // 
            // cmbOrigenConsulta
            // 
            this.cmbOrigenConsulta.FormattingEnabled = true;
            this.cmbOrigenConsulta.Location = new System.Drawing.Point(94, 37);
            this.cmbOrigenConsulta.Name = "cmbOrigenConsulta";
            this.cmbOrigenConsulta.Size = new System.Drawing.Size(165, 21);
            this.cmbOrigenConsulta.TabIndex = 14;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(159, 138);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(100, 32);
            this.cmdBorrar.TabIndex = 13;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            // 
            // lblOrigen2
            // 
            this.lblOrigen2.AutoSize = true;
            this.lblOrigen2.Location = new System.Drawing.Point(11, 41);
            this.lblOrigen2.Name = "lblOrigen2";
            this.lblOrigen2.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen2.TabIndex = 7;
            this.lblOrigen2.Text = "Origen:";
            // 
            // gbCarga
            // 
            this.gbCarga.Controls.Add(this.cmdBorrarTodo);
            this.gbCarga.Controls.Add(this.cmbDestinoCarga);
            this.gbCarga.Controls.Add(this.cmbOrigenCarga);
            this.gbCarga.Controls.Add(this.cmdCargar);
            this.gbCarga.Controls.Add(this.txtPrecioCarga);
            this.gbCarga.Controls.Add(this.txtNombre);
            this.gbCarga.Controls.Add(this.txtCodigo);
            this.gbCarga.Controls.Add(this.lblPrecio);
            this.gbCarga.Controls.Add(this.lblDestino);
            this.gbCarga.Controls.Add(this.lblOrigen);
            this.gbCarga.Location = new System.Drawing.Point(215, 10);
            this.gbCarga.Name = "gbCarga";
            this.gbCarga.Size = new System.Drawing.Size(247, 178);
            this.gbCarga.TabIndex = 24;
            this.gbCarga.TabStop = false;
            this.gbCarga.Text = "Carga de Datos";
            // 
            // cmdBorrarTodo
            // 
            this.cmdBorrarTodo.Location = new System.Drawing.Point(14, 138);
            this.cmdBorrarTodo.Name = "cmdBorrarTodo";
            this.cmdBorrarTodo.Size = new System.Drawing.Size(100, 32);
            this.cmdBorrarTodo.TabIndex = 17;
            this.cmdBorrarTodo.Text = "Borrar Todo";
            this.cmdBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoCarga
            // 
            this.cmbDestinoCarga.FormattingEnabled = true;
            this.cmbDestinoCarga.Location = new System.Drawing.Point(94, 70);
            this.cmbDestinoCarga.Name = "cmbDestinoCarga";
            this.cmbDestinoCarga.Size = new System.Drawing.Size(137, 21);
            this.cmbDestinoCarga.TabIndex = 16;
            // 
            // cmbOrigenCarga
            // 
            this.cmbOrigenCarga.FormattingEnabled = true;
            this.cmbOrigenCarga.Location = new System.Drawing.Point(94, 37);
            this.cmbOrigenCarga.Name = "cmbOrigenCarga";
            this.cmbOrigenCarga.Size = new System.Drawing.Size(137, 21);
            this.cmbOrigenCarga.TabIndex = 15;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(131, 138);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(100, 32);
            this.cmdCargar.TabIndex = 6;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtPrecioCarga
            // 
            this.txtPrecioCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCarga.Location = new System.Drawing.Point(94, 103);
            this.txtPrecioCarga.Name = "txtPrecioCarga";
            this.txtPrecioCarga.Size = new System.Drawing.Size(137, 20);
            this.txtPrecioCarga.TabIndex = 5;
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
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 106);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(11, 74);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(46, 13);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(11, 41);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(41, 13);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // pbGrafo
            // 
            this.pbGrafo.Image = global::pryEDSilvaA.Properties.Resources.images__3_;
            this.pbGrafo.Location = new System.Drawing.Point(12, 10);
            this.pbGrafo.Name = "pbGrafo";
            this.pbGrafo.Size = new System.Drawing.Size(187, 178);
            this.pbGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrafo.TabIndex = 23;
            this.pbGrafo.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 521);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCarga);
            this.Controls.Add(this.pbGrafo);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura No Lineal - Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gbListado.ResumeLayout(false);
            this.gbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            this.gbCarga.ResumeLayout(false);
            this.gbCarga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.ComboBox cmbOrigenConsulta;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Label lblOrigen2;
        private System.Windows.Forms.GroupBox gbCarga;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtPrecioCarga;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pbGrafo;
        private System.Windows.Forms.ComboBox cmbDestinoCarga;
        private System.Windows.Forms.ComboBox cmbOrigenCarga;
        private System.Windows.Forms.Button cmdBorrarTodo;
        private System.Windows.Forms.Label lblPrecioConsulta;
        private System.Windows.Forms.ComboBox cmbDestinoConsulta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.Label lblDestino2;
        private System.Windows.Forms.Button cmdListarDestinos;
        private System.Windows.Forms.ComboBox cmbOrigenListado;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Button cmdListarOrigenes;
        private System.Windows.Forms.ComboBox cmbDestinoListado;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Button cmdVerTodos;
    }
}