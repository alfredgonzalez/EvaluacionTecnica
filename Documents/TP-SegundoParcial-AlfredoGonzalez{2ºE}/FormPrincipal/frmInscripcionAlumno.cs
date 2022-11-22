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
using System.Linq;

namespace Vista
{
    public partial class frmInscripcionAlumno : Form
    {
        private Administracion gestion;
        private Alumno alumno;
        public frmInscripcionAlumno()
        {
            InitializeComponent();
        }
        public frmInscripcionAlumno(Administracion gestion, Alumno alumno) :this()
        {
            this.gestion = gestion;
            this.alumno = alumno;
        }

        private void frmInscripcionAlumno_Load(object sender, EventArgs e)
        {
            this.lblNombre.Text = $"{this.alumno.Apellido}, {this.alumno.Nombre}";
            ActualizarListas();
        }
        private void ActualizarListas() 
        {
            try 
            {
                List<Materia> materiasInscripcion = GestorSQL.LeerMateriasParaInscripcion(this.alumno);
                this.lstMaterias.DataSource = null;
                
                //List<Materia> materiasAprobadas = GestorSQL.LeerMateriasAprobadasAlumno(this.alumno);
                //this.alumno.MateriasAprobadas = GestorSQL.LeerMateriasAprobadasAlumno(this.alumno);
                materiasInscripcion.ForEach(item => alumno.MateriasAprobadas.Add(item));
                materiasInscripcion.Except<Materia>(alumno.MateriasAprobadas);
                this.lstMaterias.DataSource = materiasInscripcion;
            }
            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }
        }
       
 
        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            try 
            {
                if(lstMaterias.SelectedIndex != -1) 
                {
                    Materia materiaAux = (Materia)lstMaterias.SelectedItem;
                    if(materiaAux != null && alumno.MateriaUno == null || alumno.MateriaDos == null) 
                    {

                        if (alumno.MateriaUno is null)
                        {
                            this.alumno.MateriaUno = materiaAux.Nombre;
                        }
                        else
                        {
                            this.alumno.MateriaDos = materiaAux.Nombre;
                        }
                        Alumno alumnoAux = this.alumno;
                        GestorSQL.GuardarMateriaAlumno(materiaAux, alumnoAux);
                        string mensaje = materiaAux + alumno;
                        MessageBox.Show(mensaje, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else 
                    {
                        MessageBox.Show("Error el alumno ya cuenta con dos materias inscriptas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Error, selecciona alguna materia para la inscripcion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Error!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
