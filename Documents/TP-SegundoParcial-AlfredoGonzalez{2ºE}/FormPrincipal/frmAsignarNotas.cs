using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using entidades;
using entidades.Clases;
using entidades.Excepciones;

namespace Vista
{
    public partial class frmAsignarNotas : Form
    {
        private Administracion gestion;
        private Materia materia;
        private Alumno alumno;
   
        public frmAsignarNotas()
        {
            InitializeComponent();
        }
        public frmAsignarNotas(Administracion gestion, Materia materia) : this() 
        {
            this.gestion = gestion;
            this.materia = materia;
            this.alumno = new Alumno();
        }

        private void frmAsignarNotas_Load(object sender, EventArgs e)
        {
            this.lstAlumnos.DataSource = null;
            this.lstAlumnos.DataSource = GestorSQL.LeerAlumnoMateria(materia);
            this.cmbNotas.Items.Add(1);
            this.cmbNotas.Items.Add(2);
            this.cmbNotas.Items.Add(3);
            this.cmbNotas.Items.Add(4);
            this.cmbNotas.Items.Add(5);
            this.cmbNotas.Items.Add(6);
            this.cmbNotas.Items.Add(7);
            this.cmbNotas.Items.Add(8);
            this.cmbNotas.Items.Add(9);
            this.cmbNotas.Items.Add(10);
            this.lstExamenes.DataSource = null;
            this.lstExamenes.DataSource = GestorSQL.LeerExamen(materia);
            this.cmbNotas.SelectedIndex = 0;
            this.lblMateria.Text = $"{this.materia.Nombre}";
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try 
            {
                if(this.lstAlumnos.SelectedIndex != -1 && this.lstExamenes.SelectedIndex != -1) 
                {
                    Examen examen = (Examen)this.lstExamenes.SelectedItem;
                    Alumno alumno = (Alumno)this.lstAlumnos.SelectedItem;
                    
                    GestorSQL.GuardarNotaExamen(examen, alumno, Convert.ToInt32(cmbNotas.SelectedItem));
                    if(alumno.NotaUno == 0) 
                    {
                        alumno.NotaUno = Convert.ToInt32(cmbNotas.SelectedItem);
                    }
                    else if(alumno.NotaUno != 0 && alumno.NotaDos == 0) 
                    {
                        alumno.NotaDos = Convert.ToInt32(cmbNotas.SelectedItem);
                    }
                    if (this.alumno.NotaUno >= 6 && this.alumno.NotaUno >= 6)
                    {
                        GestorSQL.GuardarMateriaAprobadaAlumno(alumno, this.materia);
                    }

                    MessageBox.Show("Nota guardada con exito", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(CargaInvalidaSQLExcepcion ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception) 
            {
                MessageBox.Show("error!");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
          
            this.DialogResult = DialogResult.OK;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }


    }
}
