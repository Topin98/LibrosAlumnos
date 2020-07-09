namespace AlumnosLibrosRB.Vistas
{
    partial class frmActualizacionesAlumnos
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
            this.CBDevuelto = new System.Windows.Forms.CheckBox();
            this.DTPFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.labFechaDevolucion = new System.Windows.Forms.Label();
            this.DTPFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
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
            this.LBAlumnos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.CBBilingue = new System.Windows.Forms.ComboBox();
            this.labBilingue = new System.Windows.Forms.Label();
            this.CBBecario = new System.Windows.Forms.ComboBox();
            this.labBecario = new System.Windows.Forms.Label();
            this.labExpediente = new System.Windows.Forms.Label();
            this.txbExpediente = new System.Windows.Forms.TextBox();
            this.CBActivo = new System.Windows.Forms.ComboBox();
            this.labActivo = new System.Windows.Forms.Label();
            this.txbFiltrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CBDevuelto
            // 
            this.CBDevuelto.AutoSize = true;
            this.CBDevuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDevuelto.Location = new System.Drawing.Point(1244, 93);
            this.CBDevuelto.Name = "CBDevuelto";
            this.CBDevuelto.Size = new System.Drawing.Size(15, 14);
            this.CBDevuelto.TabIndex = 52;
            this.CBDevuelto.UseVisualStyleBackColor = true;
            this.CBDevuelto.CheckedChanged += new System.EventHandler(this.CBEntregado_CheckedChanged);
            // 
            // DTPFechaDevolucion
            // 
            this.DTPFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaDevolucion.Location = new System.Drawing.Point(1002, 88);
            this.DTPFechaDevolucion.Name = "DTPFechaDevolucion";
            this.DTPFechaDevolucion.Size = new System.Drawing.Size(225, 26);
            this.DTPFechaDevolucion.TabIndex = 51;
            this.DTPFechaDevolucion.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // labFechaDevolucion
            // 
            this.labFechaDevolucion.AutoSize = true;
            this.labFechaDevolucion.Location = new System.Drawing.Point(842, 93);
            this.labFechaDevolucion.Name = "labFechaDevolucion";
            this.labFechaDevolucion.Size = new System.Drawing.Size(136, 20);
            this.labFechaDevolucion.TabIndex = 50;
            this.labFechaDevolucion.Text = "Fecha Devolucion";
            // 
            // DTPFechaEntrega
            // 
            this.DTPFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaEntrega.Location = new System.Drawing.Point(557, 306);
            this.DTPFechaEntrega.Name = "DTPFechaEntrega";
            this.DTPFechaEntrega.Size = new System.Drawing.Size(249, 26);
            this.DTPFechaEntrega.TabIndex = 49;
            this.DTPFechaEntrega.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(887, 360);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(97, 42);
            this.btnResetear.TabIndex = 48;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(646, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(97, 42);
            this.btnGuardar.TabIndex = 47;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(1003, 143);
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(224, 26);
            this.txbObservaciones.TabIndex = 46;
            // 
            // txbCurso
            // 
            this.txbCurso.Location = new System.Drawing.Point(557, 252);
            this.txbCurso.MaxLength = 3;
            this.txbCurso.Name = "txbCurso";
            this.txbCurso.Size = new System.Drawing.Size(249, 26);
            this.txbCurso.TabIndex = 45;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(557, 198);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(249, 26);
            this.txbNombre.TabIndex = 44;
            // 
            // txbApellidos
            // 
            this.txbApellidos.Location = new System.Drawing.Point(557, 144);
            this.txbApellidos.Name = "txbApellidos";
            this.txbApellidos.Size = new System.Drawing.Size(249, 26);
            this.txbApellidos.TabIndex = 43;
            // 
            // txbIDAlumno
            // 
            this.txbIDAlumno.BackColor = System.Drawing.Color.White;
            this.txbIDAlumno.Location = new System.Drawing.Point(557, 90);
            this.txbIDAlumno.Name = "txbIDAlumno";
            this.txbIDAlumno.ReadOnly = true;
            this.txbIDAlumno.Size = new System.Drawing.Size(249, 26);
            this.txbIDAlumno.TabIndex = 42;
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(401, 146);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(73, 20);
            this.labApellidos.TabIndex = 41;
            this.labApellidos.Text = "Apellidos";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(401, 199);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(65, 20);
            this.labNombre.TabIndex = 40;
            this.labNombre.Text = "Nombre";
            // 
            // labCurso
            // 
            this.labCurso.AutoSize = true;
            this.labCurso.Location = new System.Drawing.Point(401, 252);
            this.labCurso.Name = "labCurso";
            this.labCurso.Size = new System.Drawing.Size(51, 20);
            this.labCurso.TabIndex = 39;
            this.labCurso.Text = "Curso";
            // 
            // labFechaEntrega
            // 
            this.labFechaEntrega.AutoSize = true;
            this.labFechaEntrega.Location = new System.Drawing.Point(401, 305);
            this.labFechaEntrega.Name = "labFechaEntrega";
            this.labFechaEntrega.Size = new System.Drawing.Size(115, 20);
            this.labFechaEntrega.TabIndex = 38;
            this.labFechaEntrega.Text = "Fecha Entrega";
            // 
            // labObservaciones
            // 
            this.labObservaciones.AutoSize = true;
            this.labObservaciones.Location = new System.Drawing.Point(842, 148);
            this.labObservaciones.Name = "labObservaciones";
            this.labObservaciones.Size = new System.Drawing.Size(114, 20);
            this.labObservaciones.TabIndex = 37;
            this.labObservaciones.Text = "Observaciones";
            // 
            // labIDAlumno
            // 
            this.labIDAlumno.AutoSize = true;
            this.labIDAlumno.Location = new System.Drawing.Point(401, 93);
            this.labIDAlumno.Name = "labIDAlumno";
            this.labIDAlumno.Size = new System.Drawing.Size(88, 20);
            this.labIDAlumno.TabIndex = 36;
            this.labIDAlumno.Text = "ID. Alumno";
            // 
            // LBAlumnos
            // 
            this.LBAlumnos.FormattingEnabled = true;
            this.LBAlumnos.ItemHeight = 20;
            this.LBAlumnos.Location = new System.Drawing.Point(22, 68);
            this.LBAlumnos.Name = "LBAlumnos";
            this.LBAlumnos.Size = new System.Drawing.Size(339, 344);
            this.LBAlumnos.TabIndex = 53;
            this.LBAlumnos.SelectedIndexChanged += new System.EventHandler(this.LBIDAlumnos_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(405, 360);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(97, 42);
            this.btnNuevo.TabIndex = 54;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1128, 360);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 42);
            this.btnBorrar.TabIndex = 55;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // CBBilingue
            // 
            this.CBBilingue.BackColor = System.Drawing.Color.White;
            this.CBBilingue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBilingue.FormattingEnabled = true;
            this.CBBilingue.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CBBilingue.Location = new System.Drawing.Point(1004, 253);
            this.CBBilingue.Name = "CBBilingue";
            this.CBBilingue.Size = new System.Drawing.Size(111, 28);
            this.CBBilingue.TabIndex = 57;
            // 
            // labBilingue
            // 
            this.labBilingue.AutoSize = true;
            this.labBilingue.Location = new System.Drawing.Point(842, 258);
            this.labBilingue.Name = "labBilingue";
            this.labBilingue.Size = new System.Drawing.Size(65, 20);
            this.labBilingue.TabIndex = 56;
            this.labBilingue.Text = "Bilingüe";
            // 
            // CBBecario
            // 
            this.CBBecario.BackColor = System.Drawing.Color.White;
            this.CBBecario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBecario.FormattingEnabled = true;
            this.CBBecario.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CBBecario.Location = new System.Drawing.Point(1004, 310);
            this.CBBecario.Name = "CBBecario";
            this.CBBecario.Size = new System.Drawing.Size(111, 28);
            this.CBBecario.TabIndex = 59;
            // 
            // labBecario
            // 
            this.labBecario.AutoSize = true;
            this.labBecario.Location = new System.Drawing.Point(842, 313);
            this.labBecario.Name = "labBecario";
            this.labBecario.Size = new System.Drawing.Size(63, 20);
            this.labBecario.TabIndex = 58;
            this.labBecario.Text = "Becario";
            // 
            // labExpediente
            // 
            this.labExpediente.AutoSize = true;
            this.labExpediente.Location = new System.Drawing.Point(842, 203);
            this.labExpediente.Name = "labExpediente";
            this.labExpediente.Size = new System.Drawing.Size(89, 20);
            this.labExpediente.TabIndex = 60;
            this.labExpediente.Text = "Expediente";
            // 
            // txbExpediente
            // 
            this.txbExpediente.Location = new System.Drawing.Point(1004, 198);
            this.txbExpediente.Name = "txbExpediente";
            this.txbExpediente.Size = new System.Drawing.Size(224, 26);
            this.txbExpediente.TabIndex = 61;
            this.txbExpediente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // CBActivo
            // 
            this.CBActivo.BackColor = System.Drawing.Color.White;
            this.CBActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBActivo.FormattingEnabled = true;
            this.CBActivo.Items.AddRange(new object[] {
            "Sí",
            "No"});
            this.CBActivo.Location = new System.Drawing.Point(557, 22);
            this.CBActivo.Name = "CBActivo";
            this.CBActivo.Size = new System.Drawing.Size(111, 28);
            this.CBActivo.TabIndex = 63;
            // 
            // labActivo
            // 
            this.labActivo.AutoSize = true;
            this.labActivo.Location = new System.Drawing.Point(401, 25);
            this.labActivo.Name = "labActivo";
            this.labActivo.Size = new System.Drawing.Size(52, 20);
            this.labActivo.TabIndex = 62;
            this.labActivo.Text = "Activo";
            // 
            // txbFiltrar
            // 
            this.txbFiltrar.Location = new System.Drawing.Point(22, 22);
            this.txbFiltrar.Name = "txbFiltrar";
            this.txbFiltrar.Size = new System.Drawing.Size(339, 26);
            this.txbFiltrar.TabIndex = 64;
            this.txbFiltrar.TextChanged += new System.EventHandler(this.txbFiltrar_TextChanged);
            // 
            // frmActualizacionesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 448);
            this.Controls.Add(this.txbFiltrar);
            this.Controls.Add(this.CBActivo);
            this.Controls.Add(this.labActivo);
            this.Controls.Add(this.txbExpediente);
            this.Controls.Add(this.labExpediente);
            this.Controls.Add(this.CBBecario);
            this.Controls.Add(this.labBecario);
            this.Controls.Add(this.CBBilingue);
            this.Controls.Add(this.labBilingue);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.LBAlumnos);
            this.Controls.Add(this.CBDevuelto);
            this.Controls.Add(this.DTPFechaDevolucion);
            this.Controls.Add(this.labFechaDevolucion);
            this.Controls.Add(this.DTPFechaEntrega);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnGuardar);
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
            this.Name = "frmActualizacionesAlumnos";
            this.Text = "Actualizar datos alumnado";
            this.Load += new System.EventHandler(this.frmActualizacionesAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CBDevuelto;
        private System.Windows.Forms.DateTimePicker DTPFechaDevolucion;
        private System.Windows.Forms.Label labFechaDevolucion;
        private System.Windows.Forms.DateTimePicker DTPFechaEntrega;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGuardar;
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
        private System.Windows.Forms.ListBox LBAlumnos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox CBBilingue;
        private System.Windows.Forms.Label labBilingue;
        private System.Windows.Forms.ComboBox CBBecario;
        private System.Windows.Forms.Label labBecario;
        private System.Windows.Forms.Label labExpediente;
        private System.Windows.Forms.TextBox txbExpediente;
        private System.Windows.Forms.ComboBox CBActivo;
        private System.Windows.Forms.Label labActivo;
        private System.Windows.Forms.TextBox txbFiltrar;
    }
}