namespace Vista
{
    partial class frmExportarMateria
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
            this.btnJson = new System.Windows.Forms.Button();
            this.btnCsv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lstMaterias.Location = new System.Drawing.Point(12, 39);
            this.lstMaterias.Name = "lstMaterias";
            this.lstMaterias.Size = new System.Drawing.Size(674, 257);
            this.lstMaterias.TabIndex = 0;
            // 
            // btnJson
            // 
            this.btnJson.FlatAppearance.BorderSize = 0;
            this.btnJson.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJson.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJson.ForeColor = System.Drawing.Color.White;
            this.btnJson.Location = new System.Drawing.Point(21, 14);
            this.btnJson.Name = "btnJson";
            this.btnJson.Size = new System.Drawing.Size(209, 50);
            this.btnJson.TabIndex = 1;
            this.btnJson.Text = "Exportar JSON";
            this.btnJson.UseVisualStyleBackColor = true;
            this.btnJson.Click += new System.EventHandler(this.btnJson_Click);
            // 
            // btnCsv
            // 
            this.btnCsv.FlatAppearance.BorderSize = 0;
            this.btnCsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCsv.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCsv.ForeColor = System.Drawing.Color.White;
            this.btnCsv.Location = new System.Drawing.Point(21, 104);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(209, 50);
            this.btnCsv.TabIndex = 2;
            this.btnCsv.Text = "Exporta CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnJson);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnCsv);
            this.panel1.Location = new System.Drawing.Point(704, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 257);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Exportar Materia";
            // 
            // frmExportarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(966, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lstMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExportarMateria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Materia";
            this.Load += new System.EventHandler(this.frmExportarMateria_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.Button btnJson;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}