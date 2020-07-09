namespace AlumnosLibrosRB.Vistas
{
    partial class frmConsultarLibrosAlumno
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
            this.LVLibrosAlumno.Location = new System.Drawing.Point(41, 24);
            this.LVLibrosAlumno.Name = "LVLibrosAlumno";
            this.LVLibrosAlumno.Size = new System.Drawing.Size(1030, 219);
            this.LVLibrosAlumno.TabIndex = 0;
            this.LVLibrosAlumno.UseCompatibleStateImageBehavior = false;
            this.LVLibrosAlumno.View = System.Windows.Forms.View.Details;
            // 
            // CHNumRegistro
            // 
            this.CHNumRegistro.Text = "NumRegistro";
            this.CHNumRegistro.Width = 125;
            // 
            // CHISBN
            // 
            this.CHISBN.Text = "ISBN";
            this.CHISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHISBN.Width = 175;
            // 
            // CHTitulo
            // 
            this.CHTitulo.Text = "Titulo";
            this.CHTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHTitulo.Width = 225;
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
            this.CHObservaciones.Width = 150;
            // 
            // CHEstado
            // 
            this.CHEstado.Text = "Estado";
            this.CHEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CHEstado.Width = 100;
            // 
            // frmLibrosAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 281);
            this.Controls.Add(this.LVLibrosAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmLibrosAlumno";
            this.Text = "Libros del alumno";
            this.Load += new System.EventHandler(this.frmLibrosAlumno_Load);
            this.ResumeLayout(false);

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
    }
}