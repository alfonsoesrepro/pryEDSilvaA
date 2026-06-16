namespace pryEDSilvaA.Formularios
{
    partial class frmOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaciones));
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.gbSELECT = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdProyeccionMulti = new System.Windows.Forms.Button();
            this.cmdProyeccionSimple = new System.Windows.Forms.Button();
            this.gbWHERE = new System.Windows.Forms.GroupBox();
            this.cmdSeleccionConvolucion = new System.Windows.Forms.Button();
            this.cmdSeleccionMulti = new System.Windows.Forms.Button();
            this.cmdSeleccionSimple = new System.Windows.Forms.Button();
            this.gbAlgebraRelacional = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.gbSELECT.SuspendLayout();
            this.gbWHERE.SuspendLayout();
            this.gbAlgebraRelacional.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.AllowUserToAddRows = false;
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Location = new System.Drawing.Point(12, 12);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.ReadOnly = true;
            this.dgvTabla.RowHeadersVisible = false;
            this.dgvTabla.Size = new System.Drawing.Size(732, 301);
            this.dgvTabla.TabIndex = 1;
            // 
            // gbSELECT
            // 
            this.gbSELECT.Controls.Add(this.cmdJuntar);
            this.gbSELECT.Controls.Add(this.cmdProyeccionMulti);
            this.gbSELECT.Controls.Add(this.cmdProyeccionSimple);
            this.gbSELECT.Location = new System.Drawing.Point(12, 328);
            this.gbSELECT.Name = "gbSELECT";
            this.gbSELECT.Size = new System.Drawing.Size(220, 110);
            this.gbSELECT.TabIndex = 2;
            this.gbSELECT.TabStop = false;
            this.gbSELECT.Text = "Operaciones de Proyección - SELECT";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(6, 80);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(208, 23);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            // 
            // cmdProyeccionMulti
            // 
            this.cmdProyeccionMulti.Location = new System.Drawing.Point(6, 51);
            this.cmdProyeccionMulti.Name = "cmdProyeccionMulti";
            this.cmdProyeccionMulti.Size = new System.Drawing.Size(208, 23);
            this.cmdProyeccionMulti.TabIndex = 1;
            this.cmdProyeccionMulti.Text = "Proyección multiatributo";
            this.cmdProyeccionMulti.UseVisualStyleBackColor = true;
            // 
            // cmdProyeccionSimple
            // 
            this.cmdProyeccionSimple.Location = new System.Drawing.Point(6, 22);
            this.cmdProyeccionSimple.Name = "cmdProyeccionSimple";
            this.cmdProyeccionSimple.Size = new System.Drawing.Size(208, 23);
            this.cmdProyeccionSimple.TabIndex = 0;
            this.cmdProyeccionSimple.Text = "Proyección simple";
            this.cmdProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // gbWHERE
            // 
            this.gbWHERE.Controls.Add(this.cmdSeleccionConvolucion);
            this.gbWHERE.Controls.Add(this.cmdSeleccionMulti);
            this.gbWHERE.Controls.Add(this.cmdSeleccionSimple);
            this.gbWHERE.Location = new System.Drawing.Point(268, 328);
            this.gbWHERE.Name = "gbWHERE";
            this.gbWHERE.Size = new System.Drawing.Size(220, 110);
            this.gbWHERE.TabIndex = 3;
            this.gbWHERE.TabStop = false;
            this.gbWHERE.Text = "Operaciones de Selección - WHERE";
            // 
            // cmdSeleccionConvolucion
            // 
            this.cmdSeleccionConvolucion.Location = new System.Drawing.Point(6, 80);
            this.cmdSeleccionConvolucion.Name = "cmdSeleccionConvolucion";
            this.cmdSeleccionConvolucion.Size = new System.Drawing.Size(208, 23);
            this.cmdSeleccionConvolucion.TabIndex = 5;
            this.cmdSeleccionConvolucion.Text = "Selección por convolución";
            this.cmdSeleccionConvolucion.UseVisualStyleBackColor = true;
            // 
            // cmdSeleccionMulti
            // 
            this.cmdSeleccionMulti.Location = new System.Drawing.Point(6, 51);
            this.cmdSeleccionMulti.Name = "cmdSeleccionMulti";
            this.cmdSeleccionMulti.Size = new System.Drawing.Size(208, 23);
            this.cmdSeleccionMulti.TabIndex = 4;
            this.cmdSeleccionMulti.Text = "Selección multiatributo";
            this.cmdSeleccionMulti.UseVisualStyleBackColor = true;
            // 
            // cmdSeleccionSimple
            // 
            this.cmdSeleccionSimple.Location = new System.Drawing.Point(6, 22);
            this.cmdSeleccionSimple.Name = "cmdSeleccionSimple";
            this.cmdSeleccionSimple.Size = new System.Drawing.Size(208, 23);
            this.cmdSeleccionSimple.TabIndex = 3;
            this.cmdSeleccionSimple.Text = "Selección simple";
            this.cmdSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // gbAlgebraRelacional
            // 
            this.gbAlgebraRelacional.Controls.Add(this.cmdDiferencia);
            this.gbAlgebraRelacional.Controls.Add(this.cmdInterseccion);
            this.gbAlgebraRelacional.Controls.Add(this.cmdUnion);
            this.gbAlgebraRelacional.Location = new System.Drawing.Point(524, 328);
            this.gbAlgebraRelacional.Name = "gbAlgebraRelacional";
            this.gbAlgebraRelacional.Size = new System.Drawing.Size(220, 110);
            this.gbAlgebraRelacional.TabIndex = 4;
            this.gbAlgebraRelacional.TabStop = false;
            this.gbAlgebraRelacional.Text = "Operaciones Algebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(6, 80);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(208, 23);
            this.cmdDiferencia.TabIndex = 5;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(6, 51);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(208, 23);
            this.cmdInterseccion.TabIndex = 4;
            this.cmdInterseccion.Text = "Intersección";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(6, 22);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(208, 23);
            this.cmdUnion.TabIndex = 3;
            this.cmdUnion.Text = "Unión";
            this.cmdUnion.UseVisualStyleBackColor = true;
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.gbAlgebraRelacional);
            this.Controls.Add(this.gbWHERE);
            this.Controls.Add(this.gbSELECT);
            this.Controls.Add(this.dgvTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.gbSELECT.ResumeLayout(false);
            this.gbWHERE.ResumeLayout(false);
            this.gbAlgebraRelacional.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.GroupBox gbSELECT;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdProyeccionMulti;
        private System.Windows.Forms.Button cmdProyeccionSimple;
        private System.Windows.Forms.GroupBox gbWHERE;
        private System.Windows.Forms.Button cmdSeleccionConvolucion;
        private System.Windows.Forms.Button cmdSeleccionMulti;
        private System.Windows.Forms.Button cmdSeleccionSimple;
        private System.Windows.Forms.GroupBox gbAlgebraRelacional;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
    }
}