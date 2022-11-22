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
using entidades.Excepciones;
namespace Vista
{
    public partial class frmEstadoAlumno : Form
    {
        private Administracion gestion;
        private Alumno alumno;
        public frmEstadoAlumno()
        {
            InitializeComponent();
        }
        public frmEstadoAlumno(Administracion gestion, Alumno alumno) :this()
        {
            this.gestion = gestion;
            this.alumno = alumno;
        }

        private void frmEstadoAlumno_Load(object sender, EventArgs e)
        {
            
        }
        private void ActualizarCampos() 
        {
            try 
            {
                this.lstRegular.DataSource = null;
                this.lstRegular.DataSource = GestorSQL.LeerAsistencias(this.alumno);
                this.lblNombre.Text = $"{alumno.Apellido}, {alumno.Nombre}";
            }
            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.!");
            }
        }
        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            ActualizarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

    }
}
