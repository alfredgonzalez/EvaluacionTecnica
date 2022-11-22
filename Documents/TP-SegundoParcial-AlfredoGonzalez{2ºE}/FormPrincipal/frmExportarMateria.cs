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
using entidades.GestorArchivos;

namespace Vista
{
    public partial class frmExportarMateria : Form
    {
        public frmExportarMateria()
        {
            InitializeComponent();
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            try 
            {
                if(this.lstMaterias.SelectedIndex != -1) 
                {
                    ArchivoJson<Materia> serializador = new ArchivoJson<Materia>(GestorDeArchivo.ETipoArchivo.JSON);
                    Materia materia = (Materia) lstMaterias.SelectedItem;
                    string mensaje = serializador.Escribir("Materia.Json", materia);
                    MessageBox.Show(mensaje,"Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                }
                else 
                {
                    MessageBox.Show("Error al guardar!", "archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("Error al guardar", "archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmExportarMateria_Load(object sender, EventArgs e)
        {
            lstMaterias.DataSource = null;
            lstMaterias.DataSource = GestorSQL.LeerMateria();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            try 
            {
                if (this.lstMaterias.SelectedIndex != -1)
                {
                    ArchivoCSV<Materia> serializador = new ArchivoCSV<Materia>(GestorDeArchivo.ETipoArchivo.CSV);
                    Materia materia = (Materia)lstMaterias.SelectedItem;
                    string mensaje = serializador.Escribir("Materia.csv", materia);
                    MessageBox.Show(mensaje, "Archivo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar!", "archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al guardar", "archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
