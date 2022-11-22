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
    public partial class frmAsignarMateria : Form
    {
        private Administracion gestion;
        private Profesor profesor;
        public frmAsignarMateria()
        {
            InitializeComponent();
        }
        public frmAsignarMateria(Administracion gestion, Profesor profesor) : this() 
        {
            this.gestion = gestion;
            this.profesor = profesor;
        }

        private void frmAsignarMateria_Load(object sender, EventArgs e)
        {
            lstMaterias.DataSource = null;
            lstMateriasAsignadas.DataSource = null;
            ActualizarListas();
            lblNombre.Text = $"{profesor.Apellido}, {profesor.Nombre}";

        }
        private void ActualizarListas() 
        {
            try
            {
                
                lstMaterias.DataSource = GestorSQL.LeerMateria();
                lstMateriasAsignadas.DataSource = GestorSQL.LeerMateriaAsignada(profesor);
            }

            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {

                Materia materia = (Materia)lstMaterias.SelectedItem;
                GestorSQL.GuardarMateriaAsignada(materia, profesor);

               
            }

            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.");
            }
            finally 
            {
                ActualizarListas();
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
