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

            //Cargar datos de la tabla IVAAcreditable
            Clases.conexiones.InfoIVAAcreditable();
            txtEneIVAAcr.Text = Formularios.Control.deneivaAcr;
            txtFebIVAAcr.Text = Formularios.Control.dfebivaAcr;
            txtMarIVAAcr.Text = Formularios.Control.dmarivaAcr;
            txtAbrIVAAcr.Text = Formularios.Control.dabrivaAcr;
            txtMayIVAAcr.Text = Formularios.Control.dmayivaAcr;
            txtJunIVAAcr.Text = Formularios.Control.djunivaAcr;
            txtJulIVAAcr.Text = Formularios.Control.djulivaAcr;
            txtAgoIVAAcr.Text = Formularios.Control.dagoivaAcr;
            txtSepIVAAcr.Text = Formularios.Control.dsepivaAcr;
            txtOctIVAAcr.Text = Formularios.Control.doctivaAcr;
            txtNovIVAAcr.Text = Formularios.Control.dnovivaAcr;
            txtDicIVAAcr.Text = Formularios.Control.ddicivaAcr;

            //Cargar datos de la tabla PTU
            Clases.conexiones.InfoPTU();
            txtEnePTU.Text = Formularios.Control.denePtu;
            txtFebPTU.Text = Formularios.Control.dfebPtu;
            txtMarPTU.Text = Formularios.Control.dmarPtu;
            txtAbrPTU.Text = Formularios.Control.dabrPtu;
            txtMayPTU.Text = Formularios.Control.dmayPtu;
            txtJunPTU.Text = Formularios.Control.djunPtu;
            txtJulPTU.Text = Formularios.Control.djulPtu;
            txtAgoPTU.Text = Formularios.Control.dagoPtu;
            txtSepPTU.Text = Formularios.Control.dsepPtu;
            txtOctPTU.Text = Formularios.Control.doctPtu;
            txtNovPTU.Text = Formularios.Control.dnovPtu;
            txtDicPTU.Text = Formularios.Control.ddicPtu;

            //Cargar datos de la tabla Perdidas
            Clases.conexiones.InfoPerdidas();
            txtEnePerdidas.Text = Formularios.Control.denePerdidas;
            txtFebPerdidas.Text = Formularios.Control.dfebPerdidas;
            txtMarPerdidas.Text = Formularios.Control.dmarPerdidas;
            txtAbrPerdidas.Text = Formularios.Control.dabrPerdidas;
            txtMayPerdidas.Text = Formularios.Control.dmayPerdidas;
            txtJunPerdidas.Text = Formularios.Control.djunPerdidas;
            txtJulPerdidas.Text = Formularios.Control.djulPerdidas;
            txtAgoPerdidas.Text = Formularios.Control.dagoPerdidas;
            txtSepPerdidas.Text = Formularios.Control.dsepPerdidas;
            txtOctPerdidas.Text = Formularios.Control.doctPerdidas;
            txtNovPerdidas.Text = Formularios.Control.dnovPerdidas;
            txtDicPerdidas.Text = Formularios.Control.ddicPerdidas;


            //Haciendo los textbox de enero vacios a 0
            if (txtEne16.Text == "")
            {
                txtEne16.Text = "0";
            }
            if (txtEne0.Text == "")
            {
                txtEne0.Text = "0";
            }
            if (txtEneExe.Text == "")
            {
                txtEneExe.Text = "0";
            }
            if (txtEneNoo.Text == "")
            {
                txtEneNoo.Text = "0";
            }
            if (txtEneMes.Text == "")
            {
                txtEneMes.Text = "0";
            }
            if (txtEneEst.Text == "") {
                txtEneEst.Text = "0";
            }
           
            //Haciendo los textbox de febrero vacios a 0
            if (txtFeb16.Text == "")
            {
                txtFeb16.Text = "0";
            }
            if (txtFeb0.Text == "")
            {
                txtFeb0.Text = "0";
            }
            if (txtFebExe.Text == "")
            {
                txtFebExe.Text = "0";
            }
            if (txtFebNoo.Text == "")
            {
                txtFebNoo.Text = "0";
            }
            if (txtFebMes.Text == "")
            {
                txtFebMes.Text = "0";
            }
            if (txtFebEst.Text == "")
            {
                txtFebEst.Text = "0";
            }

            //Haciendo los textbox de marzo vacios a 0
            if (txtMar16.Text == "")
            {
                txtMar16.Text = "0";
            }
            if (txtMar0.Text == "")
            {
                txtMar0.Text = "0";
            }
            if (txtMarExe.Text == "")
            {
                txtMarExe.Text = "0";
            }
            if (txtMarNoo.Text == "")
            {
                txtMarNoo.Text = "0";
            }
            if (txtMarMes.Text == "")
            {
                txtMarMes.Text = "0";
            }
            if (txtMarEst.Text == "")
            {
                txtMarEst.Text = "0";
            }

            //Haciendo los textbox de abril vacios a 0
            if (txtAbr16.Text == "")
            {
                txtAbr16.Text = "0";
            }
            if (txtAbr0.Text == "")
            {
                txtAbr0.Text = "0";
            }
            if (txtAbrExe.Text == "")
            {
                txtAbrExe.Text = "0";
            }
            if (txtAbrNoo.Text == "")
            {
                txtAbrNoo.Text = "0";
            }
            if (txtAbrMes.Text == "")
            {
                txtAbrMes.Text = "0";
            }
            if (txtAbrEst.Text == "")
            {
                txtAbrEst.Text = "0";
            }

            //Haciendo los textbox de mayo vacios a 0
            if (txtMay16.Text == "")
            {
                txtMay16.Text = "0";
            }
            if (txtMay0.Text == "")
            {
                txtMay0.Text = "0";
            }
            if (txtMayExe.Text == "")
            {
                txtMayExe.Text = "0";
            }
            if (txtMayNoo.Text == "")
            {
                txtMayNoo.Text = "0";
            }
            if (txtMayMes.Text == "")
            {
                txtMayMes.Text = "0";
            }
            if (txtMayEst.Text == "")
            {
                txtMayEst.Text = "0";
            }

            //Haciendo los textbox de junio vacios a 0
            if (txtJun16.Text == "")
            {
                txtJun16.Text = "0";
            }
            if (txtJun0.Text == "")
            {
                txtJun0.Text = "0";
            }
            if (txtJunExe.Text == "")
            {
                txtJunExe.Text = "0";
            }
            if (txtJunNoo.Text == "")
            {
                txtJunNoo.Text = "0";
            }
            if (txtJunMes.Text == "")
            {
                txtJunMes.Text = "0";
            }
            if (txtJunEst.Text == "")
            {
                txtJunEst.Text = "0";
            }

            //Haciendo los textbox de julio vacios a 0
            if (txtJul16.Text == "")
            {
                txtJul16.Text = "0";
            }
            if (txtJul0.Text == "")
            {
                txtJul0.Text = "0";
            }
            if (txtJulExe.Text == "")
            {
                txtJulExe.Text = "0";
            }
            if (txtJulNoo.Text == "")
            {
                txtJulNoo.Text = "0";
            }
            if (txtJulMes.Text == "")
            {
                txtJulMes.Text = "0";
            }
            if (txtJulEst.Text == "")
            {
                txtJulEst.Text = "0";
            }

            //Haciendo los textbox de agosto vacios a 0
            if (txtAgo16.Text == "")
            {
                txtAgo16.Text = "0";
            }
            if (txtAgo0.Text == "")
            {
                txtAgo0.Text = "0";
            }
            if (txtAgoExe.Text == "")
            {
                txtAgoExe.Text = "0";
            }
            if (txtAgoNoo.Text == "")
            {
                txtAgoNoo.Text = "0";
            }
            if (txtAgoMes.Text == "")
            {
                txtAgoMes.Text = "0";
            }
            if (txtAgoEst.Text == "")
            {
                txtAgoEst.Text = "0";
            }

            //Haciendo los textbox de septiembre vacios a 0
            if (txtSep16.Text == "")
            {
                txtSep16.Text = "0";
            }
            if (txtSep0.Text == "")
            {
                txtSep0.Text = "0";
            }
            if (txtSepExe.Text == "")
            {
                txtSepExe.Text = "0";
            }
            if (txtSepNoo.Text == "")
            {
                txtSepNoo.Text = "0";
            }
            if (txtSepMes.Text == "")
            {
                txtSepMes.Text = "0";
            }
            if (txtSepEst.Text == "")
            {
                txtSepEst.Text = "0";
            }

            //Haciendo los textbox de octubre vacios a 0
            if (txtOct16.Text == "")
            {
                txtOct16.Text = "0";
            }
            if (txtOct0.Text == "")
            {
                txtOct0.Text = "0";
            }
            if (txtOctExe.Text == "")
            {
                txtOctExe.Text = "0";
            }
            if (txtOctNoo.Text == "")
            {
                txtOctNoo.Text = "0";
            }
            if (txtOctMes.Text == "")
            {
                txtOctMes.Text = "0";
            }
            if (txtOctEst.Text == "")
            {
                txtOctEst.Text = "0";
            }

            //Haciendo los textbox de noviembre vacios a 0
            if (txtNov16.Text == "")
            {
                txtNov16.Text = "0";
            }
            if (txtNov0.Text == "")
            {
                txtNov0.Text = "0";
            }
            if (txtNovExe.Text == "")
            {
                txtNovExe.Text = "0";
            }
            if (txtNovNoo.Text == "")
            {
                txtNovNoo.Text = "0";
            }
            if (txtNovMes.Text == "")
            {
                txtNovMes.Text = "0";
            }
            if (txtNovEst.Text == "")
            {
                txtNovEst.Text = "0";
            }

            //Haciendo los textbox de enero vacios a 0
            if (txtDic16.Text == "")
            {
                txtDic16.Text = "0";
            }
            if (txtDic0.Text == "")
            {
                txtDic0.Text = "0";
            }
            if (txtDicExe.Text == "")
            {
                txtDicExe.Text = "0";
            }
            if (txtDicNoo.Text == "")
            {
                txtDicNoo.Text = "0";
            }
            if (txtDicMes.Text == "")
            {
                txtDicMes.Text = "0";
            }
            if (txtDicEst.Text == "")
            {
                txtDicEst.Text = "0";
            }


            //Calculando total de cada mes --ENERO
            double totEne = double.Parse(txtEne16.Text) + double.Parse(txtEne0.Text) + double.Parse(txtEneExe.Text) + double.Parse(txtEneNoo.Text) + double.Parse(txtEneEst.Text);
            txtEneMes.Text = totEne.ToString();

            //Calculando total de cada mes --FEBRERO
            double totFeb = double.Parse(txtFeb16.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtFebNoo.Text) + double.Parse(txtFebEst.Text);
            txtFebMes.Text = totFeb.ToString();

            //Calculando total de cada mes --MARZO
            double totMar = double.Parse(txtMar16.Text) + double.Parse(txtMar0.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtMarNoo.Text) + double.Parse(txtMarEst.Text);
            txtMarMes.Text = totMar.ToString();

            //Calculando total de cada mes --ABRIL
            double totAbr = double.Parse(txtAbr16.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtAbrNoo.Text) + double.Parse(txtAbrEst.Text);
            txtAbrMes.Text = totAbr.ToString();

            //Calculando total de cada mes --MAYO
            double totMay = double.Parse(txtMay16.Text) + double.Parse(txtMay0.Text) + double.Parse(txtMayExe.Text) + double.Parse(txtMayNoo.Text) + double.Parse(txtMayEst.Text);
            txtMayMes.Text = totMay.ToString();

            //Calculando total de cada mes --JUNIO
            double totJun = double.Parse(txtJun16.Text) + double.Parse(txtJun0.Text) + double.Parse(txtJunExe.Text) + double.Parse(txtJunNoo.Text) + double.Parse(txtJunEst.Text);
            txtJunMes.Text = totJun.ToString();

            //Calculando total de cada mes --JULIO
            double totJul = double.Parse(txtJul16.Text) + double.Parse(txtJul0.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtJulNoo.Text) + double.Parse(txtJulEst.Text);
            txtJulMes.Text = totJul.ToString();

            //Calculando total de cada mes --AGOSTO
            double totAgo = double.Parse(txtAgo16.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtAgoNoo.Text) + double.Parse(txtAgoEst.Text);
            txtAgoMes.Text = totAgo.ToString();

            //Calculando total de cada mes --SEPTIEMBRE
            double totSep = double.Parse(txtSep16.Text) + double.Parse(txtSep0.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtSepNoo.Text) + double.Parse(txtSepEst.Text);
            txtSepMes.Text = totSep.ToString();

            //Calculando total de cada mes --OCTUBRE
            double totOct = double.Parse(txtOct16.Text) + double.Parse(txtOct0.Text) + double.Parse(txtOctExe.Text) + double.Parse(txtOctNoo.Text) + double.Parse(txtOctEst.Text);
            txtOctMes.Text = totOct.ToString();

            //Calculando total de cada mes --NOVIEMBRE
            double totNov = double.Parse(txtNov16.Text) + double.Parse(txtNov0.Text) + double.Parse(txtNovExe.Text) + double.Parse(txtNovNoo.Text) + double.Parse(txtNovEst.Text);
            txtNovMes.Text = totNov.ToString();

            //Calculando total de cada mes --DICIEMEBRE
            double totDic = double.Parse(txtDic16.Text) + double.Parse(txtDic0.Text) + double.Parse(txtDicExe.Text) + double.Parse(txtDicNoo.Text) + double.Parse(txtDicEst.Text);
            txtDicMes.Text = totDic.ToString();

            //Calculando total de cada deduccion --16%
            double totI16 = double.Parse(txtEne16.Text) + double.Parse(txtFeb16.Text) + double.Parse(txtMar16.Text) + double.Parse(txtAbr16.Text) + double.Parse(txtMay16.Text) +
                +double.Parse(txtJun16.Text) + double.Parse(txtJul16.Text) + double.Parse(txtAgo16.Text) + double.Parse(txtSep16.Text) + double.Parse(txtOct16.Text) +
                double.Parse(txtNov16.Text) + double.Parse(txtDic16.Text);
            txtTot16.Text = totI16.ToString();

            //Calculando total de cada deduccion --0%
            double totI0 = double.Parse(txtEne0.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtMar0.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtMay0.Text) +
                +double.Parse(txtJun0.Text) + double.Parse(txtJul0.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtSep0.Text) + double.Parse(txtOct0.Text) +
                double.Parse(txtNov0.Text) + double.Parse(txtDic0.Text);
            txtTot0.Text = totI0.ToString();

            //Calculando total de cada deduccion --Exentos
            double totIExe = double.Parse(txtEneExe.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtMayExe.Text) +
                +double.Parse(txtJunExe.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtOctExe.Text) +
                double.Parse(txtNovExe.Text) + double.Parse(txtDicExe.Text);
            txtTotExe.Text = totIExe.ToString();

            //Calculando total de cada deduccion --No Objeto
            double totINoo = double.Parse(txtEneNoo.Text) + double.Parse(txtFebNoo.Text) + double.Parse(txtMarNoo.Text) + double.Parse(txtAbrNoo.Text) + double.Parse(txtMayNoo.Text) +
                +double.Parse(txtJunNoo.Text) + double.Parse(txtJulNoo.Text) + double.Parse(txtAgoNoo.Text) + double.Parse(txtSepNoo.Text) + double.Parse(txtOctNoo.Text) +
                double.Parse(txtNovNoo.Text) + double.Parse(txtDicNoo.Text);
            txtTotNoo.Text = totINoo.ToString();

            //Calculando total de cada deduccion --Mes
            double totIMes = double.Parse(txtEneMes.Text) + double.Parse(txtFebMes.Text) + double.Parse(txtMarMes.Text) + double.Parse(txtAbrMes.Text) + double.Parse(txtMayMes.Text) +
                +double.Parse(txtJunMes.Text) + double.Parse(txtJulMes.Text) + double.Parse(txtAgoMes.Text) + double.Parse(txtSepMes.Text) + double.Parse(txtOctMes.Text) +
                double.Parse(txtNovMes.Text) + double.Parse(txtDicMes.Text);
            txtTotMes.Text = totIMes.ToString();

            //Calculando total de cada deduccion --Estimulo
            double totIEst = double.Parse(txtEneEst.Text) + double.Parse(txtFebEst.Text) + double.Parse(txtMarEst.Text) + double.Parse(txtAbrEst.Text) + double.Parse(txtMayEst.Text) +
                +double.Parse(txtJunEst.Text) + double.Parse(txtJulEst.Text) + double.Parse(txtAgoEst.Text) + double.Parse(txtSepEst.Text) + double.Parse(txtOctEst.Text) +
                double.Parse(txtNovEst.Text) + double.Parse(txtDicEst.Text);
            txtTotEst.Text = totIEst.ToString();

            //Calculando total de cada deduccion --IVA Acreditable
            txtTotIVAAcr.Text = (double.Parse(txtEneIVAAcr.Text) + double.Parse(txtFebIVAAcr.Text) + double.Parse(txtMarIVAAcr.Text) + double.Parse(txtAbrIVAAcr.Text) + double.Parse(txtMayIVAAcr.Text) +
                +double.Parse(txtJunIVAAcr.Text) + double.Parse(txtJulIVAAcr.Text) + double.Parse(txtAgoIVAAcr.Text) + double.Parse(txtSepIVAAcr.Text) + double.Parse(txtOctIVAAcr.Text) +
                double.Parse(txtNovIVAAcr.Text) + double.Parse(txtDicIVAAcr.Text)).ToString();

            //Calculando total de cada deduccion --PTU
            txtTotPTU.Text = (double.Parse(txtEnePTU.Text) + double.Parse(txtFebPTU.Text) + double.Parse(txtMarPTU.Text) + double.Parse(txtAbrPTU.Text) + double.Parse(txtMayPTU.Text) +
                +double.Parse(txtJunPTU.Text) + double.Parse(txtJulPTU.Text) + double.Parse(txtAgoPTU.Text) + double.Parse(txtSepPTU.Text) + double.Parse(txtOctPTU.Text) +
                double.Parse(txtNovPTU.Text) + double.Parse(txtDicPTU.Text)).ToString();

            //Calculando total de cada deduccion --Péerdidas
            txtTotPerdidas.Text = (double.Parse(txtEnePerdidas.Text) + double.Parse(txtFebPerdidas.Text) + double.Parse(txtMarPerdidas.Text) + double.Parse(txtAbrPerdidas.Text) + double.Parse(txtMayPerdidas.Text) +
                +double.Parse(txtJunPerdidas.Text) + double.Parse(txtJulPerdidas.Text) + double.Parse(txtAgoPerdidas.Text) + double.Parse(txtSepPerdidas.Text) + double.Parse(txtOctPerdidas.Text) +
                double.Parse(txtNovPerdidas.Text) + double.Parse(txtDicPerdidas.Text)).ToString();


            //Calcular lo acumulado
            double acumulado;
            acumulado = double.Parse(txtEneMes.Text);
            txtEneAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
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

            Clases.conexiones.dedTotalesMes(Formularios.Control.idCliente, txtEneMes.Text, txtFebMes.Text, txtMarMes.Text, txtAbrMes.Text, txtMayMes.Text, txtJunMes.Text, txtJulMes.Text,
               txtAgoMes.Text, txtSepMes.Text, txtOctMes.Text, txtNovMes.Text, txtDicMes.Text);

            Clases.conexiones.dedAcumuladas(Formularios.Control.idCliente, txtEneAcu.Text, txtFebAcu.Text, txtMarAcu.Text, txtAbrAcu.Text, txtMayAcu.Text, txtJunAcu.Text, txtJulAcu.Text,
               txtAgoAcu.Text, txtSepAcu.Text, txtOctAcu.Text, txtNovAcu.Text, txtDicAcu.Text);

            Clases.conexiones.ivaAcreditable(Formularios.Control.idCliente, txtEneIVAAcr.Text, txtFebIVAAcr.Text, txtMarIVAAcr.Text, txtAbrIVAAcr.Text, txtMayIVAAcr.Text, txtJunIVAAcr.Text, txtJulIVAAcr.Text,
               txtAgoIVAAcr.Text, txtSepIVAAcr.Text, txtOctIVAAcr.Text, txtNovIVAAcr.Text, txtDicIVAAcr.Text, txtTotIVAAcr.Text);

            Clases.conexiones.Ptu(Formularios.Control.idCliente, txtEnePTU.Text, txtFebPTU.Text, txtMarPTU.Text, txtAbrPTU.Text, txtMayPTU.Text, txtJunPTU.Text, txtJulPTU.Text,
               txtAgoPTU.Text, txtSepPTU.Text, txtOctPTU.Text, txtNovPTU.Text, txtDicPTU.Text, txtTotPTU.Text);

            Clases.conexiones.Perdidas(Formularios.Control.idCliente, txtEnePerdidas.Text, txtFebPerdidas.Text, txtMarPerdidas.Text, txtAbrPerdidas.Text, txtMayPerdidas.Text, txtJunPerdidas.Text, txtJulPerdidas.Text,
               txtAgoPerdidas.Text, txtSepPerdidas.Text, txtOctPerdidas.Text, txtNovPerdidas.Text, txtDicPerdidas.Text, txtTotPerdidas.Text);

            this.Hide();
        }

        private void txtEne16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --ENERO TIEMPO REAL
            double totEne = double.Parse(txtEne16.Text) + double.Parse(txtEne0.Text) + double.Parse(txtEneExe.Text) + double.Parse(txtEneNoo.Text) + double.Parse(txtEneEst.Text);
            txtEneMes.Text = totEne.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtEneMes.Text);
            txtEneAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtFeb16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --FEBRERO TIEMPO REAL
            double totFeb = double.Parse(txtFeb16.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtFebNoo.Text) + double.Parse(txtFebEst.Text);
            txtFebMes.Text = totFeb.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtMar16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --MARZO TIEMPO REAL
            double totMar = double.Parse(txtMar16.Text) + double.Parse(txtMar0.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtMarNoo.Text) + double.Parse(txtMarEst.Text);
            txtMarMes.Text = totMar.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtAbr16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --ABRIL TIEMPO REAL
            double totAbr = double.Parse(txtAbr16.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtAbrNoo.Text) + double.Parse(txtAbrEst.Text);
            txtAbrMes.Text = totAbr.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
          
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtMay16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --MAYO TIEMPO REAL
            double totMay = double.Parse(txtMay16.Text) + double.Parse(txtMay0.Text) + double.Parse(txtMayExe.Text) + double.Parse(txtMayNoo.Text) + double.Parse(txtMayEst.Text);
            txtMayMes.Text = totMay.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtJun16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --JUNIO TIEMPO REAL
            double totJun = double.Parse(txtJun16.Text) + double.Parse(txtJun0.Text) + double.Parse(txtJunExe.Text) + double.Parse(txtJunNoo.Text) + double.Parse(txtJunEst.Text);
            txtJunMes.Text = totJun.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            
          
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtJul16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --JULIO TIEMPO REAL
            double totJul = double.Parse(txtJul16.Text) + double.Parse(txtJul0.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtJulNoo.Text) + double.Parse(txtJulEst.Text);
            txtJulMes.Text = totJul.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtAgo16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --AGOSTO TIEMPO REAL
            double totAgo = double.Parse(txtAgo16.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtAgoNoo.Text) + double.Parse(txtAgoEst.Text);
            txtAgoMes.Text = totAgo.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
           
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtSep16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --SEPTIEMBRE TIEMPO REAL
            double totSep = double.Parse(txtSep16.Text) + double.Parse(txtSep0.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtSepNoo.Text) + double.Parse(txtSepEst.Text);
            txtSepMes.Text = totSep.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
          
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtOct16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --OCTUBRE TIEMPO REAL
            double totOct = double.Parse(txtOct16.Text) + double.Parse(txtOct0.Text) + double.Parse(txtOctExe.Text) + double.Parse(txtOctNoo.Text) + double.Parse(txtOctEst.Text);
            txtOctMes.Text = totOct.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
       
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtNov16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --NOVIEMBRE TIEMPO REAL
            double totNov = double.Parse(txtNov16.Text) + double.Parse(txtNov0.Text) + double.Parse(txtNovExe.Text) + double.Parse(txtNovNoo.Text) + double.Parse(txtNovEst.Text);
            txtNovMes.Text = totNov.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
          
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtDic16_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --DICIEMBRE TIEMPO REAL
            double totDic = double.Parse(txtDic16.Text) + double.Parse(txtDic0.Text) + double.Parse(txtDicExe.Text) + double.Parse(txtDicNoo.Text) + double.Parse(txtDicEst.Text);
            txtDicMes.Text = totDic.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
          
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtDic16_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada ingreso --16% TIEMPO REAL
            double totI16 = double.Parse(txtEne16.Text) + double.Parse(txtFeb16.Text) + double.Parse(txtMar16.Text) + double.Parse(txtAbr16.Text) + double.Parse(txtMay16.Text) +
                +double.Parse(txtJun16.Text) + double.Parse(txtJul16.Text) + double.Parse(txtAgo16.Text) + double.Parse(txtSep16.Text) + double.Parse(txtOct16.Text) +
                double.Parse(txtNov16.Text) + double.Parse(txtDic16.Text);
            txtTot16.Text = totI16.ToString();
        }

        private void txtDic0_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada ingreso --0% TIEMPO REAL
            double totI0 = double.Parse(txtEne0.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtMar0.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtMay0.Text) +
                +double.Parse(txtJun0.Text) + double.Parse(txtJul0.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtSep0.Text) + double.Parse(txtOct0.Text) +
                double.Parse(txtNov0.Text) + double.Parse(txtDic0.Text);
            txtTot0.Text = totI0.ToString();
        }

        private void txtDicExe_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada ingreso --Exentos TIEMPO REAL
            double totIExe = double.Parse(txtEneExe.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtMayExe.Text) +
            +double.Parse(txtJunExe.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtOctExe.Text) +
            double.Parse(txtNovExe.Text) + double.Parse(txtDicExe.Text);
            txtTotExe.Text = totIExe.ToString();
        }

        private void txtDicNoo_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada ingreso --No Objeto TIEMPO REAL
            double totINoo = double.Parse(txtEneNoo.Text) + double.Parse(txtFebNoo.Text) + double.Parse(txtMarNoo.Text) + double.Parse(txtAbrNoo.Text) + double.Parse(txtMayNoo.Text) +
            +double.Parse(txtJunNoo.Text) + double.Parse(txtJulNoo.Text) + double.Parse(txtAgoNoo.Text) + double.Parse(txtSepNoo.Text) + double.Parse(txtOctNoo.Text) +
            double.Parse(txtNovNoo.Text) + double.Parse(txtDicNoo.Text);
            txtTotNoo.Text = totINoo.ToString();
        }

        private void txtDicMes_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada deduccion --Mes
            double totIMes = double.Parse(txtEneMes.Text) + double.Parse(txtFebMes.Text) + double.Parse(txtMarMes.Text) + double.Parse(txtAbrMes.Text) + double.Parse(txtMayMes.Text) +
            +double.Parse(txtJunMes.Text) + double.Parse(txtJulMes.Text) + double.Parse(txtAgoMes.Text) + double.Parse(txtSepMes.Text) + double.Parse(txtOctMes.Text) +
            double.Parse(txtNovMes.Text) + double.Parse(txtDicMes.Text);
            txtTotMes.Text = totIMes.ToString();
        }

        private void txtEneIVAAcr_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada deduccion--- IVA Acreditable Manual
            txtTotIVAAcr.Text = (double.Parse(txtEneIVAAcr.Text) + double.Parse(txtFebIVAAcr.Text) + double.Parse(txtMarIVAAcr.Text) + double.Parse(txtAbrIVAAcr.Text) + double.Parse(txtMayIVAAcr.Text) +
            +double.Parse(txtJunIVAAcr.Text) + double.Parse(txtJulIVAAcr.Text) + double.Parse(txtAgoIVAAcr.Text) + double.Parse(txtSepIVAAcr.Text) + double.Parse(txtOctIVAAcr.Text) +
            double.Parse(txtNovIVAAcr.Text) + double.Parse(txtDicIVAAcr.Text)).ToString();
        }

        private void txtEnePTU_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada deduccion--- PTU
            txtTotPTU.Text = (double.Parse(txtEnePTU.Text) + double.Parse(txtFebPTU.Text) + double.Parse(txtMarPTU.Text) + double.Parse(txtAbrPTU.Text) + double.Parse(txtMayPTU.Text) +
            +double.Parse(txtJunPTU.Text) + double.Parse(txtJulPTU.Text) + double.Parse(txtAgoPTU.Text) + double.Parse(txtSepPTU.Text) + double.Parse(txtOctPTU.Text) +
            double.Parse(txtNovPTU.Text) + double.Parse(txtDicPTU.Text)).ToString();
        }

        private void txtEnePerdidas_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada deduccion--- Perdidas
            txtTotPerdidas.Text = (double.Parse(txtEnePerdidas.Text) + double.Parse(txtFebPerdidas.Text) + double.Parse(txtMarPerdidas.Text) + double.Parse(txtAbrPerdidas.Text) + double.Parse(txtMayPerdidas.Text) +
            +double.Parse(txtJunPerdidas.Text) + double.Parse(txtJulPerdidas.Text) + double.Parse(txtAgoPerdidas.Text) + double.Parse(txtSepPerdidas.Text) + double.Parse(txtOctPerdidas.Text) +
            double.Parse(txtNovPerdidas.Text) + double.Parse(txtDicPerdidas.Text)).ToString();
        }
    }
}
