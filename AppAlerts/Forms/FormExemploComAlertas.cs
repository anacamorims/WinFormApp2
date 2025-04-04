using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlerts.Forms
{
    public partial class FormExemploComAlertas : Form
    {
        public FormExemploComAlertas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Valor1 = 0;
            double Valor2 = 0;
            double Resultado = 0;

            Valor1 = Convert.ToDouble(txtValor1.Text);
            Valor2 = Convert.ToDouble(txtValor2.Text);
            Resultado = Valor1 / Valor2; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Select();
        }
    }
}
