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
    public partial class resumenISR : Form
    {
        public resumenISR()
        {
            InitializeComponent();
        }


        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases.conexiones.datosCalculoGeneralISR(cbMes.SelectedItem.ToString());
            //Ingresos Efectivamente Cobrados
            txtIngPeriodo.Text = Formularios.calculoGeneral.ingTotPeriodo;

            //Suma de ingresos de meses anteriores
            txtIngAcumulado.Text = Formularios.calculoGeneral.ingAcumulado;

            //Suma de deducciones de meses anteriores
            txtDedAcumuladas.Text = Formularios.calculoGeneral.dedAcumulada;

            //Compras y gastos del periodo
            txtDedPeriodo.Text = Formularios.calculoGeneral.dedTotalPeriodo;

            //Total de ingresos acumulados
            txtTotalIng.Text = (double.Parse(txtIngPeriodo.Text) + double.Parse(txtIngAcumulado.Text)).ToString();

            //Total de deducciones acumuladas
            txtTotalDed.Text = (double.Parse(txtDedPeriodo.Text) + double.Parse(txtDedAcumuladas.Text)).ToString();

            //Base Gravable Provisional
            txtBaseGravable.Text = (double.Parse(txtTotalIng.Text) - double.Parse(txtTotalDed.Text)).ToString();

            //Limite Inferior            
            double[] nuevo = new double[] { };
            string liminf = "", porcelim = "";
            int cuota = 0;
            nuevo = Formularios.calculoGeneral.arreglos[cbMes.SelectedIndex];
            for (int i = 0; double.Parse(txtBaseGravable.Text) >= nuevo[i]; i++)
            {
                liminf = nuevo[i].ToString();
                //Sacar el porcentaje del limite 
                porcelim = Formularios.calculoGeneral.porcentajeenero[i].ToString();
                //Sacar Cuota fija
                cuota = i;
            }
            txtLimiteInf.Text = liminf;

            //Excendete de limite inferior
            txtExedente.Text = (double.Parse(txtBaseGravable.Text) - double.Parse(txtLimiteInf.Text)).ToString();

            //Porcentaje Aplicable
            txtPorcentaje.Text = porcelim;

            //Cuota Fija
            double[] nuevo1 = new double[] { };
            string cuo = "";
            nuevo1 = Formularios.calculoGeneral.arreglos[cbMes.SelectedIndex + 12];
            for (int i = 0; i <= cuota; i++)
            {
                cuo = nuevo1[i].ToString();

            }
            txtCuota.Text = cuo;

            //Impuesto Marginal
            txtMarginal.Text = (double.Parse(txtExedente.Text) * double.Parse(txtPorcentaje.Text)).ToString();

            //ISR PAGADO O A CARGO ART 106
            txtISRCausado.Text = Clases.conexiones.obtener106Dif(cbMes.Items[cbMes.SelectedIndex].ToString())[0];

            //Diferencia
            txtDiferencia.Text = Clases.conexiones.obtener106Dif(cbMes.Items[cbMes.SelectedIndex].ToString())[1];

            //Pago provisional
            if (cbMes.SelectedIndex == 0)
            {
                txtPagoProvisional.Text = "0";

            }
            else
            {
                double total = 0;

                for (int i = 0; i < cbMes.SelectedIndex; i++)
                {
                    total = total + double.Parse(Clases.conexiones.pagoProv()[i]);
                }

                txtPagoProvisional.Text = total.ToString();

            }

            //ISR A CARGO
            MessageBox.Show(Clases.conexiones.pagoProv()[cbMes.SelectedIndex].ToString());
            txtISRCARGO.Text = Clases.conexiones.pagoProv()[cbMes.SelectedIndex];
           
            //ISR retenido por terceros
            double tot = 0;
            switch (cbMes.SelectedIndex)
            {

                case 0:
                    txtISRRetenido.Text = "0";
                    break;
                case 1:
                    for (int i = 0; i < 2; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 2:

                    for (int i = 0; i < 3; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 3:

                    for (int i = 0; i < 4; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 4:

                    for (int i = 0; i < 5; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 5:

                    for (int i = 0; i < 6; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 6:

                    for (int i = 0; i < 7; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 7:

                    for (int i = 0; i < 8; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 8:

                    for (int i = 0; i < 9; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 9:

                    for (int i = 0; i < 10; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 10:

                    for (int i = 0; i < 11; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
                case 11:

                    for (int i = 0; i < 12; i++)
                    {
                        tot = tot + (double.Parse(Clases.conexiones.ISRRet()[i]));
                    }
                    txtISRRetenido.Text = tot.ToString();
                    break;
            }
        }

        private void resumenISR_Load(object sender, EventArgs e)
        {
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.enero);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.febrero);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.marzo);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.abril);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.mayo);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.junio);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.julio);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.agosto);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.septiembre);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.octubre);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.noviembre);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.diciembre);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotaenero);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotafeb);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotamar);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotaabr);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotamay);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotajun);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotajul);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotaago);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotasep);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotaoct);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotanov);
            Formularios.calculoGeneral.arreglos.Add(Formularios.calculoGeneral.cuotadic);

        }
    }
}
