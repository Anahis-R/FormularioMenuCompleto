using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularioMenu
{
    public partial class BinarioDecimal : Form
    {
        public BinarioDecimal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double re = 0;
            double suma = 0;
            if (chk8.Checked == true)
            {
                re = Math.Pow(2, 0);
                suma = suma + re;
            }
            if (chk7.Checked == true)
            {
                re = Math.Pow(2, 1);
                suma = suma + re;
            }
            if (chk6.Checked == true)
            {
                re = Math.Pow(2, 2);
                suma = suma + re;
            }
            if (chk5.Checked == true)
            {
                re = Math.Pow(2, 3);
                suma = suma + re;
            }
            if (chk4.Checked == true)
            {
                re = Math.Pow(2, 4);
                suma = suma + re;
            }
            if (chk3.Checked == true)
            {
                re = Math.Pow(2, 5);
                suma = suma + re;
            }
            if (chk2.Checked == true)
            {
                re = Math.Pow(2, 6);
                suma = suma + re;
            }
            if (chk1.Checked == true)
            {
                re = Math.Pow(2, 7);
                suma = suma + re;
            }
            txtNumero.Text = suma.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
