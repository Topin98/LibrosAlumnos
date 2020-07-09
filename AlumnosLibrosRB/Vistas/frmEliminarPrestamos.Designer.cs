namespace AlumnosLibrosRB.Vistas
{
    partial class frmEliminarPrestamos
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
            this.txbNumRegistro = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.labIDAlumno = new System.Windows.Forms.Label();
            this.txbIDAlumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labNumRegistro
            // 
            this.labNumRegistro.AutoSize = true;
            this.labNumRegistro.Location = new System.Drawing.Point(186, 36);
            this.labNumRegistro.Name = "labNumRegistro";
            this.labNumRegistro.Size = new System.Drawing.Size(102, 20);
            this.labNumRegistro.TabIndex = 9;
            this.labNumRegistro.Text = "NumRegistro";
            // 
            // txbNumRegistro
            // 
            this.txbNumRegistro.Location = new System.Drawing.Point(190, 68);
            this.txbNumRegistro.Name = "txbNumRegistro";
            this.txbNumRegistro.Size = new System.Drawing.Size(98, 26);
            this.txbNumRegistro.TabIndex = 6;
            this.txbNumRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(117, 117);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(102, 41);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // labIDAlumno
            // 
            this.labIDAlumno.AutoSize = true;
            this.labIDAlumno.Location = new System.Drawing.Point(53, 36);
            this.labIDAlumno.Name = "labIDAlumno";
            this.labIDAlumno.Size = new System.Drawing.Size(80, 20);
            this.labIDAlumno.TabIndex = 8;
            this.labIDAlumno.Text = "IDAlumno";
            // 
            // txbIDAlumno
            // 
            this.txbIDAlumno.Location = new System.Drawing.Point(44, 68);
            this.txbIDAlumno.Name = "txbIDAlumno";
            this.txbIDAlumno.Size = new System.Drawing.Size(98, 26);
            this.txbIDAlumno.TabIndex = 5;
            this.txbIDAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // frmBorrarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 187);
            this.Controls.Add(this.labNumRegistro);
            this.Controls.Add(this.txbNumRegistro);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.labIDAlumno);
            this.Controls.Add(this.txbIDAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmBorrarPrestamos";
            this.Text = "Borrar prestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumRegistro;
        private System.Windows.Forms.TextBox txbNumRegistro;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label labIDAlumno;
        private System.Windows.Forms.TextBox txbIDAlumno;
    }
}