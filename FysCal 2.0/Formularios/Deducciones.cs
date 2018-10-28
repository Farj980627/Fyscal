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
    public partial class Deducciones : Form
    {
        public Deducciones()
        {
            InitializeComponent();
        }

        private void Deducciones_Load(object sender, EventArgs e)
        {

            //Cargar datos de la tabla deducicones16
            Clases.conexiones.InfoDeducciones16();
            txtEne16.Text = Formularios.Control.dene16;
            txtFeb16.Text = Formularios.Control.dfeb16;
            txtMar16.Text = Formularios.Control.dmar16;
            txtAbr16.Text = Formularios.Control.dabr16;
            txtMay16.Text = Formularios.Control.dmay16;
            txtJun16.Text = Formularios.Control.djun16;
            txtJul16.Text = Formularios.Control.djul16;
            txtAgo16.Text = Formularios.Control.dago16;
            txtSep16.Text = Formularios.Control.dsep16;
            txtOct16.Text = Formularios.Control.doct16;
            txtNov16.Text = Formularios.Control.dnov16;
            txtDic16.Text = Formularios.Control.ddic16;
            txtTot16.Text = Formularios.Control.dtot16;
            //Cargar datos de la tabla deducicones0
            Clases.conexiones.InfoDeducciones0();
            txtEne0.Text = Formularios.Control.dene0;
            txtFeb0.Text = Formularios.Control.dfeb0;
            txtMar0.Text = Formularios.Control.dmar0;
            txtAbr0.Text = Formularios.Control.dabr0;
            txtMay0.Text = Formularios.Control.dmay0;
            txtJun0.Text = Formularios.Control.djun0;
            txtJul0.Text = Formularios.Control.djul0;
            txtAgo0.Text = Formularios.Control.dago0;
            txtSep0.Text = Formularios.Control.dsep0;
            txtOct0.Text = Formularios.Control.doct0;
            txtNov0.Text = Formularios.Control.dnov0;
            txtDic0.Text = Formularios.Control.ddic0;
            txtTot0.Text = Formularios.Control.dtot0;
            //Cargar datos de la tabla deduciconesExentas
            Clases.conexiones.InfoDeduccionesExe();
            txtEneExe.Text = Formularios.Control.deneexe;
            txtFebExe.Text = Formularios.Control.dfebexe;
            txtMarExe.Text = Formularios.Control.dmarexe;
            txtAbrExe.Text = Formularios.Control.dabrexe;
            txtMayExe.Text = Formularios.Control.dmayexe;
            txtJunExe.Text = Formularios.Control.djunexe;
            txtJulExe.Text = Formularios.Control.djulexe;
            txtAgoExe.Text = Formularios.Control.dagoexe;
            txtSepExe.Text = Formularios.Control.dsepexe;
            txtOctExe.Text = Formularios.Control.doctexe;
            txtNovExe.Text = Formularios.Control.dnovexe;
            txtDicExe.Text = Formularios.Control.ddicexe;
            txtTotExe.Text = Formularios.Control.dtotexe;
            //Cargar datos de la tabla deduciconesNoObjeto
            Clases.conexiones.InfoDeduccionesNoObjeto();
            txtEneNoo.Text = Formularios.Control.deneNoo;
            txtFebNoo.Text = Formularios.Control.dfebNoo;
            txtMarNoo.Text = Formularios.Control.dmarNoo;
            txtAbrNoo.Text = Formularios.Control.dabrNoo;
            txtMayNoo.Text = Formularios.Control.dmayNoo;
            txtJunNoo.Text = Formularios.Control.djunNoo;
            txtJulNoo.Text = Formularios.Control.djulNoo;
            txtAgoNoo.Text = Formularios.Control.dagoNoo;
            txtSepNoo.Text = Formularios.Control.dsepNoo;
            txtOctNoo.Text = Formularios.Control.doctNoo;
            txtNovNoo.Text = Formularios.Control.dnovNoo;
            txtDicNoo.Text = Formularios.Control.ddicNoo;
            txtTotNoo.Text = Formularios.Control.dtotNoo;
            //Cargar datos de la tabla estimuloFiscal
            Clases.conexiones.InfoEstimuloFiscal();
            txtEneEst.Text = Formularios.Control.deneest;
            txtFebEst.Text = Formularios.Control.dfebest;
            txtMarEst.Text = Formularios.Control.dmarest;
            txtAbrEst.Text = Formularios.Control.dabrest;
            txtMayEst.Text = Formularios.Control.dmayest;
            txtJunEst.Text = Formularios.Control.djunest;
            txtJulEst.Text = Formularios.Control.djulest;
            txtAgoEst.Text = Formularios.Control.dagoest;
            txtSepEst.Text = Formularios.Control.dsepest;
            txtOctEst.Text = Formularios.Control.doctest;
            txtNovEst.Text = Formularios.Control.dnovest;
            txtDicEst.Text = Formularios.Control.ddicest;
            txtTotEst.Text = Formularios.Control.dtotest;
            //Cargar datos de la tabla deduciconesMes
            Clases.conexiones.InfoDeduccionesMes();
            txtEneMes.Text = Formularios.Control.denemes;
            txtFebMes.Text = Formularios.Control.dfebmes;
            txtMarMes.Text = Formularios.Control.dmarmes;
            txtAbrMes.Text = Formularios.Control.dabrmes;
            txtMayMes.Text = Formularios.Control.dmaymes;
            txtJunMes.Text = Formularios.Control.djunmes;
            txtJulMes.Text = Formularios.Control.djulmes;
            txtAgoMes.Text = Formularios.Control.dagomes;
            txtSepMes.Text = Formularios.Control.dsepmes;
            txtOctMes.Text = Formularios.Control.doctmes;
            txtNovMes.Text = Formularios.Control.dnovmes;
            txtDicMes.Text = Formularios.Control.ddicmes;
            txtTotMes.Text = Formularios.Control.dtotmes;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Envio de datos para insercion o actualizacion de los datos de las tablas
            Clases.conexiones.deducciones16(Formularios.Control.idCliente, txtEne16.Text, txtFeb16.Text, txtMar16.Text, txtAbr16.Text, txtMay16.Text, txtJun16.Text,
                txtJul16.Text, txtAgo16.Text, txtSep16.Text, txtOct16.Text, txtNov16.Text, txtDic16.Text, txtTot16.Text);

            Clases.conexiones.deducciones0(Formularios.Control.idCliente, txtEne0.Text, txtFeb0.Text, txtMar0.Text, txtAbr0.Text, txtMay0.Text, txtJun0.Text,
                txtJul0.Text, txtAgo0.Text, txtSep0.Text, txtOct0.Text, txtNov0.Text, txtDic0.Text, txtTot0.Text);

            Clases.conexiones.deduccionesExentas(Formularios.Control.idCliente, txtEneExe.Text, txtFebExe.Text, txtMarExe.Text, txtAbrExe.Text, txtMayExe.Text, txtJunExe.Text,
                txtJulExe.Text, txtAgoExe.Text, txtSepExe.Text, txtOctExe.Text, txtNovExe.Text, txtDicExe.Text, txtTotExe.Text);

            Clases.conexiones.deduccionesNoObjeto(Formularios.Control.idCliente, txtEneNoo.Text, txtFebNoo.Text, txtMarNoo.Text, txtAbrNoo.Text, txtMayNoo.Text, txtJunNoo.Text,
                txtJulNoo.Text, txtAgoNoo.Text, txtSepNoo.Text, txtOctNoo.Text, txtNovNoo.Text, txtDicNoo.Text, txtTotNoo.Text);

            Clases.conexiones.deduccionesMes(Formularios.Control.idCliente, txtEneMes.Text, txtFebMes.Text, txtMarMes.Text, txtAbrMes.Text, txtMayMes.Text, txtJunMes.Text,
               txtJulMes.Text, txtAgoMes.Text, txtSepMes.Text, txtOctMes.Text, txtNovMes.Text, txtDicMes.Text, txtTotMes.Text);

            Clases.conexiones.estimuloFiscal(Formularios.Control.idCliente, txtEneEst.Text, txtFebEst.Text, txtMarEst.Text, txtAbrEst.Text, txtMayEst.Text, txtJunEst.Text,
        txtJulEst.Text, txtAgoEst.Text, txtSepEst.Text, txtOctEst.Text, txtNovEst.Text, txtDicEst.Text, txtTotEst.Text);




            MessageBox.Show("Everything will be alright");
        }
    }
}
