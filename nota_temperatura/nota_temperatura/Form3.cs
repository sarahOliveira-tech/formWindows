using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nota_temperatura
{
    public partial class frmTemperatura: Form
    {
        private decimal temperatura, porcentagem, resultado;

        private decimal AcrescimoPorcentagem (decimal temperatura, decimal porcentagem)
        {
            decimal novaTemperatura = 0;

            novaTemperatura = temperatura + (temperatura * porcentagem / 100);

            return novaTemperatura;
        }
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            numPorcentagem.Value = 0;
            txtTemperatura.Text = "";
            txtBoxResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmTemperatura.ActiveForm.Close();
            frmInicio frmInicio = new frmInicio();
        }

        private void lblPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            temperatura = Convert.ToDecimal(txtTemperatura.Text);
            porcentagem = numPorcentagem.Value;
            txtBoxResultado.Text = AcrescimoPorcentagem(temperatura, porcentagem).ToString("N2") + " °C";
        }
    }
}
