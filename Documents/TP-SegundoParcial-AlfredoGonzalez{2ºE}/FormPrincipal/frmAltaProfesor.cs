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
    public partial class frmAltaProfesor : Form
    {
        private Administracion gestion;
        public frmAltaProfesor()
        {
            InitializeComponent();
        }
        public frmAltaProfesor(Administracion gestion):this()
        {
            this.gestion = gestion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar.ValidarCamposPersona(txtNombre.Text, txtApellido.Text))
                {

                    if (Validar.ValidarNombre(txtNombre.Text) && Validar.ValidarApellido(txtApellido.Text))
                    {
                        Profesor profesor = new Profesor(txtNombre.Text, txtApellido.Text);

                        string mensaje = gestion + profesor;
                        GestorSQL.GuardarProfesor(profesor);

                        MessageBox.Show(mensaje, "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
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
            catch (ApellidoInvalidoExcepcion ex)
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

        private void frmAltaProfesor_Load(object sender, EventArgs e)
        {

        }
    }
}
