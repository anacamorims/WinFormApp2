using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppAlerts.Forms;

namespace AppAlerts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlerta_Click(object sender, EventArgs e)
        {
            FormAlerts form = new FormAlerts();
            form.ShowDialog();
        }

        private void btnExAlert_Click(object sender, EventArgs e)
        {
            FormExemploComAlertas form = new FormExemploComAlertas();
            form.ShowDialog();
        }

        private void btnExAltRot_Click(object sender, EventArgs e)
        {
            FormExemploAlteracaoDeRotulos form = new FormExemploAlteracaoDeRotulos();
            form.ShowDialog();
        }

        private void btnExCombobox_Click(object sender, EventArgs e)
        {
            FormExemploCombobox form = new FormExemploCombobox();
            form.ShowDialog();
        }
    }
}
