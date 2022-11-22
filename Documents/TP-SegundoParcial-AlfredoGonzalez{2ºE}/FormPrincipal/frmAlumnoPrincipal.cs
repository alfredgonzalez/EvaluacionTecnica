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
    public partial class frmAlumnoPrincipal : Form
    {
        private Administracion gestion;
        private Alumno alumno;
        public frmAlumnoPrincipal()
        {
            InitializeComponent();
        }
        public frmAlumnoPrincipal(Administracion gestion, Alumno alumno) :this()
        {
            this.gestion = gestion;
            this.alumno = alumno;
        }

        private void frmAlumnoPrincipal_Load(object sender, EventArgs e)
        {
            
            this.alumno.MateriasAprobadas = GestorSQL.LeerMateriasAprobadasAlumno(this.alumno);
            this.lblNombre.Text = $"{this.alumno.Apellido}, {this.alumno.Nombre}";
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            frmInscripcionAlumno frm = new frmInscripcionAlumno(this.gestion, this.alumno);
            frm.ShowDialog();
            ActualizarListas();
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            
            try 
            {
                if (lstMateriaInscriptas.SelectedIndex != -1)
                {
                    Materia matAux = (Materia)lstMateriaInscriptas.SelectedItem;
                    string mensaje = GestorSQL.GuardarAsistencia(this.alumno, matAux, DateTime.Now);
                    MessageBox.Show(mensaje, "Asistencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Error,no hay ninguna materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(CargaInvalidaSQLExcepcion ex) 
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception) 
            {
                MessageBox.Show("Error!");
            }
        }
        private void ActualizarListas() 
        {
            try 
            {
                this.lstMateriaInscriptas.DataSource = null;
                this.lstMateriaInscriptas.DataSource = GestorSQL.LeerMateriaInscriptaAlumno(this.alumno);
                this.lstMateriasAprobadas.DataSource = null;
                this.lstMateriasAprobadas.DataSource = GestorSQL.LeerMateriasAprobadas(this.alumno);

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

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            frmCarga frm = new frmCarga();
            frm.ShowDialog();

            ActualizarListas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
