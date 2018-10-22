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
    public partial class Control : Form
    {
       
        public Control()
        {
            InitializeComponent();
           // lblCliente.Text = cliente.ToString();
        }
        public static string idCliente;

        private void button1_Click(object sender, EventArgs e)
        {
            //cargarForm(new Formularios.Deducciones());
        }

        private void Control_Load(object sender, EventArgs e)
        {
            
            lblCliente.Text = Formularios.Inicio.cliente;
            Clases.conexiones.obtenerIdcliente(Formularios.Inicio.cliente);
           
           
            
        }

      
        private void cargarForm(Object cForm)
        {
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            Form opened = cForm as Form;
            opened.TopLevel = false;
            opened.Dock = DockStyle.Fill;
            this.Container.Controls.Add(opened);
            this.Container.Tag = opened;
            opened.Show();

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Datos());
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Deducciones());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Ingresos());
        }
    }
}

