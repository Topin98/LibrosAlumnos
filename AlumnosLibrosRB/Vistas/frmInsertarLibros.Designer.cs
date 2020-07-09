namespace AlumnosLibrosRB.Vistas
{
    partial class frmInsertarLibros
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
            this.labNumRegistro = new System.Windows.Forms.Label();
            this.labObservaciones = new System.Windows.Forms.Label();
            this.labFechaCompra = new System.Windows.Forms.Label();
            this.labVolumenes = new System.Windows.Forms.Label();
            this.labTitulo = new System.Windows.Forms.Label();
            this.labISBN = new System.Windows.Forms.Label();
            this.labEstado = new System.Windows.Forms.Label();
            this.txbNumRegistro = new System.Windows.Forms.TextBox();
            this.txbISBN = new System.Windows.Forms.TextBox();
            this.txbVolumenes = new System.Windows.Forms.TextBox();
            this.txbObservaciones = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnResetear = new System.Windows.Forms.Button();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.DTPFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.CBEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labNumRegistro
            // 
            this.labNumRegistro.AutoSize = true;
            this.labNumRegistro.Location = new System.Drawing.Point(57, 45);
            this.labNumRegistro.Name = "labNumRegistro";
            this.labNumRegistro.Size = new System.Drawing.Size(110, 20);
            this.labNumRegistro.TabIndex = 0;
            this.labNumRegistro.Text = "Num. Registro";
            // 
            // labObservaciones
            // 
            this.labObservaciones.AutoSize = true;
            this.labObservaciones.Location = new System.Drawing.Point(515, 45);
            this.labObservaciones.Name = "labObservaciones";
            this.labObservaciones.Size = new System.Drawing.Size(114, 20);
            this.labObservaciones.TabIndex = 1;
            this.labObservaciones.Text = "Observaciones";
            // 
            // labFechaCompra
            // 
            this.labFechaCompra.AutoSize = true;
            this.labFechaCompra.Location = new System.Drawing.Point(57, 265);
            this.labFechaCompra.Name = "labFechaCompra";
            this.labFechaCompra.Size = new System.Drawing.Size(114, 20);
            this.labFechaCompra.TabIndex = 2;
            this.labFechaCompra.Text = "Fecha Compra";
            // 
            // labVolumenes
            // 
            this.labVolumenes.AutoSize = true;
            this.labVolumenes.Location = new System.Drawing.Point(57, 210);
            this.labVolumenes.Name = "labVolumenes";
            this.labVolumenes.Size = new System.Drawing.Size(89, 20);
            this.labVolumenes.TabIndex = 3;
            this.labVolumenes.Text = "Volúmenes";
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Location = new System.Drawing.Point(57, 155);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(47, 20);
            this.labTitulo.TabIndex = 4;
            this.labTitulo.Text = "Titulo";
            // 
            // labISBN
            // 
            this.labISBN.AutoSize = true;
            this.labISBN.Location = new System.Drawing.Point(57, 100);
            this.labISBN.Name = "labISBN";
            this.labISBN.Size = new System.Drawing.Size(47, 20);
            this.labISBN.TabIndex = 5;
            this.labISBN.Text = "ISBN";
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Location = new System.Drawing.Point(515, 100);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(60, 20);
            this.labEstado.TabIndex = 6;
            this.labEstado.Text = "Estado";
            // 
            // txbNumRegistro
            // 
            this.txbNumRegistro.Location = new System.Drawing.Point(213, 42);
            this.txbNumRegistro.Name = "txbNumRegistro";
            this.txbNumRegistro.Size = new System.Drawing.Size(249, 26);
            this.txbNumRegistro.TabIndex = 7;
            this.txbNumRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // txbISBN
            // 
            this.txbISBN.Location = new System.Drawing.Point(213, 97);
            this.txbISBN.Name = "txbISBN";
            this.txbISBN.Size = new System.Drawing.Size(249, 26);
            this.txbISBN.TabIndex = 8;
            this.txbISBN.TextChanged += new System.EventHandler(this.txbISBN_TextChanged);
            // 
            // txbVolumenes
            // 
            this.txbVolumenes.Location = new System.Drawing.Point(213, 207);
            this.txbVolumenes.Name = "txbVolumenes";
            this.txbVolumenes.Size = new System.Drawing.Size(249, 26);
            this.txbVolumenes.TabIndex = 10;
            this.txbVolumenes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // txbObservaciones
            // 
            this.txbObservaciones.Location = new System.Drawing.Point(662, 42);
            this.txbObservaciones.Name = "txbObservaciones";
            this.txbObservaciones.Size = new System.Drawing.Size(224, 26);
            this.txbObservaciones.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(568, 199);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(110, 42);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnResetear
            // 
            this.btnResetear.Location = new System.Drawing.Point(723, 199);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(110, 42);
            this.btnResetear.TabIndex = 15;
            this.btnResetear.Text = "Resetear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // txbTitulo
            // 
            this.txbTitulo.Location = new System.Drawing.Point(213, 152);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(249, 26);
            this.txbTitulo.TabIndex = 9;
            // 
            // DTPFechaCompra
            // 
            this.DTPFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFechaCompra.Location = new System.Drawing.Point(213, 260);
            this.DTPFechaCompra.Name = "DTPFechaCompra";
            this.DTPFechaCompra.Size = new System.Drawing.Size(249, 26);
            this.DTPFechaCompra.TabIndex = 16;
            this.DTPFechaCompra.Value = new System.DateTime(2017, 12, 22, 9, 35, 22, 0);
            // 
            // CBEstado
            // 
            this.CBEstado.BackColor = System.Drawing.Color.White;
            this.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBEstado.FormattingEnabled = true;
            this.CBEstado.Items.AddRange(new object[] {
            "Alta",
            "Baja"});
            this.CBEstado.Location = new System.Drawing.Point(662, 97);
            this.CBEstado.Name = "CBEstado";
            this.CBEstado.Size = new System.Drawing.Size(128, 28);
            this.CBEstado.TabIndex = 17;
            // 
            // frmInsertarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 331);
            this.Controls.Add(this.CBEstado);
            this.Controls.Add(this.DTPFechaCompra);
            this.Controls.Add(this.btnResetear);
            this.Controls.Add(this.btnInsertar);
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
            this.Name = "frmInsertarLibros";
            this.Text = "Insertar nuevo libro";
            this.Load += new System.EventHandler(this.frmInsertarLibros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumRegistro;
        private System.Windows.Forms.Label labObservaciones;
        private System.Windows.Forms.Label labFechaCompra;
        private System.Windows.Forms.Label labVolumenes;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.Label labISBN;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.TextBox txbNumRegistro;
        private System.Windows.Forms.TextBox txbISBN;
        private System.Windows.Forms.TextBox txbVolumenes;
        private System.Windows.Forms.TextBox txbObservaciones;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.TextBox txbTitulo;
        private System.Windows.Forms.DateTimePicker DTPFechaCompra;
        private System.Windows.Forms.ComboBox CBEstado;
    }
}