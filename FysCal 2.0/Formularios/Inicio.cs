﻿using System;
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
            this.Hide();

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Formularios.addCliente().ShowDialog();
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            cbCliente.DataSource = Clases.conexiones.obtenerCliente();
            cbCliente.DisplayMember = "nombre";
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Formularios.Tablas_yTarifas().ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Formularios.Inpc().ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Formularios.Recargos().ShowDialog();
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}
