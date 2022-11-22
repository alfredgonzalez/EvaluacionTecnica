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
using entidades.Clases;

namespace Vista
{
    public partial class frmProfesorPrincipal : Form
    {
        private Administracion gestion;
        private Profesor profesor;
        public frmProfesorPrincipal()
        {
            InitializeComponent();
        }
        public frmProfesorPrincipal(Administracion gestion, Profesor profesor) : this() 
        {
            this.gestion = gestion;
            this.profesor = profesor;
        }

        private void frmProfesorPrincipal_Load(object sender, EventArgs e)
        {
            this.lblProfesor.Text = $"{this.profesor.Apellido}, {this.profesor.Nombre}";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (lstMaterias.SelectedIndex != -1)
                {
                    Materia materiaAux = (Materia)lstMaterias.SelectedItem;
                    GestorSQL.GuardarExamen(materiaAux, profesor, this.dateTimePicker1.Value);
                }
                else
                {
                    MessageBox.Show("Error,no hay ninguna materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void btnVerExamenes_Click(object sender, EventArgs e)
        {
            if (lstMaterias.SelectedIndex != -1)
            {
                Materia materiaAux = (Materia)lstMaterias.SelectedItem;
                List<Examen> list = GestorSQL.LeerExamen(materiaAux);
                StringBuilder sb = new StringBuilder();
                foreach (Examen item in list)
                {
                    sb.AppendLine(item.ToString());
                }
                MessageBox.Show(sb.ToString(), "Examenes", MessageBoxButtons.OK);
            }
            else 
            {
                MessageBox.Show("Error,no hay ninguna materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            if(lstMaterias.SelectedIndex != -1) 
            {
                Materia materiaAux = (Materia)lstMaterias.SelectedItem;
                frmAsignarNotas frm = new frmAsignarNotas(gestion, materiaAux);
                frm.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Error,no hay ninguna materia seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCargarListas_Click(object sender, EventArgs e)
        {
            frmCarga frm = new frmCarga();
            frm.ShowDialog();

            ActualizarListas();
        }
        private void ActualizarListas() 
        {
            lstMaterias.DataSource = null;
            lstMaterias.DataSource = GestorSQL.LeerMateriaAsignada(profesor);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
