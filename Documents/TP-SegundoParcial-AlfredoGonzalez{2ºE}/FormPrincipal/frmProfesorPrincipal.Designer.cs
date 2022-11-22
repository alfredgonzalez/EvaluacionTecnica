namespace Vista
{
    partial class frmProfesorPrincipal
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
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lstMaterias = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnVerExamenes = new System.Windows.Forms.Button();
            this.btnNotas = new System.Windows.Forms.Button();
            this.btnCargarListas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfesor.ForeColor = System.Drawing.Color.White;
            this.lblProfesor.Location = new System.Drawing.Point(12, 9);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(81, 35);
            this.lblProfesor.TabIndex = 0;
            this.lblProfesor.Text = "label1";
            // 
            // lstMaterias
            // 
            this.lstMaterias.BackColor = System.Drawing.Color.SlateGray;
            this.lstMaterias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMaterias.ForeColor = System.Drawing.Color.White;
            this.lstMaterias.FormattingEnabled = true;
            this.lstMaterias.ItemHeight = 25;
            this.lstMaterias.Location = new System.Drawing.Point(12, 53);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.Size = new System.Drawing.Size(752, 354);
            this.lstMaterias.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(177, 76);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(138, 39);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Crear Examen";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(809, 53);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(292, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnVerExamenes
            // 
            this.btnVerExamenes.FlatAppearance.BorderSize = 0;
            this.btnVerExamenes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVerExamenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerExamenes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVerExamenes.ForeColor = System.Drawing.Color.White;
            this.btnVerExamenes.Location = new System.Drawing.Point(177, 158);
            this.btnVerExamenes.Name = "btnVerExamenes";
            this.btnVerExamenes.Size = new System.Drawing.Size(138, 39);
            this.btnVerExamenes.TabIndex = 4;
            this.btnVerExamenes.Text = "Ver Examenes";
            this.btnVerExamenes.UseVisualStyleBackColor = true;
            this.btnVerExamenes.Click += new System.EventHandler(this.btnVerExamenes_Click);
            // 
            // btnNotas
            // 
            this.btnNotas.FlatAppearance.BorderSize = 0;
            this.btnNotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotas.ForeColor = System.Drawing.Color.White;
            this.btnNotas.Location = new System.Drawing.Point(177, 245);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(138, 39);
            this.btnNotas.TabIndex = 5;
            this.btnNotas.Text = "Ver Alumnos";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // btnCargarListas
            // 
            this.btnCargarListas.FlatAppearance.BorderSize = 0;
            this.btnCargarListas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCargarListas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarListas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarListas.ForeColor = System.Drawing.Color.White;
            this.btnCargarListas.Location = new System.Drawing.Point(23, 76);
            this.btnCargarListas.Name = "btnCargarListas";
            this.btnCargarListas.Size = new System.Drawing.Size(148, 297);
            this.btnCargarListas.TabIndex = 6;
            this.btnCargarListas.Text = "Cargar Listas";
            this.btnCargarListas.UseVisualStyleBackColor = true;
            this.btnCargarListas.Click += new System.EventHandler(this.btnCargarListas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnNotas);
            this.panel1.Controls.Add(this.btnVerExamenes);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.btnCargarListas);
            this.panel1.Location = new System.Drawing.Point(786, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 388);
            this.panel1.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(177, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 39);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmProfesorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1142, 433);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lstMaterias);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfesorPrincipal";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesor Principal";
            this.Load += new System.EventHandler(this.frmProfesorPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnVerExamenes;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.Button btnCargarListas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}