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
    public partial class Control : Form
    {
       
        public Control()
        {
            InitializeComponent();
          
        }
        public static string idCliente, ene16, feb16, mar16, abr16, may16, jun16, jul16, ago16, sep16, oct16, nov16, dic16, tot16,
            ene0, feb0, mar0, abr0,may0, jun0, jul0, ago0, sep0, oct0, nov0, dic0, tot0,
            eneExe, febExe, marExe, abrExe, mayExe, junExe, julExe, agoExe, sepExe, octExe, novExe, dicExe, totExe,
            eneNoo, febNoo, marNoo, abrNoo, mayNoo, junNoo, julNoo, agoNoo, sepNoo, octNoo, novNoo, dicNoo, totNoo,
            eneMes, febMes, marMes, abrMes, mayMes, junMes, julMes, agoMes, sepMes, octMes, novMes, dicMes, totMes,
            eneRISR, febRISR, marRISR, abrRISR, mayRISR, junRISR, julRISR, agoRISR, sepRISR, octRISR, novRISR, dicRISR, totRISR,
            eneRIVA, febRIVA, marRIVA, abrRIVA, mayRIVA, junRIVA, julRIVA, agoRIVA, sepRIVA, octRIVA, novRIVA, dicRIVA, totRIVA,
            dene16, dfeb16, dmar16, dabr16, dmay16, djun16, djul16, dago16, dsep16, doct16, dnov16, ddic16, dtot16,
            dene0, dfeb0, dmar0, dabr0, dmay0, djun0, djul0, dago0, dsep0, doct0, dnov0, ddic0, dtot0,
            deneexe, dfebexe, dmarexe, dabrexe, dmayexe, djunexe, djulexe, dagoexe, dsepexe, doctexe, dnovexe, ddicexe, dtotexe,
            deneNoo, dfebNoo, dmarNoo, dabrNoo, dmayNoo, djunNoo, djulNoo, dagoNoo, dsepNoo, doctNoo, dnovNoo, ddicNoo, dtotNoo,
            deneest, dfebest, dmarest, dabrest, dmayest, djunest, djulest, dagoest, dsepest, doctest, dnovest, ddicest, dtotest,
            denemes, dfebmes, dmarmes, dabrmes, dmaymes, djunmes, djulmes, dagomes, dsepmes, doctmes, dnovmes, ddicmes, dtotmes;

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Control_Load(object sender, EventArgs e)
        {
            
            lblCliente.Text = Formularios.Inicio.cliente;
            Clases.conexiones.obtenerIdcliente(Formularios.Inicio.cliente);
           
           
            
        }

      
        private void cargarForm(Object cForm)
        {
            if (this.Container.Controls.Count > 0)
            {
                this.Container.Controls.RemoveAt(0);
            }
            Form opened = cForm as Form;
            opened.TopLevel = false;
            opened.Dock = DockStyle.Fill;
            this.Container.Controls.Add(opened);
            this.Container.Tag = opened;
            opened.Show();

        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Datos());
        }

        private void btnDeducciones_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Deducciones());
        }

        private void btnIngresos_Click(object sender, EventArgs e)
        {
            cargarForm(new Formularios.Ingresos());
        }
    }
}

