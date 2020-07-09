namespace AlumnosLibrosRB.Vistas
{
    partial class frmPrestarLibros
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
            this.txbIDAlumno = new System.Windows.Forms.TextBox();
            this.labIDAlumno = new System.Windows.Forms.Label();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.labNumRegistro = new System.Windows.Forms.Label();
            this.txbNumRegistro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbIDAlumno
            // 
            this.txbIDAlumno.Location = new System.Drawing.Point(51, 60);
            this.txbIDAlumno.Name = "txbIDAlumno";
            this.txbIDAlumno.Size = new System.Drawing.Size(98, 26);
            this.txbIDAlumno.TabIndex = 0;
            this.txbIDAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // labIDAlumno
            // 
            this.labIDAlumno.AutoSize = true;
            this.labIDAlumno.Location = new System.Drawing.Point(60, 28);
            this.labIDAlumno.Name = "labIDAlumno";
            this.labIDAlumno.Size = new System.Drawing.Size(80, 20);
            this.labIDAlumno.TabIndex = 3;
            this.labIDAlumno.Text = "IDAlumno";
            // 
            // btnPrestar
            // 
            this.btnPrestar.Location = new System.Drawing.Point(124, 109);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(102, 41);
            this.btnPrestar.TabIndex = 2;
            this.btnPrestar.Text = "Prestar";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // labNumRegistro
            // 
            this.labNumRegistro.AutoSize = true;
            this.labNumRegistro.Location = new System.Drawing.Point(193, 28);
            this.labNumRegistro.Name = "labNumRegistro";
            this.labNumRegistro.Size = new System.Drawing.Size(102, 20);
            this.labNumRegistro.TabIndex = 4;
            this.labNumRegistro.Text = "NumRegistro";
            // 
            // txbNumRegistro
            // 
            this.txbNumRegistro.Location = new System.Drawing.Point(197, 60);
            this.txbNumRegistro.Name = "txbNumRegistro";
            this.txbNumRegistro.Size = new System.Drawing.Size(98, 26);
            this.txbNumRegistro.TabIndex = 1;
            this.txbNumRegistro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckValor);
            // 
            // frmPrestarLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 176);
            this.Controls.Add(this.labNumRegistro);
            this.Controls.Add(this.txbNumRegistro);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.labIDAlumno);
            this.Controls.Add(this.txbIDAlumno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPrestarLibros";
            this.Text = "Prestar libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIDAlumno;
        private System.Windows.Forms.Label labIDAlumno;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Label labNumRegistro;
        private System.Windows.Forms.TextBox txbNumRegistro;
    }
}