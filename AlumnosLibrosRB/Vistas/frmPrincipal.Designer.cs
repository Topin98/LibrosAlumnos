namespace AlumnosLibrosRB.Vistas
{
    partial class frmPrincipal
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
            this.btnConsultarAlumnos = new System.Windows.Forms.Button();
            this.btnConsultarLibros = new System.Windows.Forms.Button();
            this.btnModificarLibros = new System.Windows.Forms.Button();
            this.btnPrestarLibro = new System.Windows.Forms.Button();
            this.btnModificarAlumnos = new System.Windows.Forms.Button();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.labAnyo = new System.Windows.Forms.Label();
            this.CBAnyo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnConsultarAlumnos
            // 
            this.btnConsultarAlumnos.Location = new System.Drawing.Point(75, 101);
            this.btnConsultarAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarAlumnos.Name = "btnConsultarAlumnos";
            this.btnConsultarAlumnos.Size = new System.Drawing.Size(198, 54);
            this.btnConsultarAlumnos.TabIndex = 0;
            this.btnConsultarAlumnos.Text = "Consultar Alumnos";
            this.btnConsultarAlumnos.UseVisualStyleBackColor = true;
            this.btnConsultarAlumnos.Click += new System.EventHandler(this.btnConsultarAlumnos_Click);
            // 
            // btnConsultarLibros
            // 
            this.btnConsultarLibros.Location = new System.Drawing.Point(388, 101);
            this.btnConsultarLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultarLibros.Name = "btnConsultarLibros";
            this.btnConsultarLibros.Size = new System.Drawing.Size(198, 54);
            this.btnConsultarLibros.TabIndex = 1;
            this.btnConsultarLibros.Text = "Consultar Libros";
            this.btnConsultarLibros.UseVisualStyleBackColor = true;
            this.btnConsultarLibros.Click += new System.EventHandler(this.btnConsultarLibros_Click);
            // 
            // btnModificarLibros
            // 
            this.btnModificarLibros.Location = new System.Drawing.Point(388, 203);
            this.btnModificarLibros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarLibros.Name = "btnModificarLibros";
            this.btnModificarLibros.Size = new System.Drawing.Size(198, 54);
            this.btnModificarLibros.TabIndex = 3;
            this.btnModificarLibros.Text = "Modificar Libros";
            this.btnModificarLibros.UseVisualStyleBackColor = true;
            this.btnModificarLibros.Click += new System.EventHandler(this.btnModificarLibros_Click);
            // 
            // btnPrestarLibro
            // 
            this.btnPrestarLibro.Location = new System.Drawing.Point(75, 300);
            this.btnPrestarLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrestarLibro.Name = "btnPrestarLibro";
            this.btnPrestarLibro.Size = new System.Drawing.Size(198, 54);
            this.btnPrestarLibro.TabIndex = 4;
            this.btnPrestarLibro.Text = "Prestar Libro";
            this.btnPrestarLibro.UseVisualStyleBackColor = true;
            this.btnPrestarLibro.Click += new System.EventHandler(this.btnPrestarLibro_Click);
            // 
            // btnModificarAlumnos
            // 
            this.btnModificarAlumnos.Location = new System.Drawing.Point(75, 203);
            this.btnModificarAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarAlumnos.Name = "btnModificarAlumnos";
            this.btnModificarAlumnos.Size = new System.Drawing.Size(198, 54);
            this.btnModificarAlumnos.TabIndex = 5;
            this.btnModificarAlumnos.Text = "Modificar alumnos";
            this.btnModificarAlumnos.UseVisualStyleBackColor = true;
            this.btnModificarAlumnos.Click += new System.EventHandler(this.btnModificarAlumnos_Click);
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(388, 300);
            this.btnEliminarPrestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(198, 54);
            this.btnEliminarPrestamo.TabIndex = 6;
            this.btnEliminarPrestamo.Text = "Eliminar Préstamo";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // labAnyo
            // 
            this.labAnyo.AutoSize = true;
            this.labAnyo.Location = new System.Drawing.Point(236, 43);
            this.labAnyo.Name = "labAnyo";
            this.labAnyo.Size = new System.Drawing.Size(38, 20);
            this.labAnyo.TabIndex = 7;
            this.labAnyo.Text = "Año";
            // 
            // CBAnyo
            // 
            this.CBAnyo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBAnyo.FormattingEnabled = true;
            this.CBAnyo.Items.AddRange(new object[] {
            "17-18",
            "18-19",
            "19-20",
            "20-21"});
            this.CBAnyo.Location = new System.Drawing.Point(292, 40);
            this.CBAnyo.Name = "CBAnyo";
            this.CBAnyo.Size = new System.Drawing.Size(121, 28);
            this.CBAnyo.TabIndex = 8;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 408);
            this.Controls.Add(this.CBAnyo);
            this.Controls.Add(this.labAnyo);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnModificarAlumnos);
            this.Controls.Add(this.btnPrestarLibro);
            this.Controls.Add(this.btnModificarLibros);
            this.Controls.Add(this.btnConsultarLibros);
            this.Controls.Add(this.btnConsultarAlumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Opciones Disponibles";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsultarAlumnos;
        private System.Windows.Forms.Button btnConsultarLibros;
        private System.Windows.Forms.Button btnModificarLibros;
        private System.Windows.Forms.Button btnPrestarLibro;
        private System.Windows.Forms.Button btnModificarAlumnos;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Label labAnyo;
        private System.Windows.Forms.ComboBox CBAnyo;
    }
}

