namespace Vista
{
    partial class frmLoggin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCargarAdmin = new System.Windows.Forms.Button();
            this.btnCargarProfesor = new System.Windows.Forms.Button();
            this.btnCargarAlumno = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(201, 27);
            this.txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(12, 124);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(200, 27);
            this.txtPass.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(68, 23);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Usuario";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(12, 87);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(97, 23);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Contraseña";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(12, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 29);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnCargarAdmin
            // 
            this.btnCargarAdmin.FlatAppearance.BorderSize = 0;
            this.btnCargarAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAdmin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCargarAdmin.Location = new System.Drawing.Point(17, 26);
            this.btnCargarAdmin.Name = "btnCargarAdmin";
            this.btnCargarAdmin.Size = new System.Drawing.Size(180, 31);
            this.btnCargarAdmin.TabIndex = 5;
            this.btnCargarAdmin.Text = "Cargar Admin";
            this.btnCargarAdmin.UseVisualStyleBackColor = true;
            this.btnCargarAdmin.Click += new System.EventHandler(this.btnCargarAdmin_Click);
            // 
            // btnCargarProfesor
            // 
            this.btnCargarProfesor.FlatAppearance.BorderSize = 0;
            this.btnCargarProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarProfesor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarProfesor.ForeColor = System.Drawing.Color.White;
            this.btnCargarProfesor.Location = new System.Drawing.Point(17, 84);
            this.btnCargarProfesor.Name = "btnCargarProfesor";
            this.btnCargarProfesor.Size = new System.Drawing.Size(180, 29);
            this.btnCargarProfesor.TabIndex = 6;
            this.btnCargarProfesor.Text = "Cargar Profesor";
            this.btnCargarProfesor.UseVisualStyleBackColor = true;
            this.btnCargarProfesor.Click += new System.EventHandler(this.btnCargarProfesor_Click);
            // 
            // btnCargarAlumno
            // 
            this.btnCargarAlumno.FlatAppearance.BorderSize = 0;
            this.btnCargarAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCargarAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarAlumno.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCargarAlumno.ForeColor = System.Drawing.Color.White;
            this.btnCargarAlumno.Location = new System.Drawing.Point(17, 148);
            this.btnCargarAlumno.Name = "btnCargarAlumno";
            this.btnCargarAlumno.Size = new System.Drawing.Size(180, 29);
            this.btnCargarAlumno.TabIndex = 7;
            this.btnCargarAlumno.Text = "Cargar Alumno";
            this.btnCargarAlumno.UseVisualStyleBackColor = true;
            this.btnCargarAlumno.Click += new System.EventHandler(this.btnCargarAlumno_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(128, 172);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 29);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnCargarAdmin);
            this.panel1.Controls.Add(this.btnCargarProfesor);
            this.panel1.Controls.Add(this.btnCargarAlumno);
            this.panel1.Location = new System.Drawing.Point(263, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 189);
            this.panel1.TabIndex = 9;
            // 
            // frmLoggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(484, 220);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoggin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loggin";
            this.Load += new System.EventHandler(this.frmLoggin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCargarAdmin;
        private System.Windows.Forms.Button btnCargarProfesor;
        private System.Windows.Forms.Button btnCargarAlumno;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
    }
}
