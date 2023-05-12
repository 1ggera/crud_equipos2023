namespace test_crud3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConectar = new System.Windows.Forms.Button();
            this.buttonMostrar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.textBoxIdEq = new System.Windows.Forms.TextBox();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.textBoxPartJug = new System.Windows.Forms.TextBox();
            this.labelIdProd = new System.Windows.Forms.Label();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelPartJug = new System.Windows.Forms.Label();
            this.labelPartGan = new System.Windows.Forms.Label();
            this.textBoxPartGan = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConectar
            // 
            this.buttonConectar.Location = new System.Drawing.Point(25, 245);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(75, 23);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // buttonMostrar
            // 
            this.buttonMostrar.Location = new System.Drawing.Point(106, 245);
            this.buttonMostrar.Name = "buttonMostrar";
            this.buttonMostrar.Size = new System.Drawing.Size(75, 23);
            this.buttonMostrar.TabIndex = 1;
            this.buttonMostrar.Text = "Mostrar";
            this.buttonMostrar.UseVisualStyleBackColor = true;
            this.buttonMostrar.Click += new System.EventHandler(this.buttonMostrar_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(187, 245);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 2;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(268, 245);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonActualizar.TabIndex = 3;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(349, 245);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(75, 23);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "Borrar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(25, 26);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(399, 193);
            this.dgvProd.TabIndex = 5;
            // 
            // textBoxIdEq
            // 
            this.textBoxIdEq.Location = new System.Drawing.Point(442, 42);
            this.textBoxIdEq.Name = "textBoxIdEq";
            this.textBoxIdEq.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdEq.TabIndex = 6;
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(442, 85);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 7;
            // 
            // textBoxPartJug
            // 
            this.textBoxPartJug.Location = new System.Drawing.Point(442, 130);
            this.textBoxPartJug.Name = "textBoxPartJug";
            this.textBoxPartJug.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartJug.TabIndex = 8;
            // 
            // labelIdProd
            // 
            this.labelIdProd.AutoSize = true;
            this.labelIdProd.Location = new System.Drawing.Point(439, 26);
            this.labelIdProd.Name = "labelIdProd";
            this.labelIdProd.Size = new System.Drawing.Size(52, 13);
            this.labelIdProd.TabIndex = 9;
            this.labelIdProd.Text = "Id Equipo";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(439, 69);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(29, 13);
            this.labelPais.TabIndex = 10;
            this.labelPais.Text = "País";
            // 
            // labelPartJug
            // 
            this.labelPartJug.AutoSize = true;
            this.labelPartJug.Location = new System.Drawing.Point(439, 114);
            this.labelPartJug.Name = "labelPartJug";
            this.labelPartJug.Size = new System.Drawing.Size(46, 13);
            this.labelPartJug.TabIndex = 11;
            this.labelPartJug.Text = "Part Jug";
            // 
            // labelPartGan
            // 
            this.labelPartGan.AutoSize = true;
            this.labelPartGan.Location = new System.Drawing.Point(439, 157);
            this.labelPartGan.Name = "labelPartGan";
            this.labelPartGan.Size = new System.Drawing.Size(49, 13);
            this.labelPartGan.TabIndex = 12;
            this.labelPartGan.Text = "Part Gan";
            // 
            // textBoxPartGan
            // 
            this.textBoxPartGan.Location = new System.Drawing.Point(442, 173);
            this.textBoxPartGan.Name = "textBoxPartGan";
            this.textBoxPartGan.Size = new System.Drawing.Size(100, 20);
            this.textBoxPartGan.TabIndex = 13;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(430, 245);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 14;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 304);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxPartGan);
            this.Controls.Add(this.labelPartGan);
            this.Controls.Add(this.labelPartJug);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelIdProd);
            this.Controls.Add(this.textBoxPartJug);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.textBoxIdEq);
            this.Controls.Add(this.dgvProd);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonMostrar);
            this.Controls.Add(this.buttonConectar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Button buttonMostrar;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.TextBox textBoxIdEq;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.TextBox textBoxPartJug;
        private System.Windows.Forms.Label labelIdProd;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelPartJug;
        private System.Windows.Forms.Label labelPartGan;
        private System.Windows.Forms.TextBox textBoxPartGan;
        private System.Windows.Forms.Button buttonBuscar;
    }
}

