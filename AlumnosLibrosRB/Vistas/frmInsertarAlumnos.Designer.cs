namespace AlumnosLibrosRB.Vistas
{
    partial class frmInsertarAlumnos
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
            this.DTPFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.txbCurso = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbApellidos = new System.Windows.Forms.TextBox();
            this.txbIDAlumno = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labCurso = new System.Windows.Forms.Label();
            this.labFechaEntrega = new System.Windows.Forms.Label();
            this.labObservaciones = new System.Windows.Forms.Label();
            this.labIDAlumno = new System.Windows.Forms.Label();
            this.DTPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.labFechaDevolucion = new System.Windows.Forms.Label();
            this.CBDevolucion = new System.Windows.Forms.CheckBox();
            this.txbExpediente = new System.Windows.Forms.TextBox();
            this.labExpediente = new System.Windows.Forms.Label();
            this.CBBecario = new System.Windows.Forms.ComboBox();
            this.labBecario = new System.Windows.Forms.Label();
            this.CBBilingue = new System.Windows.Forms.ComboBox();
            this.labBilingue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DTPFechaEntrega
            // 
            this.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaEntrega.Location = new System.Drawing.Point(201, 253);
            this.DTPFechaEntrega.Name = "DTPFechaEntrega";
            this.DTPFechaEntrega.Size = new System.Drawing.Size(249, 26);
            this.DTPFechaEntrega.TabIndex = 32;
            this.DTPFechaEntrega.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(49, 316);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(110, 42);
            this.btnResetear.TabIndex = 31;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(759, 316);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 42);
            this.btnInsertar.TabIndex = 30;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(642, 90);
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(224, 26);
            this.txbObservaciones.TabIndex = 29;
            // 
            // txbCurso
            // 
            this.txbCurso.Location = new System.Drawing.Point(201, 200);
            this.txbCurso.MaxLength = 3;
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(249, 26);
            this.txbCurso.TabIndex = 28;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(201, 145);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(249, 26);
            this.txbNombre.TabIndex = 27;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(201, 90);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(249, 26);
            this.txbApellidos.TabIndex = 26;
            // 
            // txbIDAlumno
            // 
            this.txbIDAlumno.Location = new System.Drawing.Point(201, 35);
            this.txbIDAlumno.Name = "txbIDAlumno";
            this.txbIDAlumno.Size = new System.Drawing.Size(249, 26);
            this.txbIDAlumno.TabIndex = 25;
            this.txbIDAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDAlumno_KeyPress);
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(45, 93);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(73, 20);
            this.labApellidos.TabIndex = 23;
            this.labApellidos.Text = "Apellidos";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(45, 148);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(65, 20);
            this.labNombre.TabIndex = 22;
            this.labNombre.Text = "Nombre";
            // 
            // labCurso
            // 
            this.labCurso.AutoSize = true;
            this.labCurso.Location = new System.Drawing.Point(45, 203);
            this.labCurso.Name = "labCurso";
            this.labCurso.Size = new System.Drawing.Size(51, 20);
            this.labCurso.TabIndex = 21;
            this.labCurso.Text = "Curso";
            // 
            // labFechaEntrega
            // 
            this.labFechaEntrega.AutoSize = true;
            this.labFechaEntrega.Location = new System.Drawing.Point(45, 258);
            this.labFechaEntrega.Name = "labFechaEntrega";
            this.labFechaEntrega.Size = new System.Drawing.Size(115, 20);
            this.labFechaEntrega.TabIndex = 20;
            this.labFechaEntrega.Text = "Fecha Entrega";
            // 
            // labObservaciones
            // 
            this.labObservaciones.AutoSize = true;
            this.labObservaciones.Location = new System.Drawing.Point(500, 93);
            this.labObservaciones.Name = "labObservaciones";
            this.labObservaciones.Size = new System.Drawing.Size(114, 20);
            this.labObservaciones.TabIndex = 19;
            this.labObservaciones.Text = "Observaciones";
            // 
            // labIDAlumno
            // 
            this.labIDAlumno.AutoSize = true;
            this.labIDAlumno.Location = new System.Drawing.Point(45, 38);
            this.labIDAlumno.Name = "labIDAlumno";
            this.labIDAlumno.Size = new System.Drawing.Size(88, 20);
            this.labIDAlumno.TabIndex = 18;
            this.labIDAlumno.Text = "ID. Alumno";
            // 
            // DTPFechaDevolucion
            // 
            this.DTPFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaDevolucion.Location = new System.Drawing.Point(644, 33);
            this.DTPFechaDevolucion.Name = "DTPFechaDevolucion";
            this.DTPFechaDevolucion.Size = new System.Drawing.Size(225, 26);
            this.DTPFechaDevolucion.TabIndex = 34;
            this.DTPFechaDevolucion.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // labFechaDevolucion
            // 
            this.labFechaDevolucion.AutoSize = true;
            this.labFechaDevolucion.Location = new System.Drawing.Point(500, 38);
            this.labFechaDevolucion.Name = "labFechaDevolucion";
            this.labFechaDevolucion.Size = new System.Drawing.Size(136, 20);
            this.labFechaDevolucion.TabIndex = 33;
            this.labFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // CBDevolucion
            // 
            this.CBDevolucion.AutoSize = true;
            this.CBDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDevolucion.Location = new System.Drawing.Point(887, 38);
            this.CBDevolucion.Name = "CBDevolucion";
            this.CBDevolucion.Size = new System.Drawing.Size(15, 14);
            this.CBDevolucion.TabIndex = 35;
            this.CBDevolucion.UseVisualStyleBackColor = true;
            this.CBDevolucion.CheckedChanged += new System.EventHandler(this.CBEntregado_CheckedChanged);
            // 
            // txbExpediente
            // 
            this.txbExpediente.Location = new System.Drawing.Point(642, 145);
            this.txbExpediente.Name = "txbExpediente";
            this.txbExpediente.Size = new System.Drawing.Size(224, 26);
            this.txbExpediente.TabIndex = 67;
            this.txbExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // labExpediente
            // 
            this.labExpediente.AutoSize = true;
            this.labExpediente.Location = new System.Drawing.Point(500, 148);
            this.labExpediente.Name = "labExpediente";
            this.labExpediente.Size = new System.Drawing.Size(89, 20);
            this.labExpediente.TabIndex = 66;
            this.labExpediente.Text = "Expediente";
            // 
            // CBBecario
            // 
            this.CBBecario.BackColor = System.Drawing.Color.White;
            this.CBBecario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBecario.FormattingEnabled = true;
            this.CBBecario.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CBBecario.Location = new System.Drawing.Point(644, 255);
            this.CBBecario.Name = "CBBecario";
            this.CBBecario.Size = new System.Drawing.Size(222, 28);
            this.CBBecario.TabIndex = 65;
            // 
            // labBecario
            // 
            this.labBecario.AutoSize = true;
            this.labBecario.Location = new System.Drawing.Point(500, 258);
            this.labBecario.Name = "labBecario";
            this.labBecario.Size = new System.Drawing.Size(63, 20);
            this.labBecario.TabIndex = 64;
            this.labBecario.Text = "Becario";
            // 
            // CBBilingue
            // 
            this.CBBilingue.BackColor = System.Drawing.Color.White;
            this.CBBilingue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBilingue.FormattingEnabled = true;
            this.CBBilingue.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CBBilingue.Location = new System.Drawing.Point(644, 200);
            this.CBBilingue.Name = "CBBilingue";
            this.CBBilingue.Size = new System.Drawing.Size(222, 28);
            this.CBBilingue.TabIndex = 63;
            // 
            // labBilingue
            // 
            this.labBilingue.AutoSize = true;
            this.labBilingue.Location = new System.Drawing.Point(500, 203);
            this.labBilingue.Name = "labBilingue";
            this.labBilingue.Size = new System.Drawing.Size(65, 20);
            this.labBilingue.TabIndex = 62;
            this.labBilingue.Text = "Bilingüe";
            // 
            // frmInsertarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 396);
            this.Controls.Add(this.txbExpediente);
            this.Controls.Add(this.labExpediente);
            this.Controls.Add(this.CBBecario);
            this.Controls.Add(this.labBecario);
            this.Controls.Add(this.CBBilingue);
            this.Controls.Add(this.labBilingue);
            this.Controls.Add(this.CBDevolucion);
            this.Controls.Add(this.DTPFechaDevolucion);
            this.Controls.Add(this.labFechaDevolucion);
            this.Controls.Add(this.DTPFechaEntrega);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbObservaciones);
            this.Controls.Add(this.txbCurso);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbApellidos);
            this.Controls.Add(this.txbIDAlumno);
            this.Controls.Add(this.labApellidos);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labCurso);
            this.Controls.Add(this.labFechaEntrega);
            this.Controls.Add(this.labObservaciones);
            this.Controls.Add(this.labIDAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmInsertarAlumnos";
            this.Text = "Insertar nuevo alumno";
            this.Load += new System.EventHandler(this.frmInsertarAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DTPFechaEntrega;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.TextBox txbCurso;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbApellidos;
        private System.Windows.Forms.TextBox txbIDAlumno;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labCurso;
        private System.Windows.Forms.Label labFechaEntrega;
        private System.Windows.Forms.Label labObservaciones;
        private System.Windows.Forms.Label labIDAlumno;
        private System.Windows.Forms.DateTimePicker DTPFechaDevolucion;
        private System.Windows.Forms.Label labFechaDevolucion;
        private System.Windows.Forms.CheckBox CBDevolucion;
        private System.Windows.Forms.TextBox txbExpediente;
        private System.Windows.Forms.Label labExpediente;
        private System.Windows.Forms.ComboBox CBBecario;
        private System.Windows.Forms.Label labBecario;
        private System.Windows.Forms.ComboBox CBBilingue;
        private System.Windows.Forms.Label labBilingue;
    }
}