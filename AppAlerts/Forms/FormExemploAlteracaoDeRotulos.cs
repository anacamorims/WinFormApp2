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
    public partial class FormExemploAlteracaoDeRotulos : Form
    {
        public FormExemploAlteracaoDeRotulos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salarioAtual = 0;
            double reajuste = 0;
            double novoSalario = 0;

            salarioAtual = Convert.ToDouble(textSalarioAtual.Text);
            reajuste = Convert.ToDouble(textPerceReajuste.Text);
            novoSalario = salarioAtual * (1 + reajuste / 100);

            textSalReajustado.Text = novoSalario.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            textSalarioAtual.Clear();
            textPerceReajuste.Clear();
            textSalarioAtual.Select();
            textSalReajustado.Clear();
        }
    }
}
