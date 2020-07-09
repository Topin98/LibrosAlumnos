namespace AlumnosLibrosRB.Vistas
{
    partial class frmConsultarAlumnosNL
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
            this.CBFiltrar = new System.Windows.Forms.ComboBox();
            this.labFiltrar = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.LVAlumnos = new System.Windows.Forms.ListView();
            this.CHIDAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHExpediente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBilingue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHBecario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CHObservaciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnImprimir = new System.Windows.Forms.Button();
            this.labSumAlumnos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CBFiltrar
            // 
            this.CBFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFiltrar.FormattingEnabled = true;
            this.CBFiltrar.Items.AddRange(new object[] {
            "IDAlumno",
            "Alumno",
            "Curso",
            "Observaciones"});
            this.CBFiltrar.Location = new System.Drawing.Point(190, 39);
            this.CBFiltrar.Name = "CBFiltrar";
            this.CBFiltrar.Size = new System.Drawing.Size(150, 28);
            this.CBFiltrar.TabIndex = 8;
            this.CBFiltrar.SelectedIndexChanged += new System.EventHandler(this.filtrar);
            // 
            // labFiltrar
            // 
            this.labFiltrar.AutoSize = true;
            this.labFiltrar.Location = new System.Drawing.Point(96, 42);
            this.labFiltrar.Name = "labFiltrar";
            this.labFiltrar.Size = new System.Drawing.Size(76, 20);
            this.labFiltrar.TabIndex = 7;
            this.labFiltrar.Text = "Filtrar por";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(380, 39);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(171, 26);
            this.txbFiltro.TabIndex = 6;
            this.txbFiltro.TextChanged += new System.EventHandler(this.filtrar);
            // 
            // LVAlumnos
            // 
            this.LVAlumnos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CHIDAlumno,
            this.CHAlumno,
            this.CHCurso,
            this.CHExpediente,
            this.CHBilingue,
            this.CHBecario,
            this.CHObservaciones});
            this.LVAlumnos.FullRowSelect = true;
            this.LVAlumnos.GridLines = true;
            this.LVAlumnos.Location = new System.Drawing.Point(29, 98);
            this.LVAlumnos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LVAlumnos.MultiSelect = false;
            this.LVAlumnos.Name = "LVAlumnos";
            this.LVAlumnos.Size = new System.Drawing.Size(1042, 425);
            this.LVAlumnos.TabIndex = 5;
            this.LVAlumnos.UseCompatibleStateImageBehavior = false;
            this.LVAlumnos.View = System.Windows.Forms.View.Details;
            this.LVAlumnos.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.LVAlumnos_ColumnClick);
            // 
            // CHIDAlumno
            // 
            this.CHIDAlumno.Text = "IDAlumno";
            this.CHIDAlumno.Width = 100;
            // 
            // CHAlumno
            // 
            this.CHAlumno.Text = "Alumno";
            this.CHAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHAlumno.Width = 300;
            // 
            // CHCurso
            // 
            this.CHCurso.Text = "Curso";
            this.CHCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHCurso.Width = 75;
            // 
            // CHExpediente
            // 
            this.CHExpediente.Text = "Expediente";
            this.CHExpediente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHExpediente.Width = 105;
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
            this.CHObservaciones.Width = 300;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(802, 32);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 40);
            this.btnImprimir.TabIndex = 9;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // labSumAlumnos
            // 
            this.labSumAlumnos.AutoSize = true;
            this.labSumAlumnos.Location = new System.Drawing.Point(710, 539);
            this.labSumAlumnos.Name = "labSumAlumnos";
            this.labSumAlumnos.Size = new System.Drawing.Size(125, 20);
            this.labSumAlumnos.TabIndex = 10;
            this.labSumAlumnos.Text = "labSumAlumnos";
            // 
            // frmConsultarAlumnosNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 596);
            this.Controls.Add(this.labSumAlumnos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.CBFiltrar);
            this.Controls.Add(this.labFiltrar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.LVAlumnos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmConsultarAlumnosNL";
            this.Text = "Datos de Alumnos sin libros";
            this.Load += new System.EventHandler(this.frmConsultarAlumnosNL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBFiltrar;
        private System.Windows.Forms.Label labFiltrar;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.ListView LVAlumnos;
        private System.Windows.Forms.ColumnHeader CHIDAlumno;
        private System.Windows.Forms.ColumnHeader CHAlumno;
        private System.Windows.Forms.ColumnHeader CHCurso;
        private System.Windows.Forms.ColumnHeader CHObservaciones;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ColumnHeader CHBilingue;
        private System.Windows.Forms.ColumnHeader CHExpediente;
        private System.Windows.Forms.ColumnHeader CHBecario;
        private System.Windows.Forms.Label labSumAlumnos;
    }
}