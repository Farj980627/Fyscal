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
    public partial class Inicio : Form
    {
        public static string cliente;
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cliente = cbCliente.Text;
          
            new Formularios.Control().Show();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Formularios.addCliente().Show();
            this.Hide();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = Clases.conexiones.obtenerCliente();
            cbCliente.DisplayMember = "nombre";
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
