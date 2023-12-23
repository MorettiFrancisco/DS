using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracionForm
{
    public partial class altaCobranza : Form
    {
        public altaCobranza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            efectivo efectivo = new efectivo();
            efectivo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tarjeta tarjeta = new tarjeta();
            tarjeta.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            transferencia transferencia = new transferencia();
            transferencia.Show();
        }
    }
}
