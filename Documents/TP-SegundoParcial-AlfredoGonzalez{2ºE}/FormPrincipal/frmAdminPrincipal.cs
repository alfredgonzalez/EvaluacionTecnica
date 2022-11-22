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

namespace Vista
{
    public partial class frmAdminPrincipal : Form
    {
        private Administracion gestion;
        
        
        public frmAdminPrincipal()
        {
            InitializeComponent();
        }
        public frmAdminPrincipal(Administracion gestion) :this()
        {
           this.gestion = gestion;
        }

        private void frmAdminPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void ActualizarListas() 
        {
            this.lstAlumnos.DataSource = null;
            this.lstProfesores.DataSource = null;
            this.lstAlumnos.DataSource = GestorSQL.LeerAlumno();
            this.lstProfesores.DataSource = GestorSQL.LeerProfesor();

        }

        private void btnCambiarEstadoAlumno_Click(object sender, EventArgs e)
        {
            if(this.lstAlumnos.SelectedIndex != -1) 
            {
                Alumno alumno = (Alumno)this.lstAlumnos.SelectedItem;
                frmEstadoAlumno frm = new frmEstadoAlumno(this.gestion, alumno);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Error, selecciona algun alumno", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAltaAlumno_Click(object sender, EventArgs e)
        {
            frmAltaAlumno frm = new frmAltaAlumno(gestion);
            frm.ShowDialog();
            ActualizarListas();
        }

        private void btnAltaProfesor_Click(object sender, EventArgs e)
        {
            frmAltaProfesor frm = new frmAltaProfesor(gestion);
            frm.ShowDialog();
            ActualizarListas();
        }

        private void btnAltaAdmin_Click(object sender, EventArgs e)
        {
            frmAltaAdmin frm = new frmAltaAdmin(gestion);
            frm.ShowDialog();
            ActualizarListas();
        }

        private void btnAltaMateria_Click(object sender, EventArgs e)
        {
            frmAltaMateria frm = new frmAltaMateria(gestion);
            frm.ShowDialog();
        }

        private void btnAsignarMateria_Click(object sender, EventArgs e)
        {
            if(this.lstProfesores.SelectedIndex != -1) 
            {
                Profesor profesor = (Profesor)lstProfesores.SelectedItem;
                frmAsignarMateria frm = new frmAsignarMateria(gestion, profesor);
                frm.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Error, selecciona algun profesor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            frmExportarMateria frm = new frmExportarMateria();
            frm.ShowDialog();
        }

        private void btnCargarListas_Click(object sender, EventArgs e)
        {
            //.InformarTiempo += CargandoCosto;
            //Task tarea = Task.Run(() => .IniciarCalculo());
            frmCarga frm = new frmCarga();
            frm.ShowDialog();

            ActualizarListas();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
