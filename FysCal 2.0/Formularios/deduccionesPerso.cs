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
    public partial class deduccionesPerso : Form
    {
        public deduccionesPerso()
        {
            InitializeComponent();
        }
 
        private void deduccionesPerso_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.ToString();
            lblRFC.Text = Clases.conexiones.RFC();
            dataGridView1.DataSource = Clases.conexiones.getDedPersonales();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Clases.conexiones.dedPersonal(Control.idCliente, lblRFC.Text, DateTime.Today, cbMes.Text, txtMonto.Text );
            txtMonto.Clear();           
                dataGridView1.DataSource = Clases.conexiones.getDedPersonales();
            
        }
    }
}
