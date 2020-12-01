using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMenuCompleto
{
    public partial class frmMultiplicar : Form
    {
        public frmMultiplicar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int tabla = int.Parse(txtNumero.Text);
            int re;

            for(int j=1; j<=10; j++)
            {
                re = tabla * j;
                listBox1.Items.Add(tabla+" x "+ j +" = "+ re);
            }
        }
    }
}
