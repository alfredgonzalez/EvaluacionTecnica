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
    public partial class frmAltaMateria : Form
    {
        private Administracion gestion;
        public frmAltaMateria()
        {
            InitializeComponent();
        }
        public frmAltaMateria(Administracion gestion) :this()
        {
            this.gestion = gestion;
        }

        private void frmAltaMateria_Load(object sender, EventArgs e)
        {
            cmbCuatrimestre.Items.Clear();
            cmbCuatrimestre.Items.Add("Primer Cuatrimestre");
            cmbCuatrimestre.Items.Add("Segundo Cuatrimestre");
            cmbCuatrimestre.SelectedIndex = 0;
            cmbCorrelativa.DataSource = null;

            cmbCorrelativa.DataSource = GestorSQL.LeerMateriaDescripcion(); 


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarCamposPersona(txtNombre.Text))
                {

                    if (Validar.ValidarNombre(txtNombre.Text) && cmbCorrelativa.SelectedIndex != -1 && cmbCuatrimestre.SelectedIndex != -1)
                    {
                        Materia materia = new Materia(txtNombre.Text, cmbCuatrimestre.Text);

                        int idCorrelativa = GestorSQL.LeerIdCorrelativa(cmbCorrelativa.SelectedValue.ToString());
                        materia.IdCorrelativa = idCorrelativa;
                        string mensaje = gestion + materia;
                        GestorSQL.GuardarMateria(materia);
                        GestorSQL.GuardarMateriaCorrelativa(materia);
                        MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    else 
                    {
                        MessageBox.Show("Error al guardar", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (CamposVaciosONullExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NombreInvalidoExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (CargaInvalidaSQLExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Error.Ingrese los datos nuevamente!");
            }
        }

        private void cmbCorrelativa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
