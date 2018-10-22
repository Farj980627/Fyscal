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
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {

           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.conexiones.ingresos16(Formularios.Control.idCliente,txtEne16.Text, txtFeb16.Text, txtMar16.Text, txtAbr16.Text, txtMay16.Text, txtJun16.Text,
                txtJul16.Text, txtAgo16.Text, txtSep16.Text, txtOct16.Text, txtNov16.Text, txtDic16.Text, txtTot16.Text);
            Clases.conexiones.ingresos0(Formularios.Control.idCliente, txtEne0.Text, txtFeb0.Text, txtMar0.Text, txtAbr0.Text, txtMay0.Text, txtJun0.Text,
                txtJul0.Text, txtAgo0.Text, txtSep0.Text, txtOct0.Text, txtNov0.Text, txtDic0.Text, txtTot0.Text);
            Clases.conexiones.ingresosExcentos(Formularios.Control.idCliente, txtEneExe.Text, txtFebExe.Text, txtMarExe.Text, txtAbrExe.Text, txtMayExe.Text, txtJunExe.Text,
                txtJulExe.Text, txtAgoExe.Text, txtSepExe.Text, txtOctExe.Text, txtNovExe.Text, txtDicExe.Text, txtTotExe.Text);
            Clases.conexiones.ingresosNoObjeto(Formularios.Control.idCliente, txtEneNoo.Text, txtFebNoo.Text, txtMarNoo.Text, txtAbrNoo.Text, txtMayNoo.Text, txtJunNoo.Text,
                txtJulNoo.Text, txtAgoNoo.Text, txtSepNoo.Text, txtOctNoo.Text, txtNovNoo.Text, txtDicNoo.Text, txtTotNoo.Text);
            Clases.conexiones.ingresosMes(Formularios.Control.idCliente, txtEneIMes.Text, txtFebIMes.Text, txtMarIMes.Text, txtAbrIMes.Text, txtMayIMes.Text, txtJunIMes.Text,
               txtJulIMes.Text, txtAgoIMes.Text, txtSepIMes.Text, txtOctIMes.Text, txtNovIMes.Text, txtDicIMes.Text, txtTotIMes.Text);


            MessageBox.Show("Everything will be alright");

        }

        private void txtEneIMes_TextChanged(object sender, EventArgs e)
        {
            txtEneAcu.Text =( Double.Parse(txtEne16.Text) + Double.Parse(txtEne0.Text) + Double.Parse(txtEneNoo.Text) + Double.Parse(txtEneExe.Text) + Double.Parse(txtEneIMes.Text)).ToString(); 
        }
    }
}
