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

    public partial class Tablas_yTarifas : Form
    {
        public Tablas_yTarifas()
        {
            InitializeComponent();
        }
        public static Control eti = new Control();
        public static Tablas_yTarifas tb = new Tablas_yTarifas();
       /* public  void limite(double pBaseGrab)
        {
            /*  foreach (Label lbl in tableLayoutPanel2.Controls)
              {
                  int i = 1;
                  if (lbl is Label)
                  {
                      ((Label)lbl).Name = "inf" +i;
                      i++;
                  }
              }
            if (cbMes.SelectedIndex.Equals(0))
            {
                foreach (Label lbl in tableLayoutPanel2.Controls)
                {
                    if (lbl is Label)
                    {
                        for (int x = 1; x < 12; x++)
                        {
                            if (lbl.Name.Equals("inf" + x))
                            {
                                double o;
                                o = double.Parse(lbl.Text);
                                if (pBaseGrab > o)
                                {
                                    {
                                        Formularios.calculoGeneral.limiteInferior = o.ToString();
                                        
                                        x--;
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }*/

            private void Tablas_yTarifas_Load(object sender, EventArgs e)
            {
            cbMes.SelectedIndex = 0;

            }



            private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
            {

                tabControl1.SelectedIndex = cbMes.SelectedIndex;


            }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }
    }


    }

