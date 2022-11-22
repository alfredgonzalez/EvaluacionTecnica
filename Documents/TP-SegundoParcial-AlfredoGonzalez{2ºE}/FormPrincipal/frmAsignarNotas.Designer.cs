namespace Vista
{
    partial class frmAsignarNotas
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
            this.lstAlumnos = new System.Windows.Forms.ListBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.cmbNotas = new System.Windows.Forms.ComboBox();
            this.lstExamenes = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstAlumnos
            // 
            this.lstAlumnos.BackColor = System.Drawing.Color.SlateGray;
            this.lstAlumnos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstAlumnos.ForeColor = System.Drawing.Color.White;
            this.lstAlumnos.FormattingEnabled = true;
            this.lstAlumnos.ItemHeight = 23;
            this.lstAlumnos.Location = new System.Drawing.Point(12, 32);
            this.lstAlumnos.Name = "lstAlumnos";
            this.lstAlumnos.Size = new System.Drawing.Size(549, 119);
            this.lstAlumnos.TabIndex = 0;
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.ForeColor = System.Drawing.Color.White;
            this.lblMateria.Location = new System.Drawing.Point(12, 6);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(55, 23);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "label1";
            // 
            // btnAsignar
            // 
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsignar.ForeColor = System.Drawing.Color.White;
            this.btnAsignar.Location = new System.Drawing.Point(12, 118);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(135, 41);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // cmbNotas
            // 
            this.cmbNotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNotas.FormattingEnabled = true;
            this.cmbNotas.Location = new System.Drawing.Point(12, 21);
            this.cmbNotas.Name = "cmbNotas";
            this.cmbNotas.Size = new System.Drawing.Size(135, 28);
            this.cmbNotas.TabIndex = 3;
            // 
            // lstExamenes
            // 
            this.lstExamenes.BackColor = System.Drawing.Color.SlateGray;
            this.lstExamenes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstExamenes.ForeColor = System.Drawing.Color.White;
            this.lstExamenes.FormattingEnabled = true;
            this.lstExamenes.ItemHeight = 23;
            this.lstExamenes.Location = new System.Drawing.Point(12, 201);
            this.lstExamenes.Name = "lstExamenes";
            this.lstExamenes.Size = new System.Drawing.Size(549, 96);
            this.lstExamenes.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 204);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 42);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbNotas);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAsignar);
            this.panel1.Location = new System.Drawing.Point(581, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 265);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Examenes";
            // 
            // frmAsignarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(758, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstExamenes);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lstAlumnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignarNotas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Notas";
            this.Load += new System.EventHandler(this.frmAsignarNotas_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstAlumnos;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.ComboBox cmbNotas;
        private System.Windows.Forms.ListBox lstExamenes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}