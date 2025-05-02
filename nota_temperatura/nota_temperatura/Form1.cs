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
    public partial class frmInicio: Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            frmMedia frmMedia = new frmMedia();
            frmMedia.Show();
        }
    }
}
