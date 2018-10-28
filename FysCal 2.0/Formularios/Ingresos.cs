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
            //Cargar datos de la tabla ingresos16
            Clases.conexiones.InfoIngresos16();
            txtEne16.Text = Formularios.Control.ene16;
            txtFeb16.Text = Formularios.Control.feb16;
            txtMar16.Text = Formularios.Control.mar16;
            txtAbr16.Text = Formularios.Control.abr16;
            txtMay16.Text = Formularios.Control.may16;
            txtJun16.Text = Formularios.Control.jun16;
            txtJul16.Text = Formularios.Control.jul16;
            txtAgo16.Text = Formularios.Control.ago16;
            txtSep16.Text = Formularios.Control.sep16;
            txtOct16.Text = Formularios.Control.oct16;
            txtNov16.Text = Formularios.Control.nov16;
            txtDic16.Text = Formularios.Control.dic16;
          
            //Cargar datos de la tabla ingresos0
            Clases.conexiones.InfoIngresos0();
            txtEne0.Text = Formularios.Control.ene0;
            txtFeb0.Text = Formularios.Control.feb0;
            txtMar0.Text = Formularios.Control.mar0;
            txtAbr0.Text = Formularios.Control.abr0;
            txtMay0.Text = Formularios.Control.may0;
            txtJun0.Text = Formularios.Control.jun0;
            txtJul0.Text = Formularios.Control.jul0;
            txtAgo0.Text = Formularios.Control.ago0;
            txtSep0.Text = Formularios.Control.sep0;
            txtOct0.Text = Formularios.Control.oct0;
            txtNov0.Text = Formularios.Control.nov0;
            txtDic0.Text = Formularios.Control.dic0;
        
            //Cargar datos de la tabla ingresosExentos
            Clases.conexiones.InfoIngresosExcentos();
            txtEneExe.Text = Formularios.Control.eneExe;
            txtFebExe.Text = Formularios.Control.febExe;
            txtMarExe.Text = Formularios.Control.marExe;
            txtAbrExe.Text = Formularios.Control.abrExe;
            txtMayExe.Text = Formularios.Control.mayExe;
            txtJunExe.Text = Formularios.Control.junExe;
            txtJulExe.Text = Formularios.Control.julExe;
            txtAgoExe.Text = Formularios.Control.agoExe;
            txtSepExe.Text = Formularios.Control.sepExe;
            txtOctExe.Text = Formularios.Control.octExe;
            txtNovExe.Text = Formularios.Control.novExe;
            txtDicExe.Text = Formularios.Control.dicExe;
          
            //Cargar datos de la tabla ingresosNoObjeto
            Clases.conexiones.InfoIngresosNoObjeto();
            txtEneNoo.Text = Formularios.Control.eneNoo;
            txtFebNoo.Text = Formularios.Control.febNoo;
            txtMarNoo.Text = Formularios.Control.marNoo;
            txtAbrNoo.Text = Formularios.Control.abrNoo;
            txtMayNoo.Text = Formularios.Control.mayNoo;
            txtJunNoo.Text = Formularios.Control.junNoo;
            txtJulNoo.Text = Formularios.Control.julNoo;
            txtAgoNoo.Text = Formularios.Control.agoNoo;
            txtSepNoo.Text = Formularios.Control.sepNoo;
            txtOctNoo.Text = Formularios.Control.octNoo;
            txtNovNoo.Text = Formularios.Control.novNoo;
            txtDicNoo.Text = Formularios.Control.dicNoo;
     
            /*/Cargar datos de la tabla ingresosMes
            Clases.conexiones.InfoIngresosMes();
            txtEneIMes.Text = Formularios.Control.eneMes;
            txtJunIMes.Text = Formularios.Control.febMes;
            txtMayIMes.Text = Formularios.Control.marMes;
            txtAbrIMes.Text = Formularios.Control.abrMes;
            txtMayIMes.Text = Formularios.Control.mayMes;
            txtJunIMes.Text = Formularios.Control.junMes;
            txtJulIMes.Text = Formularios.Control.julMes;
            txtAgoIMes.Text = Formularios.Control.agoMes;
            txtSepIMes.Text = Formularios.Control.sepMes;
            txtOctIMes.Text = Formularios.Control.octMes;
            txtNovIMes.Text = Formularios.Control.novMes;
            txtDicIMes.Text = Formularios.Control.dicMes;*/
      
            //Cargar datos de la tabla retencionesISR
            Clases.conexiones.InfoRetencionesISR();
            txtEneRetISR.Text = Formularios.Control.eneRISR;
            txtFebRetISR.Text = Formularios.Control.febRISR;
            txtMarRetISR.Text = Formularios.Control.marRISR;
            txtAbrRetISR.Text = Formularios.Control.abrRISR;
            txtMayRetISR.Text = Formularios.Control.mayRISR;
            txtJunRetISR.Text = Formularios.Control.junRISR;
            txtJulRetISR.Text = Formularios.Control.julRISR;
            txtAgoRetISR.Text = Formularios.Control.agoRISR;
            txtSepRetISR.Text = Formularios.Control.sepRISR;
            txtOctRetISR.Text = Formularios.Control.octRISR;
            txtNovRetISR.Text = Formularios.Control.novRISR;
            txtDicRetISR.Text = Formularios.Control.dicRISR;
     
            //Cargar datos de la tabla retencionesIVA
            Clases.conexiones.InfoRetencionesIVA();
            txtEneRetIVA.Text = Formularios.Control.eneRIVA;
            txtFebRetIVA.Text = Formularios.Control.febRIVA;
            txtMarRetIVA.Text = Formularios.Control.marRIVA;
            txtAbrRetIVA.Text = Formularios.Control.abrRIVA;
            txtMayRetIVA.Text = Formularios.Control.mayRIVA;
            txtJunRetIVA.Text = Formularios.Control.junRIVA;
            txtJulRetIVA.Text = Formularios.Control.julRIVA;
            txtAgoRetIVA.Text = Formularios.Control.agoRIVA;
            txtSepRetIVA.Text = Formularios.Control.sepRIVA;
            txtOctRetIVA.Text = Formularios.Control.octRIVA;
            txtNovRetIVA.Text = Formularios.Control.novRIVA;
            txtDicRetIVA.Text = Formularios.Control.dicRIVA;
          
            //Haciendo los textbox de enero vacios a 0
            if (txtEne16.Text =="") {
                txtEne16.Text = "0";
            }
            if (txtEne0.Text =="")
            {
                txtEne0.Text = "0";
            }
            if (txtEneExe.Text=="")
            {
                txtEneExe.Text = "0";
            }
            if (txtEneNoo.Text=="")
            {
                txtEneNoo.Text = "0";
            }
            if (txtEneIMes.Text =="")
            {
                txtEneIMes.Text = "0";
            }
            if (txtEneRetISR.Text == "")
            {
                txtEneRetISR.Text = "0";
            }
            if (txtEneRetIVA.Text == "")
            {
                txtEneRetIVA.Text = "0";
            }
            //Haciendo los textbox de febrero vacios a 0
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
            if (txtJunIMes.Text == "")
            {
                txtJunIMes.Text = "0";
            }
            if (txtFebRetISR.Text == "")
            {
                txtFebRetISR.Text = "0";
            }
            if (txtFebRetIVA.Text == "")
            {
                txtFebRetIVA.Text = "0";
            }
            //Haciendo los textbox de marzo vacios a 0
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
            if (txtMayIMes.Text == "")
            {
                txtMayIMes.Text = "0";
            }
            if (txtMayRetISR.Text == "")
            {
                txtMayRetISR.Text = "0";
            }
            if (txtMayRetIVA.Text == "")
            {
                txtMayRetIVA.Text = "0";
            }
            //Haciendo los textbox de Abril vacios a 0
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
            if (txtAbrIMes.Text == "")
            {
                txtAbrIMes.Text = "0";
            }
            if (txtAbrRetISR.Text == "")
            {
                txtAbrRetISR.Text = "0";
            }
            if (txtAbrRetIVA.Text == "")
            {
                txtAbrRetIVA.Text = "0";
            }
            //Haciendo los textbox de Mayo vacios a 0
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
            if (txtMayIMes.Text == "")
            {
                txtMayIMes.Text = "0";
            }
            if (txtMayRetISR.Text == "")
            {
                txtMayRetISR.Text = "0";
            }
            if (txtMayRetIVA.Text == "")
            {
                txtMayRetIVA.Text = "0";
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
            if (txtJunIMes.Text == "")
            {
                txtJunIMes.Text = "0";
            }
            if (txtJunRetISR.Text == "")
            {
                txtJunRetISR.Text = "0";
            }
            if (txtJunRetIVA.Text == "")
            {
                txtJunRetIVA.Text = "0";
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
            if (txtJulIMes.Text == "")
            {
                txtJulIMes.Text = "0";
            }
            if (txtJulRetISR.Text == "")
            {
                txtJulRetISR.Text = "0";
            }
            if (txtJulRetIVA.Text == "")
            {
                txtJulRetIVA.Text = "0";
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
            if (txtAgoIMes.Text == "")
            {
                txtAgoIMes.Text = "0";
            }
            if (txtAgoRetISR.Text == "")
            {
                txtAgoRetISR.Text = "0";
            }
            if (txtAgoRetIVA.Text == "")
            {
                txtAgoRetIVA.Text = "0";
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
            if (txtSepIMes.Text == "")
            {
                txtSepIMes.Text = "0";
            }
            if (txtSepRetISR.Text == "")
            {
                txtSepRetISR.Text = "0";
            }
            if (txtSepRetIVA.Text == "")
            {
                txtSepRetIVA.Text = "0";
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
            if (txtOctIMes.Text == "")
            {
                txtOctIMes.Text = "0";
            }
            if (txtOctRetISR.Text == "")
            {
                txtOctRetISR.Text = "0";
            }
            if (txtOctRetIVA.Text == "")
            {
                txtOctRetIVA.Text = "0";
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
            if (txtNovIMes.Text == "")
            {
                txtNovIMes.Text = "0";
            }
            if (txtNovRetISR.Text == "")
            {
                txtNovRetISR.Text = "0";
            }
            if (txtNovRetIVA.Text == "")
            {
                txtNovRetIVA.Text = "0";
            }
            //Haciendo los textbox de diciembre vacios a 0
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
            if (txtDicIMes.Text == "")
            {
                txtDicIMes.Text = "0";
            }
            if (txtDicRetISR.Text == "")
            {
                txtDicRetISR.Text = "0";
            }
            if (txtDicRetIVA.Text == "")
            {
                txtDicRetIVA.Text = "0";
            }

            //Calculando total de cada mes --ENERO
            double totEne = double.Parse(txtEne16.Text) + double.Parse(txtEne0.Text) + double.Parse(txtEneExe.Text) +  double.Parse(txtEneNoo.Text);
            txtEneIMes.Text = totEne.ToString();

            //Calculando total de cada mes --FEBRERO
            double totFeb= double.Parse(txtFeb16.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtFebNoo.Text);
            txtFebIMes.Text = totFeb.ToString();

            //Calculando total de cada mes --MARZO
            double totMar = double.Parse(txtOct16.Text) + double.Parse(txtOct0.Text) + double.Parse(txtOctExe.Text) + double.Parse(txtOctNoo.Text);
            txtMarIMes.Text = totMar.ToString();


            //Calculando total de cada mes --ABRIL
            double totAbr = double.Parse(txtAbr16.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtAbrNoo.Text);
            txtAbrIMes.Text = totAbr.ToString();


            //Calculando total de cada mes --MAYO
            double totMay = double.Parse(txtMay16.Text) + double.Parse(txtMay0.Text) + double.Parse(txtMayExe.Text) +  double.Parse(txtMayNoo.Text);
            txtMayIMes.Text = totMay.ToString();


            //Calculando total de cada mes --JUNIO
            double totJun = double.Parse(txtJun16.Text) + double.Parse(txtJun0.Text) + double.Parse(txtJunExe.Text) +  double.Parse(txtJunNoo.Text);
            txtJunIMes.Text = totJun.ToString();


            //Calculando total de cada mes --JULIO
            double totJul = double.Parse(txtJul16.Text) + double.Parse(txtJul0.Text) + double.Parse(txtJulExe.Text) +  double.Parse(txtJulNoo.Text);
            txtJulIMes.Text = totJul.ToString();


            //Calculando total de cada mes --AGOSTO
            double totAgo = double.Parse(txtAgo16.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtAgoExe.Text) +  double.Parse(txtAgoNoo.Text);
            txtAgoIMes.Text = totAgo.ToString();


            //Calculando total de cada mes --SEPTIEMBRE
            double totSep = double.Parse(txtSep16.Text) + double.Parse(txtSep0.Text) + double.Parse(txtSepExe.Text) +  double.Parse(txtSepNoo.Text);
            txtSepIMes.Text = totSep.ToString();


            //Calculando total de cada mes --OCTUBRE
            double totOct = double.Parse(txtOct16.Text) + double.Parse(txtOct0.Text) + double.Parse(txtOctExe.Text) +  double.Parse(txtOctNoo.Text);
            txtOctIMes.Text = totOct.ToString();


            //Calculando total de cada mes --NOVIEMBRE
            double totNov = double.Parse(txtNov16.Text) + double.Parse(txtNov0.Text) + double.Parse(txtNovExe.Text) +  double.Parse(txtNovNoo.Text);
            txtNovIMes.Text = totNov.ToString();


            //Calculando total de cada mes --DICIEMBRE
            double totDic = double.Parse(txtDic16.Text) + double.Parse(txtDic0.Text) + double.Parse(txtDicExe.Text) +  double.Parse(txtDicNoo.Text);
            txtDicIMes.Text = totDic.ToString();

            //Calculando total de cada ingreso --16%
            double totI16 = double.Parse(txtEne16.Text) + double.Parse(txtFeb16.Text) + double.Parse(txtMar16.Text) + double.Parse(txtAbr16.Text) + double.Parse(txtMay16.Text) +
                +double.Parse(txtJun16.Text) + double.Parse(txtJul16.Text) + double.Parse(txtAgo16.Text) + double.Parse(txtSep16.Text) + double.Parse(txtOct16.Text) + 
                double.Parse(txtNov16.Text) + double.Parse(txtDic16.Text);
            txtTot16.Text = totI16.ToString();

            //Calculando total de cada ingreso --0%
            double totI0 = double.Parse(txtEne0.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtMar0.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtMay0.Text) +
                +double.Parse(txtJun0.Text) + double.Parse(txtJul0.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtSep0.Text) + double.Parse(txtOct0.Text) +
                double.Parse(txtNov0.Text) + double.Parse(txtDic0.Text);
            txtTot0.Text = totI0.ToString();

            //Calculando total de cada ingreso --Exentos
            double totIExe = double.Parse(txtEneExe.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtMayExe.Text) +
                +double.Parse(txtJunExe.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtOctExe.Text) +
                double.Parse(txtNovExe.Text) + double.Parse(txtDicExe.Text);
            txtTotExe.Text = totIExe.ToString();

            //Calculando total de cada ingreso --No Objeto
            double totINoo = double.Parse(txtEneNoo.Text) + double.Parse(txtFebNoo.Text) + double.Parse(txtMarNoo.Text) + double.Parse(txtAbrNoo.Text) + double.Parse(txtMayNoo.Text) +
                +double.Parse(txtJunNoo.Text) + double.Parse(txtJulNoo.Text) + double.Parse(txtAgoNoo.Text) + double.Parse(txtSepNoo.Text) + double.Parse(txtOctNoo.Text) +
                double.Parse(txtNovNoo.Text) + double.Parse(txtDicNoo.Text);
            txtTotNoo.Text = totINoo.ToString();

            //Calculando total de cada ingreso --Mes
            double totIIMes = double.Parse(txtEneIMes.Text) + double.Parse(txtFebIMes.Text) + double.Parse(txtMarIMes.Text) + double.Parse(txtAbrIMes.Text) + double.Parse(txtMayIMes.Text) +
                +double.Parse(txtJunIMes.Text) + double.Parse(txtJulIMes.Text) + double.Parse(txtAgoIMes.Text) + double.Parse(txtSepIMes.Text) + double.Parse(txtOctIMes.Text) +
                double.Parse(txtNovIMes.Text) + double.Parse(txtDicIMes.Text);
            txtTotIMes.Text = totIIMes.ToString();

            //Calculando total de cada ingreso --Retenciones IVA
            double totIRetIVA = double.Parse(txtEneRetIVA.Text) + double.Parse(txtFebRetIVA.Text) + double.Parse(txtMarRetIVA.Text) + double.Parse(txtAbrRetIVA.Text) + double.Parse(txtMayRetIVA.Text) +
                +double.Parse(txtJunRetIVA.Text) + double.Parse(txtJulRetIVA.Text) + double.Parse(txtAgoRetIVA.Text) + double.Parse(txtSepRetIVA.Text) + double.Parse(txtOctRetIVA.Text) +
                double.Parse(txtNovRetIVA.Text) + double.Parse(txtDicRetIVA.Text);
            txtTotRetIVA.Text = totIRetIVA.ToString();

            //Calculando total de cada ingreso --Terenciones ISR
            double totIRetISR = double.Parse(txtEneRetISR.Text) + double.Parse(txtFebRetISR.Text) + double.Parse(txtMarRetISR.Text) + double.Parse(txtAbrRetISR.Text) + double.Parse(txtMayRetISR.Text) +
                +double.Parse(txtJunRetISR.Text) + double.Parse(txtJulRetISR.Text) + double.Parse(txtAgoRetISR.Text) + double.Parse(txtSepRetISR.Text) + double.Parse(txtOctRetISR.Text) +
                double.Parse(txtNovRetISR.Text) + double.Parse(txtDicRetISR.Text);
            txtTotRetISR.Text = totIRetISR.ToString();

            //Calcular lo acumulado
            double acumulado;
            acumulado = double.Parse(txtEneIMes.Text);
            txtEneAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebIMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarIMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrIMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();




        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Envio de datos para insercion o actualizacion de los datos de las tablas
            Clases.conexiones.ingresos16(Formularios.Control.idCliente,txtEne16.Text, txtJun16.Text, txtMay16.Text, txtAbr16.Text, txtMay16.Text, txtJun16.Text,
                txtJul16.Text, txtAgo16.Text, txtSep16.Text, txtOct16.Text, txtNov16.Text, txtDic16.Text, txtTot16.Text);

            Clases.conexiones.ingresos0(Formularios.Control.idCliente, txtEne0.Text, txtJun0.Text, txtMay0.Text, txtAbr0.Text, txtMay0.Text, txtJun0.Text,
                txtJul0.Text, txtAgo0.Text, txtSep0.Text, txtOct0.Text, txtNov0.Text, txtDic0.Text, txtTot0.Text);

            Clases.conexiones.ingresosExentos(Formularios.Control.idCliente, txtEneExe.Text, txtJunExe.Text, txtMayExe.Text, txtAbrExe.Text, txtMayExe.Text, txtJunExe.Text,
                txtJulExe.Text, txtAgoExe.Text, txtSepExe.Text, txtOctExe.Text, txtNovExe.Text, txtDicExe.Text, txtTotExe.Text);

            Clases.conexiones.ingresosNoObjeto(Formularios.Control.idCliente, txtEneNoo.Text, txtJunNoo.Text, txtMayNoo.Text, txtAbrNoo.Text, txtMayNoo.Text, txtJunNoo.Text,
                txtJulNoo.Text, txtAgoNoo.Text, txtSepNoo.Text, txtOctNoo.Text, txtNovNoo.Text, txtDicNoo.Text, txtTotNoo.Text);

            Clases.conexiones.ingresosMes(Formularios.Control.idCliente, txtEneIMes.Text, txtJunIMes.Text, txtMayIMes.Text, txtAbrIMes.Text, txtMayIMes.Text, txtJunIMes.Text,
               txtJulIMes.Text, txtAgoIMes.Text, txtSepIMes.Text, txtOctIMes.Text, txtNovIMes.Text, txtDicIMes.Text, txtTotIMes.Text);

            Clases.conexiones.retencionesISR(Formularios.Control.idCliente, txtEneRetISR.Text, txtJunRetISR.Text, txtMayRetISR.Text, txtAbrRetISR.Text, txtMayRetISR.Text, txtJunRetISR.Text,
               txtJulRetISR.Text, txtAgoRetISR.Text, txtSepRetISR.Text, txtOctRetISR.Text, txtNovRetISR.Text, txtDicRetISR.Text, txtTotRetISR.Text);

            Clases.conexiones.retencionesIVA(Formularios.Control.idCliente, txtEneRetIVA.Text, txtJunRetIVA.Text, txtMayRetIVA.Text, txtAbrRetIVA.Text, txtMayRetIVA.Text, txtJunRetIVA.Text,
               txtJulRetIVA.Text, txtAgoRetIVA.Text, txtSepRetIVA.Text, txtOctRetIVA.Text, txtNovRetIVA.Text, txtDicRetIVA.Text, txtTotRetIVA.Text);



            MessageBox.Show("Everything will be alright");

            this.Hide();

            

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtEneNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --ENERO TIEMPO REAL
            double totEne = double.Parse(txtEne16.Text) + double.Parse(txtEne0.Text) + double.Parse(txtEneExe.Text) + double.Parse(txtEneNoo.Text);
            txtEneIMes.Text = totEne.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtEneIMes.Text);
            txtEneAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebIMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarIMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrIMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtFebNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --FEBRERO TIEMPO REAL
            double totFeb = double.Parse(txtFeb16.Text) + double.Parse(txtFeb0.Text) + double.Parse(txtFebExe.Text) + double.Parse(txtFebNoo.Text);
            txtFebIMes.Text = totFeb.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtEneAcu.Text) + double.Parse(txtFebIMes.Text);
            txtFebAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarIMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrIMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtMarNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --MARZO TIEMPO REAL
            double totMar = double.Parse(txtMar16.Text) + double.Parse(txtMar0.Text) + double.Parse(txtMarExe.Text) + double.Parse(txtMarNoo.Text);
            txtMarIMes.Text = totMar.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtFebAcu.Text) + double.Parse(txtMarIMes.Text);
            txtMarAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrIMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtAbrNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --ABRIL TIEMPO REAL
            double totAbr = double.Parse(txtAbr16.Text) + double.Parse(txtAbr0.Text) + double.Parse(txtAbrExe.Text) + double.Parse(txtAbrNoo.Text);
            txtAbrIMes.Text = totAbr.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtMarAcu.Text) + double.Parse(txtAbrIMes.Text);
            txtAbrAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtMayNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --MAYO TIEMPO REAL
            double totMay = double.Parse(txtMay16.Text) + double.Parse(txtMay0.Text) + double.Parse(txtMayExe.Text) + double.Parse(txtMayNoo.Text);
            txtMayIMes.Text = totMay.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtAbrAcu.Text) + double.Parse(txtMayIMes.Text);
            txtMayAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();



        }

        private void txtJunNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --JUNIO TIEMPO REAL
            double totJun = double.Parse(txtJun16.Text) + double.Parse(txtJun0.Text) + double.Parse(txtJunExe.Text) + double.Parse(txtJunNoo.Text);
            txtJunIMes.Text = totJun.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtMayAcu.Text) + double.Parse(txtJunIMes.Text);
            txtJunAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtJulNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --JULIO TIEMPO REAL
            double totJul = double.Parse(txtJul16.Text) + double.Parse(txtJul0.Text) + double.Parse(txtJulExe.Text) + double.Parse(txtJulNoo.Text);
            txtJulIMes.Text = totJul.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtJunAcu.Text) + double.Parse(txtJulIMes.Text);
            txtJulAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtAgoNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --AGOSTO TIEMPO REAL
            double totAgo = double.Parse(txtAgo16.Text) + double.Parse(txtAgo0.Text) + double.Parse(txtAgoExe.Text) + double.Parse(txtAgoNoo.Text);
            txtAgoIMes.Text = totAgo.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtJulAcu.Text) + double.Parse(txtAgoIMes.Text);
            txtAgoAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();

        }

        private void txtSepNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --SEPTIEMBRE TIEMPO REAL
            double totSep = double.Parse(txtSep16.Text) + double.Parse(txtSep0.Text) + double.Parse(txtSepExe.Text) + double.Parse(txtSepNoo.Text);
            txtSepIMes.Text = totSep.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtAgoAcu.Text) + double.Parse(txtSepIMes.Text);
            txtSepAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtOctNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --OCTUBRE TIEMPO REAL
            double totOct = double.Parse(txtOct16.Text) + double.Parse(txtOct0.Text) + double.Parse(txtOctExe.Text) + double.Parse(txtOctNoo.Text);
            txtOctIMes.Text = totOct.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtSepAcu.Text) + double.Parse(txtOctIMes.Text);
            txtOctAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }

        private void txtNovNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --NOVIEMBRE TIEMPO REAL
            double totNov = double.Parse(txtNov16.Text) + double.Parse(txtNov0.Text) + double.Parse(txtNovExe.Text) + double.Parse(txtNovNoo.Text);
            txtNovIMes.Text = totNov.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtOctAcu.Text) + double.Parse(txtNovIMes.Text);
            txtNovAcu.Text = acumulado.ToString();
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
            txtDicAcu.Text = acumulado.ToString();
        }    

        private void txtDicNoo_TextChanged(object sender, EventArgs e)
        {
            //Calculando total de cada mes --DICIEMBRE TIEMPO REAL
            double totDic = double.Parse(txtDic16.Text) + double.Parse(txtDic0.Text) + double.Parse(txtDicExe.Text) + double.Parse(txtDicNoo.Text);
            txtDicIMes.Text = totDic.ToString();
            //Haciendo suma de acumulados en TIEMPO REAL
            double acumulado;
            acumulado = double.Parse(txtNovAcu.Text) + double.Parse(txtDicIMes.Text);
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

        private void txtDicIMes_Leave(object sender, EventArgs e)
        {
            //Calculando total de cada ingreso --Mes
            double totIIMes = double.Parse(txtEneIMes.Text) + double.Parse(txtFebIMes.Text) + double.Parse(txtMarIMes.Text) + double.Parse(txtAbrIMes.Text) + double.Parse(txtMayIMes.Text) +
            +double.Parse(txtJunIMes.Text) + double.Parse(txtJulIMes.Text) + double.Parse(txtAgoIMes.Text) + double.Parse(txtSepIMes.Text) + double.Parse(txtOctIMes.Text) +
            double.Parse(txtNovIMes.Text) + double.Parse(txtDicIMes.Text);
            txtTotIMes.Text = totIIMes.ToString();

        }
      
    }
}
