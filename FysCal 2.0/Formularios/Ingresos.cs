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
            txtTot16.Text = Formularios.Control.tot16;
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
            txtTot0.Text = Formularios.Control.tot0;
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
            txtTotExe.Text = Formularios.Control.totExe;
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
            txtTotNoo.Text = Formularios.Control.totNoo;
            //Cargar datos de la tabla ingresosMes
            Clases.conexiones.InfoIngresosMes();
            txtEneIMes.Text = Formularios.Control.eneMes;
            txtFebIMes.Text = Formularios.Control.febMes;
            txtMarIMes.Text = Formularios.Control.marMes;
            txtAbrIMes.Text = Formularios.Control.abrMes;
            txtMayIMes.Text = Formularios.Control.mayMes;
            txtJunIMes.Text = Formularios.Control.junMes;
            txtJulIMes.Text = Formularios.Control.julMes;
            txtAgoIMes.Text = Formularios.Control.agoMes;
            txtSepIMes.Text = Formularios.Control.sepMes;
            txtOctIMes.Text = Formularios.Control.octMes;
            txtNovIMes.Text = Formularios.Control.novMes;
            txtDicIMes.Text = Formularios.Control.dicMes;
            txtTotIMes.Text = Formularios.Control.totMes;
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
            txtTotRetISR.Text = Formularios.Control.totRISR;
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
            txtTotRetIVA.Text = Formularios.Control.totRIVA;

           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Obtencion de datos para insercion o actualizacion de los datos de las tablas
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

            Clases.conexiones.retencionesISR(Formularios.Control.idCliente, txtEneRetISR.Text, txtFebRetISR.Text, txtMarRetISR.Text, txtAbrRetISR.Text, txtMayRetISR.Text, txtJunRetISR.Text,
               txtJulRetISR.Text, txtAgoRetISR.Text, txtSepRetISR.Text, txtOctRetISR.Text, txtNovRetISR.Text, txtDicRetISR.Text, txtTotRetISR.Text);

            Clases.conexiones.retencionesIVA(Formularios.Control.idCliente, txtEneRetIVA.Text, txtFebRetIVA.Text, txtMarRetIVA.Text, txtAbrRetIVA.Text, txtMayRetIVA.Text, txtJunRetIVA.Text,
               txtJulRetIVA.Text, txtAgoRetIVA.Text, txtSepRetIVA.Text, txtOctRetIVA.Text, txtNovRetIVA.Text, txtDicRetIVA.Text, txtTotRetIVA.Text);



            MessageBox.Show("Everything will be alright");

        }

        private void txtEneIMes_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
