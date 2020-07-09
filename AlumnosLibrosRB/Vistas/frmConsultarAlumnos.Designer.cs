namespace AlumnosLibrosRB.Vistas
{
    partial class frmConsultarAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.LVAlumnos = new System.Windows.Forms.ListView();
            this.CHIDAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHFEntrega = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHFDevolucion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHIDLibros = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHExpediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBilingue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBecario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMIVerLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIGAPrestamo = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIGARecogida = new System.Windows.Forms.ToolStripMenuItem();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.CBFiltrar = new System.Windows.Forms.ComboBox();
            this.btnAlumnosNL = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.labSumAlumnos = new System.Windows.Forms.Label();
            this.CBBilingue = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBBecario = new System.Windows.Forms.ComboBox();
            this.labBecario = new System.Windows.Forms.Label();
            this.labLibrosPrestados = new System.Windows.Forms.Label();
            this.LVaux = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVAlumnos
            // 
            this.LVAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHIDAlumno,
            this.CHAlumno,
            this.CHCurso,
            this.CHFEntrega,
            this.CHFDevolucion,
            this.CHIDLibros,
            this.CHExpediente,
            this.CHBilingue,
            this.CHBecario,
            this.CHObservaciones});
            this.LVAlumnos.ContextMenuStrip = this.CMS;
            this.LVAlumnos.FullRowSelect = true;
            this.LVAlumnos.GridLines = true;
            this.LVAlumnos.Location = new System.Drawing.Point(44, 93);
            this.LVAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LVAlumnos.Name = "LVAlumnos";
            this.LVAlumnos.Size = new System.Drawing.Size(1396, 506);
            this.LVAlumnos.TabIndex = 0;
            this.LVAlumnos.UseCompatibleStateImageBehavior = false;
            this.LVAlumnos.View = System.Windows.Forms.View.Details;
            this.LVAlumnos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LVAlumnos_ColumnClick);
            // 
            // CHIDAlumno
            // 
            this.CHIDAlumno.Text = "ID";
            this.CHIDAlumno.Width = 80;
            // 
            // CHAlumno
            // 
            this.CHAlumno.Text = "Alumno";
            this.CHAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHAlumno.Width = 320;
            // 
            // CHCurso
            // 
            this.CHCurso.Text = "Curso";
            this.CHCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHCurso.Width = 55;
            // 
            // CHFEntrega
            // 
            this.CHFEntrega.Text = "Fec. Entrega";
            this.CHFEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHFEntrega.Width = 110;
            // 
            // CHFDevolucion
            // 
            this.CHFDevolucion.Text = "Fec. Devol";
            this.CHFDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHFDevolucion.Width = 100;
            // 
            // CHIDLibros
            // 
            this.CHIDLibros.Text = "IDLibros";
            this.CHIDLibros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHIDLibros.Width = 240;
            // 
            // CHExpediente
            // 
            this.CHExpediente.Text = "Expediente";
            this.CHExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHExpediente.Width = 100;
            // 
            // CHBilingue
            // 
            this.CHBilingue.Text = "Bilingue";
            this.CHBilingue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHBilingue.Width = 70;
            // 
            // CHBecario
            // 
            this.CHBecario.Text = "Becario";
            this.CHBecario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHBecario.Width = 70;
            // 
            // CHObservaciones
            // 
            this.CHObservaciones.Text = "Observaciones";
            this.CHObservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHObservaciones.Width = 230;
            // 
            // CMS
            // 
            this.CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIVerLibros,
            this.TSMIGAPrestamo,
            this.TSMIGARecogida});
            this.CMS.Name = "CMS";
            this.CMS.Size = new System.Drawing.Size(203, 70);
            this.CMS.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_Opening);
            // 
            // TSMIVerLibros
            // 
            this.TSMIVerLibros.Name = "TSMIVerLibros";
            this.TSMIVerLibros.Size = new System.Drawing.Size(202, 22);
            this.TSMIVerLibros.Text = "Ver libros";
            this.TSMIVerLibros.Click += new System.EventHandler(this.TSMIVerLibros_Click);
            // 
            // TSMIGAPrestamo
            // 
            this.TSMIGAPrestamo.Name = "TSMIGAPrestamo";
            this.TSMIGAPrestamo.Size = new System.Drawing.Size(202, 22);
            this.TSMIGAPrestamo.Text = "Generar anexo préstamo";
            this.TSMIGAPrestamo.Click += new System.EventHandler(this.GenerarAnexo);
            // 
            // TSMIGARecogida
            // 
            this.TSMIGARecogida.Name = "TSMIGARecogida";
            this.TSMIGARecogida.Size = new System.Drawing.Size(202, 22);
            this.TSMIGARecogida.Text = "Generar anexo recogida";
            this.TSMIGARecogida.Click += new System.EventHandler(this.GenerarAnexo);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(381, 32);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(171, 26);
            this.txbFiltro.TabIndex = 1;
            this.txbFiltro.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // labFiltrar
            // 
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(97, 35);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(76, 20);
            this.labFiltrar.TabIndex = 2;
            this.labFiltrar.Text = "Filtrar por";
            // 
            // CBFiltrar
            // 
            this.CBFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltrar.FormattingEnabled = true;
            this.CBFiltrar.Items.AddRange(new object[] {
            "ID",
            "Alumno",
            "Curso",
            "IDLibro",
            "Observaciones"});
            this.CBFiltrar.Location = new System.Drawing.Point(191, 32);
            this.CBFiltrar.Name = "CBFiltrar";
            this.CBFiltrar.Size = new System.Drawing.Size(150, 28);
            this.CBFiltrar.TabIndex = 3;
            this.CBFiltrar.SelectedIndexChanged += new System.EventHandler(this.filtrar);
            // 
            // btnAlumnosNL
            // 
            this.btnAlumnosNL.Location = new System.Drawing.Point(1257, 27);
            this.btnAlumnosNL.Name = "btnAlumnosNL";
            this.btnAlumnosNL.Size = new System.Drawing.Size(183, 37);
            this.btnAlumnosNL.TabIndex = 4;
            this.btnAlumnosNL.Text = "Alumnos sin libros";
            this.btnAlumnosNL.UseVisualStyleBackColor = true;
            this.btnAlumnosNL.Click += new System.EventHandler(this.btnAlumnosNL_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(44, 612);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 37);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // labSumAlumnos
            // 
            this.labSumAlumnos.AutoSize = true;
            this.labSumAlumnos.Location = new System.Drawing.Point(1086, 620);
            this.labSumAlumnos.Name = "labSumAlumnos";
            this.labSumAlumnos.Size = new System.Drawing.Size(125, 20);
            this.labSumAlumnos.TabIndex = 6;
            this.labSumAlumnos.Text = "labSumAlumnos";
            // 
            // CBBilingue
            // 
            this.CBBilingue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBilingue.FormattingEnabled = true;
            this.CBBilingue.Items.AddRange(new object[] {
            "Todo",
            "Sí",
            "No"});
            this.CBBilingue.Location = new System.Drawing.Point(715, 32);
            this.CBBilingue.Name = "CBBilingue";
            this.CBBilingue.Size = new System.Drawing.Size(150, 28);
            this.CBBilingue.TabIndex = 8;
            this.CBBilingue.SelectedIndexChanged += new System.EventHandler(this.filtrar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bilingüe";
            // 
            // CBBecario
            // 
            this.CBBecario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBecario.FormattingEnabled = true;
            this.CBBecario.Items.AddRange(new object[] {
            "Todo",
            "Sí",
            "No"});
            this.CBBecario.Location = new System.Drawing.Point(1038, 32);
            this.CBBecario.Name = "CBBecario";
            this.CBBecario.Size = new System.Drawing.Size(150, 28);
            this.CBBecario.TabIndex = 10;
            this.CBBecario.SelectedIndexChanged += new System.EventHandler(this.filtrar);
            // 
            // labBecario
            // 
            this.labBecario.AutoSize = true;
            this.labBecario.Location = new System.Drawing.Point(944, 35);
            this.labBecario.Name = "labBecario";
            this.labBecario.Size = new System.Drawing.Size(63, 20);
            this.labBecario.TabIndex = 9;
            this.labBecario.Text = "Becario";
            // 
            // labLibrosPrestados
            // 
            this.labLibrosPrestados.AutoSize = true;
            this.labLibrosPrestados.Location = new System.Drawing.Point(475, 620);
            this.labLibrosPrestados.Name = "labLibrosPrestados";
            this.labLibrosPrestados.Size = new System.Drawing.Size(145, 20);
            this.labLibrosPrestados.TabIndex = 11;
            this.labLibrosPrestados.Text = "labLibrosPrestados";
            // 
            // LVaux
            // 
            this.LVaux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.LVaux.ContextMenuStrip = this.CMS;
            this.LVaux.GridLines = true;
            this.LVaux.Location = new System.Drawing.Point(1341, 620);
            this.LVaux.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LVaux.Name = "LVaux";
            this.LVaux.Size = new System.Drawing.Size(1139, 506);
            this.LVaux.TabIndex = 12;
            this.LVaux.UseCompatibleStateImageBehavior = false;
            this.LVaux.View = System.Windows.Forms.View.Details;
            this.LVaux.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Alumno";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 400;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Curso";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "IDLibros";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 350;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Expediente";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bilingue";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Becario";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 70;
            // 
            // frmConsultarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 691);
            this.Controls.Add(this.LVaux);
            this.Controls.Add(this.labLibrosPrestados);
            this.Controls.Add(this.CBBecario);
            this.Controls.Add(this.labBecario);
            this.Controls.Add(this.CBBilingue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labSumAlumnos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAlumnosNL);
            this.Controls.Add(this.CBFiltrar);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.LVAlumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConsultarAlumnos";
            this.Text = "Datos de Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            this.CMS.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LVAlumnos;
        private System.Windows.Forms.ColumnHeader CHIDAlumno;
        private System.Windows.Forms.ColumnHeader CHAlumno;
        private System.Windows.Forms.ColumnHeader CHCurso;
        private System.Windows.Forms.ColumnHeader CHFEntrega;
        private System.Windows.Forms.ColumnHeader CHFDevolucion;
        private System.Windows.Forms.ColumnHeader CHIDLibros;
        private System.Windows.Forms.ColumnHeader CHObservaciones;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.ComboBox CBFiltrar;
        private System.Windows.Forms.Button btnAlumnosNL;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ContextMenuStrip CMS;
        private System.Windows.Forms.ToolStripMenuItem TSMIVerLibros;
        private System.Windows.Forms.ToolStripMenuItem TSMIGAPrestamo;
        private System.Windows.Forms.ColumnHeader CHBilingue;
        private System.Windows.Forms.ColumnHeader CHBecario;
        private System.Windows.Forms.ColumnHeader CHExpediente;
        private System.Windows.Forms.ToolStripMenuItem TSMIGARecogida;
        private System.Windows.Forms.Label labSumAlumnos;
        private System.Windows.Forms.ComboBox CBBilingue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBBecario;
        private System.Windows.Forms.Label labBecario;
        private System.Windows.Forms.Label labLibrosPrestados;
        private System.Windows.Forms.ListView LVaux;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}