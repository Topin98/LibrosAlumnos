namespace AlumnosLibrosRB.Vistas
{
    partial class frmActualizacionesLibros
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
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.DTPFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.txbVolumenes = new System.Windows.Forms.TextBox();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.txbISBN = new System.Windows.Forms.TextBox();
            this.txbNumRegistro = new System.Windows.Forms.TextBox();
            this.labEstado = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labVolumenes = new System.Windows.Forms.Label();
            this.labFechaCompra = new System.Windows.Forms.Label();
            this.labObservaciones = new System.Windows.Forms.Label();
            this.labNumRegistro = new System.Windows.Forms.Label();
            this.LBNumRegistros = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.CBEstado.Location = new System.Drawing.Point(798, 85);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(128, 28);
            this.CBEstado.TabIndex = 33;
            // 
            // DTPFechaCompra
            // 
            this.DTPFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaCompra.Location = new System.Drawing.Point(349, 248);
            this.DTPFechaCompra.Name = "DTPFechaCompra";
            this.DTPFechaCompra.Size = new System.Drawing.Size(249, 26);
            this.DTPFechaCompra.TabIndex = 32;
            this.DTPFechaCompra.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(798, 30);
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(223, 26);
            this.txbObservaciones.TabIndex = 29;
            // 
            // txbVolumenes
            // 
            this.txbVolumenes.Location = new System.Drawing.Point(349, 195);
            this.txbVolumenes.Name = "txbVolumenes";
            this.txbVolumenes.Size = new System.Drawing.Size(249, 26);
            this.txbVolumenes.TabIndex = 28;
            this.txbVolumenes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(349, 140);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(249, 26);
            this.txbTitulo.TabIndex = 27;
            // 
            // txbISBN
            // 
            this.txbISBN.Location = new System.Drawing.Point(349, 85);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(249, 26);
            this.txbISBN.TabIndex = 26;
            // 
            // txbNumRegistro
            // 
            this.txbNumRegistro.BackColor = System.Drawing.Color.White;
            this.txbNumRegistro.Location = new System.Drawing.Point(349, 30);
            this.txbNumRegistro.Name = "txbNumRegistro";
            this.txbNumRegistro.ReadOnly = true;
            this.txbNumRegistro.Size = new System.Drawing.Size(249, 26);
            this.txbNumRegistro.TabIndex = 25;
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Location = new System.Drawing.Point(651, 88);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(60, 20);
            this.labEstado.TabIndex = 24;
            this.labEstado.Text = "Estado";
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Location = new System.Drawing.Point(193, 88);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(47, 20);
            this.labISBN.TabIndex = 23;
            this.labISBN.Text = "ISBN";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(193, 143);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(47, 20);
            this.labTitulo.TabIndex = 22;
            this.labTitulo.Text = "Titulo";
            // 
            // labVolumenes
            // 
            this.labVolumenes.AutoSize = true;
            this.labVolumenes.Location = new System.Drawing.Point(193, 198);
            this.labVolumenes.Name = "labVolumenes";
            this.labVolumenes.Size = new System.Drawing.Size(89, 20);
            this.labVolumenes.TabIndex = 21;
            this.labVolumenes.Text = "Volúmenes";
            // 
            // labFechaCompra
            // 
            this.labFechaCompra.AutoSize = true;
            this.labFechaCompra.Location = new System.Drawing.Point(193, 253);
            this.labFechaCompra.Name = "labFechaCompra";
            this.labFechaCompra.Size = new System.Drawing.Size(114, 20);
            this.labFechaCompra.TabIndex = 20;
            this.labFechaCompra.Text = "Fecha Compra";
            // 
            // labObservaciones
            // 
            this.labObservaciones.AutoSize = true;
            this.labObservaciones.Location = new System.Drawing.Point(651, 33);
            this.labObservaciones.Name = "labObservaciones";
            this.labObservaciones.Size = new System.Drawing.Size(114, 20);
            this.labObservaciones.TabIndex = 19;
            this.labObservaciones.Text = "Observaciones";
            // 
            // labNumRegistro
            // 
            this.labNumRegistro.AutoSize = true;
            this.labNumRegistro.Location = new System.Drawing.Point(193, 33);
            this.labNumRegistro.Name = "labNumRegistro";
            this.labNumRegistro.Size = new System.Drawing.Size(110, 20);
            this.labNumRegistro.TabIndex = 18;
            this.labNumRegistro.Text = "Num. Registro";
            // 
            // LBNumRegistros
            // 
            this.LBNumRegistros.FormattingEnabled = true;
            this.LBNumRegistros.ItemHeight = 20;
            this.LBNumRegistros.Location = new System.Drawing.Point(25, 24);
            this.LBNumRegistros.Name = "LBNumRegistros";
            this.LBNumRegistros.Size = new System.Drawing.Size(130, 264);
            this.LBNumRegistros.TabIndex = 54;
            this.LBNumRegistros.SelectedIndexChanged += new System.EventHandler(this.LBNumRegistros_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(865, 218);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(110, 42);
            this.btnBorrar.TabIndex = 59;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(707, 143);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 42);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(707, 218);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(110, 42);
            this.btnResetear.TabIndex = 57;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(865, 143);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 42);
            this.btnGuardar.TabIndex = 56;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmActualizacionesLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 321);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.LBNumRegistros);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.DTPFechaCompra);
            this.Controls.Add(this.txbObservaciones);
            this.Controls.Add(this.txbVolumenes);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.txbISBN);
            this.Controls.Add(this.txbNumRegistro);
            this.Controls.Add(this.labEstado);
            this.Controls.Add(this.labISBN);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.labVolumenes);
            this.Controls.Add(this.labFechaCompra);
            this.Controls.Add(this.labObservaciones);
            this.Controls.Add(this.labNumRegistro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmActualizacionesLibros";
            this.Text = "Actualizar datos libros";
            this.Load += new System.EventHandler(this.frmActualizacionesLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBEstado;
        private System.Windows.Forms.DateTimePicker DTPFechaCompra;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.TextBox txbVolumenes;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.TextBox txbISBN;
        private System.Windows.Forms.TextBox txbNumRegistro;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labVolumenes;
        private System.Windows.Forms.Label labFechaCompra;
        private System.Windows.Forms.Label labObservaciones;
        private System.Windows.Forms.Label labNumRegistro;
        private System.Windows.Forms.ListBox LBNumRegistros;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnGuardar;
    }
}