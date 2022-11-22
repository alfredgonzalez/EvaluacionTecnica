namespace Vista
{
    partial class frmInscripcionAlumno
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
            this.lstMaterias = new System.Windows.Forms.ListBox();
            this.btnInscribirse = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMaterias
            // 
            this.lstMaterias.BackColor = System.Drawing.Color.SlateGray;
            this.lstMaterias.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMaterias.ForeColor = System.Drawing.Color.White;
            this.lstMaterias.FormattingEnabled = true;
            this.lstMaterias.ItemHeight = 23;
            this.lstMaterias.Location = new System.Drawing.Point(12, 37);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.Size = new System.Drawing.Size(741, 165);
            this.lstMaterias.TabIndex = 0;
            // 
            // btnInscribirse
            // 
            this.btnInscribirse.FlatAppearance.BorderSize = 0;
            this.btnInscribirse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnInscribirse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscribirse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInscribirse.ForeColor = System.Drawing.Color.White;
            this.btnInscribirse.Location = new System.Drawing.Point(23, 16);
            this.btnInscribirse.Name = "btnInscribirse";
            this.btnInscribirse.Size = new System.Drawing.Size(199, 32);
            this.btnInscribirse.TabIndex = 1;
            this.btnInscribirse.Text = "Inscribirse";
            this.btnInscribirse.UseVisualStyleBackColor = true;
            this.btnInscribirse.Click += new System.EventHandler(this.btnInscribirse_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 23);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnInscribirse);
            this.panel1.Location = new System.Drawing.Point(774, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 165);
            this.panel1.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(23, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInscripcionAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1022, 222);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInscripcionAlumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscripcion Alumno";
            this.Load += new System.EventHandler(this.frmInscripcionAlumno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.Button btnInscribirse;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
    }
}