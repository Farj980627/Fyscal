using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FysCal_2._0.Formularios
{
    public partial class addCliente : Form
    {
        public addCliente()
        {
            InitializeComponent();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            Clases.conexiones.addCliente(txtNombre.Text, txtCurp.Text, txtRfc.Text, txtDomicilioFiscal.Text, cbRegimen.Text);
            Clases.conexiones.pagoProvisional(Clases.conexiones.max_id(), "0","0","0","0","0","0","0","0","0","0","0","0");
            Clases.conexiones.ISR106Dif(Clases.conexiones.max_id(), "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0");

            
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }
}
