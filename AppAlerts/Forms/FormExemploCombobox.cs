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
    public partial class FormExemploCombobox : Form
    {
        public FormExemploCombobox()
        {
            InitializeComponent();
        }

        private void cbTipoDeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecionado = cbTipoDeCliente.SelectedItem.ToString();
        }

        private void FormExemploCombobox_Load(object sender, EventArgs e)
        {
            cbTipoDeCliente.Items.Add("Cliente Certinho");
            cbTipoDeCliente.Items.Add("Cliente Caloteiro");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal valorCompra = 0;
            decimal desconto = 0;
            decimal valorComDesconto = 0;

            

        }
    }
}
    