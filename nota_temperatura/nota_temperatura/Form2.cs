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
    public partial class frmMedia: Form
    {
        private decimal media1, media2, media3, media4;
        private decimal mediaFinal;

        private void btnSair_Click(object sender, EventArgs e)
        {
            frmMedia.ActiveForm.Close();
            frmInicio frmInicio = new frmInicio();
            frmInicio.Show();
        }

        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            media1 = numMedia1.Value;
            media2 = numMedia2.Value;
            media3 = numMedia3.Value;
            media4 = numMedia4.Value;

            mediaFinal = (media1 + media2 + media3 + media4) / 4;

            if(mediaFinal >= 7)
            {
                lblMediaFinal.Text = $"Aprovado Média: {mediaFinal}";
                lblMediaFinal.ForeColor = Color.Green;
            }
            else if (mediaFinal >= 5)
            {
                lblMediaFinal.Text = $"Recuperação Média: {mediaFinal}";
                lblMediaFinal.ForeColor = Color.Orange;
            }
            else
            {
                lblMediaFinal.Text = $"Reprovado Média: {mediaFinal}";
                lblMediaFinal.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            numMedia1.Value = numMedia2.Value = numMedia3.Value = numMedia4.Value = 0;  
            lblMediaFinal.Text = " ";

        }
    }
}
