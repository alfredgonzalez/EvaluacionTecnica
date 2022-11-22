namespace Vista
{
    partial class frmAlumnoPrincipal
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
            this.lstMateriaInscriptas = new System.Windows.Forms.ListBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.lstMateriasAprobadas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsistencia = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMateriaInscriptas
            // 
            this.lstMateriaInscriptas.BackColor = System.Drawing.Color.SlateGray;
            this.lstMateriaInscriptas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMateriaInscriptas.ForeColor = System.Drawing.Color.White;
            this.lstMateriaInscriptas.FormattingEnabled = true;
            this.lstMateriaInscriptas.ItemHeight = 28;
            this.lstMateriaInscriptas.Location = new System.Drawing.Point(12, 92);
            this.lstMateriaInscriptas.Name = "lstMateriaInscriptas";
            this.lstMateriaInscriptas.Size = new System.Drawing.Size(772, 60);
            this.lstMateriaInscriptas.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(78, 32);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materias Inscriptas";
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.FlatAppearance.BorderSize = 0;
            this.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInscripcion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInscripcion.ForeColor = System.Drawing.Color.White;
            this.btnInscripcion.Location = new System.Drawing.Point(220, 165);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(169, 66);
            this.btnInscripcion.TabIndex = 3;
            this.btnInscripcion.Text = "Inscribirse A Materia";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // lstMateriasAprobadas
            // 
            this.lstMateriasAprobadas.BackColor = System.Drawing.Color.SlateGray;
            this.lstMateriasAprobadas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMateriasAprobadas.ForeColor = System.Drawing.Color.White;
            this.lstMateriasAprobadas.FormattingEnabled = true;
            this.lstMateriasAprobadas.ItemHeight = 28;
            this.lstMateriasAprobadas.Location = new System.Drawing.Point(12, 219);
            this.lstMateriasAprobadas.Name = "lstMateriasAprobadas";
            this.lstMateriasAprobadas.Size = new System.Drawing.Size(772, 200);
            this.lstMateriasAprobadas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Materias Aprobadas";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Location = new System.Drawing.Point(220, 21);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(169, 66);
            this.btnAsistencia.TabIndex = 6;
            this.btnAsistencia.Text = "Dar Asistencia";
            this.btnAsistencia.UseVisualStyleBackColor = true;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.FlatAppearance.BorderSize = 0;
            this.btnCargarDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarDatos.ForeColor = System.Drawing.Color.White;
            this.btnCargarDatos.Location = new System.Drawing.Point(23, 21);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(170, 354);
            this.btnCargarDatos.TabIndex = 7;
            this.btnCargarDatos.Text = "Cargar Materias";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnCargarDatos);
            this.panel1.Controls.Add(this.btnInscripcion);
            this.panel1.Location = new System.Drawing.Point(802, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 390);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAlumnoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1222, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMateriasAprobadas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lstMateriaInscriptas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAlumnoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumno Principal";
            this.Load += new System.EventHandler(this.frmAlumnoPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMateriaInscriptas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.ListBox lstMateriasAprobadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsistencia;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}