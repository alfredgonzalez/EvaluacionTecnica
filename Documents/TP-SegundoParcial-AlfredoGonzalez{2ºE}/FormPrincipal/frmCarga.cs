using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmCarga : Form
    {
        public delegate void ControlTiempo();
        public frmCarga()
        {
            InitializeComponent();
        }

        private void frmCarga_Load(object sender, EventArgs e)
        {

            lblTiempoDeCarga.Text = "Cargando listas...";
            ControlTiempo toFunction = new ControlTiempo(OnReponse);
            CargaDeBarraAsync(toFunction);
            this.btnAceptar.Enabled = false;
        }
        private void OnReponse()
        {
            this.lblTiempoDeCarga.Text = "Listas cargadas";
            pbCarga.Value = 100;
            this.btnAceptar.Enabled = true;
        }
        private async Task CargaDeBarraAsync(ControlTiempo toFunction)
        {
            for (int i = 0; i < 5; i++) // 5 sec task  
            {
                await Task.Delay(1000); // wait for 1 sec  
            }
            toFunction.Invoke();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
 
            MessageBox.Show("Listas cargadas", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }
    }
}
