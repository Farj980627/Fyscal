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
    public partial class Datos : Form
    {
        
        public Datos()
        {
            InitializeComponent();
        }
        public static string curpDatos, rfcDatos, domFiscalDatos, regFiscalDatos;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Datos_Load(object sender, EventArgs e)
        {
            Clases.conexiones.InfoCliete(Formularios.Inicio.cliente);
            txtUsuario.Text = Formularios.Inicio.cliente.ToString();
            txtCurp.Text = curpDatos;
            txtRfc.Text = rfcDatos;
            txtDomFis.Text = domFiscalDatos;
            txtRegFis.Text = regFiscalDatos;
          
            
            
        }
    }
}
