using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FysCal_2._0
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button1;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario...") {
                txtUsuario.Text = "";
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario...";
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            
                if (txtContrasenia.Text == "Contraseña...")
                {
                    txtContrasenia.Text = "";
                    txtContrasenia.UseSystemPasswordChar = Enabled;
                }
            

        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "Contraseña...";
                txtContrasenia.UseSystemPasswordChar = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Formularios.addCliente().Show();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Clases.conexiones.login(txtUsuario.Text, txtContrasenia.Text);
            this.Hide();
            

        }
    }
}
