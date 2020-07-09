namespace AlumnosLibrosRB.Vistas
{
    partial class frmConsultarLibros
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
            this.LVLibrosAlumno = new System.Windows.Forms.ListView();
            this.CHNumRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHTitulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHVolumenes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHFechaCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labSumLibros = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.CBFiltrar = new System.Windows.Forms.ComboBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LVLibrosAlumno
            // 
            this.LVLibrosAlumno.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHNumRegistro,
            this.CHISBN,
            this.CHTitulo,
            this.CHVolumenes,
            this.CHFechaCompra,
            this.CHObservaciones,
            this.CHEstado});
            this.LVLibrosAlumno.FullRowSelect = true;
            this.LVLibrosAlumno.GridLines = true;
            this.LVLibrosAlumno.Location = new System.Drawing.Point(36, 82);
            this.LVLibrosAlumno.Name = "LVLibrosAlumno";
            this.LVLibrosAlumno.Size = new System.Drawing.Size(1192, 519);
            this.LVLibrosAlumno.TabIndex = 1;
            this.LVLibrosAlumno.UseCompatibleStateImageBehavior = false;
            this.LVLibrosAlumno.View = System.Windows.Forms.View.Details;
            // 
            // CHNumRegistro
            // 
            this.CHNumRegistro.Text = "NumRegistro";
            this.CHNumRegistro.Width = 110;
            // 
            // CHISBN
            // 
            this.CHISBN.Text = "ISBN";
            this.CHISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHISBN.Width = 205;
            // 
            // CHTitulo
            // 
            this.CHTitulo.Text = "Titulo";
            this.CHTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTitulo.Width = 330;
            // 
            // CHVolumenes
            // 
            this.CHVolumenes.Text = "Volumenes";
            this.CHVolumenes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHVolumenes.Width = 100;
            // 
            // CHFechaCompra
            // 
            this.CHFechaCompra.Text = "Fecha Compra";
            this.CHFechaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHFechaCompra.Width = 150;
            // 
            // CHObservaciones
            // 
            this.CHObservaciones.Text = "Observaciones";
            this.CHObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHObservaciones.Width = 200;
            // 
            // CHEstado
            // 
            this.CHEstado.Text = "Estado";
            this.CHEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHEstado.Width = 70;
            // 
            // labSumLibros
            // 
            this.labSumLibros.AutoSize = true;
            this.labSumLibros.Location = new System.Drawing.Point(1030, 632);
            this.labSumLibros.Name = "labSumLibros";
            this.labSumLibros.Size = new System.Drawing.Size(106, 20);
            this.labSumLibros.TabIndex = 2;
            this.labSumLibros.Text = "labSumLibros";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(36, 622);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 41);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // CBFiltrar
            // 
            this.CBFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltrar.FormattingEnabled = true;
            this.CBFiltrar.Items.AddRange(new object[] {
            "NumRegistro",
            "ISBN",
            "Título",
            "Estado"});
            this.CBFiltrar.Location = new System.Drawing.Point(198, 29);
            this.CBFiltrar.Name = "CBFiltrar";
            this.CBFiltrar.Size = new System.Drawing.Size(150, 28);
            this.CBFiltrar.TabIndex = 6;
            this.CBFiltrar.SelectedIndexChanged += new System.EventHandler(this.filtrar);
            // 
            // labFiltrar
            // 
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(104, 32);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(76, 20);
            this.labFiltrar.TabIndex = 5;
            this.labFiltrar.Text = "Filtrar por";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(388, 29);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(171, 26);
            this.txbFiltro.TabIndex = 4;
            this.txbFiltro.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // frmConsultarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 700);
            this.Controls.Add(this.CBFiltrar);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.labSumLibros);
            this.Controls.Add(this.LVLibrosAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConsultarLibros";
            this.Text = "Datos de Libros";
            this.Load += new System.EventHandler(this.frmLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVLibrosAlumno;
        private System.Windows.Forms.ColumnHeader CHNumRegistro;
        private System.Windows.Forms.ColumnHeader CHISBN;
        private System.Windows.Forms.ColumnHeader CHTitulo;
        private System.Windows.Forms.ColumnHeader CHVolumenes;
        private System.Windows.Forms.ColumnHeader CHFechaCompra;
        private System.Windows.Forms.ColumnHeader CHObservaciones;
        private System.Windows.Forms.ColumnHeader CHEstado;
        private System.Windows.Forms.Label labSumLibros;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ComboBox CBFiltrar;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.TextBox txbFiltro;
    }
}