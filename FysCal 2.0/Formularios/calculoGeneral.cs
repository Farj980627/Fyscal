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
    public partial class calculoGeneral : Form
    {
        public calculoGeneral()
        {
            InitializeComponent();
        }
        public static string ingTotPeriodo, dedTotalPeriodo, ingAcumulado, dedAcumulada, totIngAcum, totDedAcu, ISRCausado, ingIVA16, dedIVA16, ingIVA0, dedIVA0,
            ingExe, dedExe, retiva;
        public static List<double[]> arreglos = new List<double[]>();     
        
      
        
       public static double[] enero = new double[] { 0.01, 578.53, 4910.19, 8629.21, 10031.08, 12009.95, 24222.32, 38177.70, 72887.51, 97183.34, 291550.01 };
        public static double[] cuotaenero = new double[] { 0.0, 11.11, 288.33, 692.96, 917.26, 1271.87, 3880.44, 7162.74, 17575.69, 25350.35, 91435.02 };
        public static double[] porcentajeenero = new double[] { 1.92, 6.40, 10.88, 16.00, 17.92, 21.36, 23.52, 30.00, 32.00, 34.00, 35.00 };

        public static double[] febrero = new double[] { 0.01, 1157.05, 9820.37, 17258.41,20062.15, 24019.89, 48444.63, 76355.39, 145775.01, 1943666.67, 583100.01 };
        public static double[] cuotafeb = new double[] { 0.00, 22.22, 576.66, 1385.92, 1834.52, 2543.74, 7760.88, 14325.48, 35151.38, 50700.70, 182870.04 };

        public static double[] marzo = new double[] { 0.01, 1735.57, 14730.55, 25887.61, 30093.22, 36029.83, 72666.94, 114533.08, 218662.51, 291550.00, 874650.01 };
        public static double[] cuotamar = new double[] { 0.00, 33.33, 864.99, 2078.88, 2751.78, 3815.61, 11641.32, 21488.22, 52727.07, 76051.05, 274305.06 };

        public static double[] abril = new double[] { 0.01, 2314.09, 19640.73, 34516.81, 40124.29, 48039.77, 96889.25, 152710.77, 291550.01, 388733.33, 1166200.01 };
        public static double[] cuotaabr = new double[] { 0.00, 44.44, 1153.32, 2771.84, 3669.04, 5087.48, 15521.76, 28650.96, 70302.76, 101401.40, 365740.08 };

        public static double[] mayo = new double[] { 0.01, 2892.61, 24550.91, 43146.01, 50155.36, 60049.71, 121111.56, 190888.46, 364437.51, 485916.66, 1457750.01 };
        public static double[] cuotamay = new double[] { 0.00, 55.55, 1441.65, 3464.80, 4586.30, 6359.35, 19402.20, 35813.70, 87878.45, 126751.75, 457175.10 };

        public static double[] junio = new double[] { 0.01, 3471.13, 29461.09, 51775.21, 60186.43, 72059.65, 145333.87, 229066.15, 437325.01, 583099.99, 1749300.01 };
        public static double[] cuotajun = new double[] {0.00, 66.66, 1729.98, 4157.76, 5503.56, 7631.22, 23282.64, 42976.44, 105454.14, 152102.10, 548610.12 };

        public static double[] julio = new double[] { 0.01,4049.65, 34371.27, 60404.41, 70217.50, 84069.59, 169556.18, 267243.84, 510212.51, 680283.32, 2040850.01 };
        public static double[] cuotajul = new double[] { 0.00, 77.77, 2018.31, 4850.72, 6420.82, 8903.09, 27163.08, 50139.18, 123029.83, 640045.14 };

        public static double[] agosto = new double[] {0.01, 4628.17, 39281.45, 69033.61, 80248.57, 96079.53, 193778.49, 305421.53, 583100.01, 777466.65, 2332400.01 };

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //recargos
            int pagoY, pagoM, inicioY, inicioM, totalMeses, diafinal;
            

            pagoY = dtPago.Value.Year;
            pagoM = dtPago.Value.Month;
            inicioY = dtInicio.Value.Year;
            inicioM = dtInicio.Value.Month;
            diafinal = dtPago.Value.Day;
            totalMeses = ((pagoY - inicioY)*12) + (pagoM - inicioM);
            if (diafinal < 18)
            {
                totalMeses = totalMeses - 1;
            }

            double porce = totalMeses * 1.47;
           
            if (txtISRCARGO.Text == "0")
            {
                txtrecargo.Text = "0";
            }
            else
            {
                
                txtrecargo.Text = ((double.Parse(txtDetPagACargo.Text) * porce) / 100).ToString();
            }

            //PAgo isr a carago
            txtISRCargoFinalFinalChido.Text = ((double.Parse(txtDetPagACargo.Text) + double.Parse(txtpart.Text) + double.Parse(txtrecargo.Text)) - (double.Parse(txtSubsidio.Text) - double.Parse(txtcomp.Text))).ToString();
            

        }

        private void txtcomp_TextChanged(object sender, EventArgs e)
        {
            //PAgo isr a carago
            txtISRCargoFinalFinalChido.Text = ((double.Parse(txtDetPagACargo.Text) + double.Parse(txtpart.Text) + double.Parse(txtrecargo.Text)) - (double.Parse(txtSubsidio.Text) - double.Parse(txtcomp.Text))).ToString();

        }

        private void txtSubsidio_TextChanged(object sender, EventArgs e)
        {
            //PAgo isr a carago
            txtISRCargoFinalFinalChido.Text = ((double.Parse(txtDetPagACargo.Text) + double.Parse(txtpart.Text) + double.Parse(txtrecargo.Text)) - (double.Parse(txtSubsidio.Text) - double.Parse(txtcomp.Text))).ToString();

        }

        private void dtpago1_ValueChanged(object sender, EventArgs e)
        { //recargos
            int pagoY, pagoM, inicioY, inicioM, totalMeses, diafinal;


            pagoY = dtpago1.Value.Year;
            pagoM = dtpago1.Value.Month;
            inicioY = dtinicio1.Value.Year;
            inicioM = dtinicio1.Value.Month;
            diafinal = dtpago1.Value.Day;
            totalMeses = ((pagoY - inicioY) * 12) + (pagoM - inicioM);
            if (diafinal < 18)
            {
                totalMeses = totalMeses - 1;
            }

            double porce = totalMeses * 1.47;

            if (IVACargoMes.Text == "0")
            {
                txtRecargos.Text = "0";
            }
            else
            {
                
                txtRecargos.Text = ((double.Parse(txtCantCargo.Text) * porce) / 100).ToString();
            }

            //Pago iva a carago
            txtIVAACARGO.Text = ((double.Parse(txtCantCargo.Text) + double.Parse(txtParteAct.Text) + double.Parse(txtRecargos.Text)) - (double.Parse(txtCompensasiones.Text))).ToString();

        }

        private void txtOtrasCant_TextChanged(object sender, EventArgs e)
        {
            txtCantCargo.Text = (double.Parse(IVACargoMes.Text) + double.Parse(txtOtrasCant.Text)).ToString();
            txtIVAACARGO.Text = ((double.Parse(txtCantCargo.Text) + double.Parse(txtParteAct.Text) + double.Parse(txtRecargos.Text)) - (double.Parse(txtCompensasiones.Text))).ToString();
        }

        private void txtCompensasiones_TextChanged(object sender, EventArgs e)
        {
            txtIVAACARGO.Text = ((double.Parse(txtCantCargo.Text) + double.Parse(txtParteAct.Text) + double.Parse(txtRecargos.Text)) - (double.Parse(txtCompensasiones.Text))).ToString();
        }

        private void txtCantCargo_TextChanged(object sender, EventArgs e)
        {
            int pagoY, pagoM, inicioY, inicioM, totalMeses, diafinal;


            pagoY = dtpago1.Value.Year;
            pagoM = dtpago1.Value.Month;
            inicioY = dtinicio1.Value.Year;
            inicioM = dtinicio1.Value.Month;
            diafinal = dtpago1.Value.Day;
            totalMeses = ((pagoY - inicioY) * 12) + (pagoM - inicioM);
            if (diafinal < 18)
            {
                totalMeses = totalMeses - 1;
            }

            double porce = totalMeses * 1.47;

            if (IVACargoMes.Text == "0")
            {
                txtRecargos.Text = "0";
            }
            else
            {

                txtRecargos.Text = ((double.Parse(txtCantCargo.Text) * porce) / 100).ToString();
            }

            //Pago iva a carago
            txtIVAACARGO.Text = ((double.Parse(txtCantCargo.Text) + double.Parse(txtParteAct.Text) + double.Parse(txtRecargos.Text)) - (double.Parse(txtCompensasiones.Text))).ToString();
        }

        private void txtRecargos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            cbMes.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            cbMes.SelectedIndex = -1;
        }

        public static double[] cuotaago = new double[] { 0.00, 88.88, 2306.64, 5543.68, 7338.08, 10174.96, 31043.52, 57301.92, 140605.52, 202802.80, 731480.16 };

        public static double[] septiembre = new double[] { 0.01, 5206.69, 44191.63, 77662.81, 90279.64, 108089.47, 218000.80, 343599.22, 655987.51, 874649.98, 2623950.01 };
        public static double[] cuotasep = new double[] { 0.00, 99.99, 2594.97, 6236.64, 8255.34, 11446.83, 34923.96, 64464.66, 158181.21, 228153.15, 822915.18 };

        public static double[] octubre = new double[] { 0.01, 5785.21, 49101.81, 86292.01, 100310.71, 120099.41, 242223.11, 381776.91, 728875.01, 971833.31, 2915500.01};
        public static double[] cuotaoct = new double[] { 0.00, 111.10, 2883.30, 6929.60, 9172.60, 12718.70, 38804.40, 71627.40, 175756.90, 253503.50, 914350.20 };

        public static double[] noviembre = new double[] { 0.01, 6363.73, 54011.99, 94921.21, 110341.78, 132109.35, 266445.42, 419954.60, 801762.51, 1069016.64, 3207050.01 };
        public static double[] cuotanov = new double[] { 0.00, 122.21, 3171.63, 7622.56, 10089.86, 13990.57, 42684.84, 78790.14, 193332.59, 278853.85, 1005785.22 };

        public static double[] diciembre = new double[] { 0.01, 6942.25, 58922.17, 103550.41, 120372.85, 144119.29, 290667.73, 458132.29, 874650.01, 1166200.01, 3498600.01 };
        public static double[] cuotadic = new double[] { 0.00, 133.37, 3459.99, 8315.48, 11007.11, 15262.49, 46565.29, 85952.89, 210908.30, 304204.17, 1097220.29 };



        public double baseGrabable, totalIngAct, totalDedAct, sumaActosGrabIng, sumaActosGrabDed, limiteInferior;
        private void calculoGeneral_Load(object sender, EventArgs e)
        {
            



        }



        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtrecargo.Text = "0";
            txtISRCargoFinalFinalChido.Text = "0";
            //Calculo de el ISR
            if (tabControl1.SelectedIndex == 0)
            {
                

                double sumaing, sumaded;
                Clases.conexiones.datosCalculoGeneralISR(cbMes.SelectedItem.ToString());

                //Compras y gastos del periodo
                txtDedPeriodo.Text = dedTotalPeriodo;

                //Ingresos del mes
                txtIngPeriodo.Text = ingTotPeriodo;

                //Deducciones Acumuladas
                txtDedAcumulada.Text = dedAcumulada;

                //Ingresos Acumulados
                txtIngAcumulado.Text = ingAcumulado;

                //Total de ingresos acumulados
                sumaing = double.Parse(ingTotPeriodo) + double.Parse(ingAcumulado);
                txtTotalIngAcu.Text = sumaing.ToString();

                //Total de deducciones acumuladas
                sumaded = double.Parse(dedTotalPeriodo) + double.Parse(dedAcumulada);
                txtTotalDedAcu.Text = sumaded.ToString();

                //BAse grabable               
                baseGrabable = sumaing - sumaded;
                txtBaseGrab.Text = baseGrabable.ToString();

                //Calcular el ISR de Acuerdo al art 106                
                if (cbMes.SelectedIndex.Equals(0))                   
                {
                    
                    for (int i = 0; i < enero.Length ; i++)
                    {
                        if (baseGrabable > enero[i])
                        {
                            limiteInferior = enero[i];
                            double exclim = baseGrabable - limiteInferior;
                             double exclim2 = exclim *  porcentajeenero[i] / 100;
                            txtArt106.Text =(Math.Truncate(exclim2) + cuotaenero[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(1))
                {
                   
                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > febrero[i])
                        {
                            limiteInferior = febrero[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;
                            
                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotafeb[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(2))
                {
                   
                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > marzo[i])
                        {
                            limiteInferior = marzo[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotamar[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(3))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > abril[i])
                        {
                            limiteInferior = abril[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotaabr[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(4))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > mayo[i])
                        {
                            limiteInferior = mayo[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotamay[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(5))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > junio[i])
                        {
                            limiteInferior = junio[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotajun[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(6))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > julio[i])
                        {
                            limiteInferior = julio[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotajul[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(7))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > agosto[i])
                        {
                            limiteInferior = agosto[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotaago[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(8))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > septiembre[i])
                        {
                            limiteInferior = septiembre[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotasep[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(9))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > octubre[i])
                        {
                            limiteInferior = octubre[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotaoct[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(10))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > noviembre[i])
                        {
                            limiteInferior = noviembre[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotanov[i]).ToString();
                        }
                    }
                }
                if (cbMes.SelectedIndex.Equals(11))
                {

                    for (int i = 0; i < febrero.Length; i++)
                    {
                        if (baseGrabable > diciembre[i])
                        {
                            limiteInferior = diciembre[i];
                            double exclim = baseGrabable - limiteInferior;
                            double exclim2 = exclim * porcentajeenero[i] / 100;

                            txtArt106.Text = ((Math.Truncate(exclim2)) + cuotadic[i]).ToString();
                        }
                    }
                }
                //Pagos provisionales efecuados
                if (cbMes.SelectedIndex == 0)
                {
                    txtProvisionales.Text = "0";

                }
                else
                {
                    double total = 0;

                    for (int i = 0; i < cbMes.SelectedIndex; i++)
                    {
                        total = total + double.Parse(Clases.conexiones.pagoProv()[i]);
                    }
                    
                        txtProvisionales.Text = total.ToString();
                   
                }

                 //Diferencia
                txtDif.Text=(double.Parse(txtArt106.Text) - double.Parse( txtProvisionales.Text)).ToString();

                //ISR retenido por terceros
                double tot = 0;
                switch (cbMes.SelectedIndex)
                {

                    case 0:
                        txtRetenido.Text = "0";
                        break;
                    case 1:
                        for (int i = 0; i < 2; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 2:
                        
                        for (int i = 0; i < 3; i++)
                        {                            
                             tot = tot  + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 3:
                        
                        for (int i = 0; i < 4; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 4:

                        for (int i = 0; i < 5; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 5:

                        for (int i = 0; i < 6; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 6:

                        for (int i = 0; i < 7; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 7:

                        for (int i = 0; i < 8; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 8:

                        for (int i = 0; i < 9; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 9:

                        for (int i = 0; i < 10; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 10:

                        for (int i = 0; i < 11; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;
                    case 11:

                        for (int i = 0; i < 12; i++)
                        {
                            tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                        }
                        txtRetenido.Text = tot.ToString();
                        break;

                }
                //ISR a Cargo
                txtISRCARGO.Text = (double.Parse(txtDif.Text) - double.Parse(txtRetenido.Text)).ToString();
                if (double.Parse(txtISRCARGO.Text ) < 0)
                    {
                    txtISRCARGO.Text = "0";

                }
                if (double.Parse(txtISRCARGO.Text) > 0)
                {
                    Clases.conexiones.actProvisionales(cbMes.Items[cbMes.SelectedIndex].ToString(), txtISRCARGO.Text);
                }
                else {
                    Clases.conexiones.actProvisionales(cbMes.Items[cbMes.SelectedIndex].ToString(),"0");
                }

                //Envio de datos 106 and diferencia
                Clases.conexiones.get106Dif(cbMes.Items[cbMes.SelectedIndex].ToString(), txtArt106.Text, txtDif.Text);

                //DETALLES DE PAGO ---------> A CARGO
                txtDetPagACargo.Text = txtISRCARGO.Text;

                //Recargo
               

            }
            //Calculo de el IVA
            else
            {
                Clases.conexiones.datosCalculoGeneralIVA(cbMes.SelectedItem.ToString());
                //Ingresos del mes
                txtIngIVA16.Text = ingIVA16;
                txtIngIVA0.Text = ingIVA0;

                //Deducciones del mes
                txtDed16.Text = dedIVA16;
                txtDed0.Text = dedIVA0;

                //Deducciones e ingresos exentos
                txtDedExe.Text = dedExe;
                txtIngIVAExe.Text = ingExe;

                //total de ingresos
                totalIngAct = double.Parse(txtIngIVA16.Text) + double.Parse(txtIngIVA0.Text) + double.Parse(txtIngIVAExe.Text);
                txtTotalIngAcu.Text = totalIngAct.ToString();

                //total de deducciones
                totalDedAct = double.Parse(txtDed16.Text) + double.Parse(txtDed0.Text) + double.Parse(txtDedExe.Text);
                txtDedAcumulada.Text = totalDedAct.ToString();

                //Suma de los actos grabados
                sumaActosGrabIng = double.Parse(txtIngIVA16.Text) + double.Parse(txtIngIVA0.Text);
                sumaActosGrabDed = double.Parse(txtDed16.Text) + double.Parse(txtDed0.Text);
                txtIngSumaIVA.Text = sumaActosGrabIng.ToString();
                txtDedSuma.Text = sumaActosGrabDed.ToString();

                //Total de ingresos
                txtIngTotalIVA.Text = (double.Parse(txtIngSumaIVA.Text) + double.Parse(txtIngIVAExe.Text)).ToString();
                //totl de IVA cobrado
                txtIngIVACobrado.Text = (double.Parse(txtIngIVA16.Text) * 0.16).ToString();

                //Total de deducciones
                txtDedTotal.Text = (double.Parse(txtDedSuma.Text) + double.Parse(txtDedExe.Text)).ToString();
                //total de IVA Pagado
                txtDedIVAPagado.Text = (double.Parse(txtDed16.Text) * 0.16).ToString();

                //Proporcion
                txtProporcion.Text = (double.Parse(txtIngSumaIVA.Text) / double.Parse(txtIngTotalIVA.Text)).ToString();

                //iva acreditable
                txtIVAAcreditable.Text = (double.Parse(txtDedIVAPagado.Text) * double.Parse(txtProporcion.Text)).ToString();

                //diferencia
                txtDiferiencia.Text = (double.Parse(txtIngIVACobrado.Text) - double.Parse(txtIVAAcreditable.Text)).ToString();

                //IVA retenido
                txtIVARetenido.Text = retiva;

                //IVA  a cargo
                txtIVACargo.Text = (double.Parse(txtDiferiencia.Text) - double.Parse(retiva)).ToString();
                

                //IVA A FAVOR DEL PERIODO
               

                //Iva a Cargo del mes
                
                    IVACargoMes.Text = (double.Parse(txtIVACargo.Text) + double.Parse(txtIVAFavor.Text)).ToString();
               
                //Detalles del Pago
                txtCantCargo.Text = (double.Parse(IVACargoMes.Text) + double.Parse(txtOtrasCant.Text)).ToString();

                //Cantidad a cargo
                txtCantCargo.Text = (double.Parse(IVACargoMes.Text) + double.Parse(txtOtrasCant.Text)).ToString() ;

                //Parte actualizada

                //recargos


            }




            }

            private void panel3_Paint(object sender, PaintEventArgs e)
            {

            }
        }
    }
