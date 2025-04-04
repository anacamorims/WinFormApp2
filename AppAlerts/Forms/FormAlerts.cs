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
    public partial class FormAlerts : Form
    {
        public FormAlerts()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é uma mensagem de Informação", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //MessageBoc.Show("Texto da Mensagem", "Título da Mensagem")
        }

        private void btnAtencao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é uma mensagem de atenção", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é uma mensagem de erro", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPergunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta é uma pergunta?", "PERGUNTA", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Gosta de Futebol", "ADS/JIPA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            MessageBox.Show("Resposta: "+resposta.ToString(), "ADS/JIPA", MessageBoxButtons.YesNo, MessageBoxIcon.Information );

            resposta = MessageBox.Show("Deseja fechar o programa?", "ADS/JIPA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
