namespace Vista
{
    partial class frmAdminPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alumnoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.btnCambiarEstadoAlumno = new System.Windows.Forms.Button();
            this.btnAltaAlumno = new System.Windows.Forms.Button();
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.btnAltaProfesor = new System.Windows.Forms.Button();
            this.btnAltaAdmin = new System.Windows.Forms.Button();
            this.lstProfesores = new System.Windows.Forms.ListBox();
            this.btnAltaMateria = new System.Windows.Forms.Button();
            this.btnAsignarMateria = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCargarListas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource6)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALUMNOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PROFESORES";
            // 
            // alumnoBindingSource1
            // 
            this.alumnoBindingSource1.DataSource = typeof(entidades.Alumno);
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(entidades.Alumno);
            // 
            // alumnoBindingSource2
            // 
            this.alumnoBindingSource2.DataSource = typeof(entidades.Alumno);
            // 
            // alumnoBindingSource3
            // 
            this.alumnoBindingSource3.DataSource = typeof(entidades.Alumno);
            // 
            // alumnoBindingSource4
            // 
            this.alumnoBindingSource4.DataSource = typeof(entidades.Alumno);
            // 
            // alumnoBindingSource5
            // 
            this.alumnoBindingSource5.DataSource = typeof(entidades.Alumno);
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(entidades.Profesor);
            // 
            // alumnoBindingSource6
            // 
            this.alumnoBindingSource6.DataSource = typeof(entidades.Alumno);
            // 
            // btnCambiarEstadoAlumno
            // 
            this.btnCambiarEstadoAlumno.FlatAppearance.BorderSize = 0;
            this.btnCambiarEstadoAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCambiarEstadoAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarEstadoAlumno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCambiarEstadoAlumno.ForeColor = System.Drawing.Color.White;
            this.btnCambiarEstadoAlumno.Location = new System.Drawing.Point(145, 254);
            this.btnCambiarEstadoAlumno.Name = "btnCambiarEstadoAlumno";
            this.btnCambiarEstadoAlumno.Size = new System.Drawing.Size(94, 59);
            this.btnCambiarEstadoAlumno.TabIndex = 6;
            this.btnCambiarEstadoAlumno.Text = "Cambiar Estado";
            this.btnCambiarEstadoAlumno.UseVisualStyleBackColor = true;
            this.btnCambiarEstadoAlumno.Click += new System.EventHandler(this.btnCambiarEstadoAlumno_Click);
            // 
            // btnAltaAlumno
            // 
            this.btnAltaAlumno.FlatAppearance.BorderSize = 0;
            this.btnAltaAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAltaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAlumno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAltaAlumno.Location = new System.Drawing.Point(256, 23);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(94, 59);
            this.btnAltaAlumno.TabIndex = 7;
            this.btnAltaAlumno.Text = "Alta Alumno";
            this.btnAltaAlumno.UseVisualStyleBackColor = true;
            this.btnAltaAlumno.Click += new System.EventHandler(this.btnAltaAlumno_Click);
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.BackColor = System.Drawing.Color.SlateGray;
            this.lstAlumnos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAlumnos.ForeColor = System.Drawing.Color.White;
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 23;
            this.lstAlumnos.Location = new System.Drawing.Point(12, 35);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(591, 165);
            this.lstAlumnos.TabIndex = 8;
            // 
            // btnAltaProfesor
            // 
            this.btnAltaProfesor.FlatAppearance.BorderSize = 0;
            this.btnAltaProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAltaProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProfesor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaProfesor.ForeColor = System.Drawing.Color.White;
            this.btnAltaProfesor.Location = new System.Drawing.Point(145, 23);
            this.btnAltaProfesor.Name = "btnAltaProfesor";
            this.btnAltaProfesor.Size = new System.Drawing.Size(94, 59);
            this.btnAltaProfesor.TabIndex = 9;
            this.btnAltaProfesor.Text = "Alta Profesor";
            this.btnAltaProfesor.UseVisualStyleBackColor = true;
            this.btnAltaProfesor.Click += new System.EventHandler(this.btnAltaProfesor_Click);
            // 
            // btnAltaAdmin
            // 
            this.btnAltaAdmin.FlatAppearance.BorderSize = 0;
            this.btnAltaAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAltaAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAltaAdmin.Location = new System.Drawing.Point(256, 122);
            this.btnAltaAdmin.Name = "btnAltaAdmin";
            this.btnAltaAdmin.Size = new System.Drawing.Size(94, 62);
            this.btnAltaAdmin.TabIndex = 10;
            this.btnAltaAdmin.Text = "Alta Admin";
            this.btnAltaAdmin.UseVisualStyleBackColor = true;
            this.btnAltaAdmin.Click += new System.EventHandler(this.btnAltaAdmin_Click);
            // 
            // lstProfesores
            // 
            this.lstProfesores.BackColor = System.Drawing.Color.SlateGray;
            this.lstProfesores.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstProfesores.ForeColor = System.Drawing.Color.White;
            this.lstProfesores.FormattingEnabled = true;
            this.lstProfesores.ItemHeight = 23;
            this.lstProfesores.Location = new System.Drawing.Point(12, 259);
            this.lstProfesores.Name = "lstProfesores";
            this.lstProfesores.Size = new System.Drawing.Size(591, 211);
            this.lstProfesores.TabIndex = 11;
            // 
            // btnAltaMateria
            // 
            this.btnAltaMateria.FlatAppearance.BorderSize = 0;
            this.btnAltaMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAltaMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAltaMateria.ForeColor = System.Drawing.Color.White;
            this.btnAltaMateria.Location = new System.Drawing.Point(145, 122);
            this.btnAltaMateria.Name = "btnAltaMateria";
            this.btnAltaMateria.Size = new System.Drawing.Size(94, 62);
            this.btnAltaMateria.TabIndex = 12;
            this.btnAltaMateria.Text = "Alta materia";
            this.btnAltaMateria.UseVisualStyleBackColor = true;
            this.btnAltaMateria.Click += new System.EventHandler(this.btnAltaMateria_Click);
            // 
            // btnAsignarMateria
            // 
            this.btnAsignarMateria.FlatAppearance.BorderSize = 0;
            this.btnAsignarMateria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAsignarMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignarMateria.ForeColor = System.Drawing.Color.White;
            this.btnAsignarMateria.Location = new System.Drawing.Point(256, 254);
            this.btnAsignarMateria.Name = "btnAsignarMateria";
            this.btnAsignarMateria.Size = new System.Drawing.Size(94, 59);
            this.btnAsignarMateria.TabIndex = 13;
            this.btnAsignarMateria.Text = "Asignar Materia";
            this.btnAsignarMateria.UseVisualStyleBackColor = true;
            this.btnAsignarMateria.Click += new System.EventHandler(this.btnAsignarMateria_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(145, 367);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(94, 50);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCargarListas
            // 
            this.btnCargarListas.FlatAppearance.BorderSize = 0;
            this.btnCargarListas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarListas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarListas.ForeColor = System.Drawing.Color.White;
            this.btnCargarListas.Location = new System.Drawing.Point(3, 3);
            this.btnCargarListas.Name = "btnCargarListas";
            this.btnCargarListas.Size = new System.Drawing.Size(123, 433);
            this.btnCargarListas.TabIndex = 17;
            this.btnCargarListas.Text = "Cargar Listas";
            this.btnCargarListas.UseVisualStyleBackColor = true;
            this.btnCargarListas.Click += new System.EventHandler(this.btnCargarListas_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnCargarListas);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnAltaProfesor);
            this.panel1.Controls.Add(this.btnAsignarMateria);
            this.panel1.Controls.Add(this.btnCambiarEstadoAlumno);
            this.panel1.Controls.Add(this.btnAltaMateria);
            this.panel1.Controls.Add(this.btnAltaAdmin);
            this.panel1.Controls.Add(this.btnAltaAlumno);
            this.panel1.Location = new System.Drawing.Point(627, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 435);
            this.panel1.TabIndex = 18;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(256, 367);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 50);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1017, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstProfesores);
            this.Controls.Add(this.lstAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdminPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.BindingSource alumnoBindingSource1;
        private System.Windows.Forms.BindingSource alumnoBindingSource2;
        private System.Windows.Forms.BindingSource alumnoBindingSource3;
        private System.Windows.Forms.BindingSource alumnoBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaEnCursoUnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaEnCursoDosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnoBindingSource5;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource alumnoBindingSource6;
        private System.Windows.Forms.Button btnCambiarEstadoAlumno;
        private System.Windows.Forms.Button btnAltaAlumno;
        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Button btnAltaProfesor;
        private System.Windows.Forms.Button btnAltaAdmin;
        private System.Windows.Forms.ListBox lstProfesores;
        private System.Windows.Forms.Button btnAltaMateria;
        private System.Windows.Forms.Button btnAsignarMateria;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCargarListas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
    }
}