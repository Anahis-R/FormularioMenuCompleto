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
    public partial class Primo : Form
    {
        public Primo()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtNumero.Text.Length == 0)
            {
                MessageBox.Show("DEBES INGRESAR UN NUMERO");
                this.txtNumero.Focus();
                return;
            }
            int numero = int.Parse(this.txtNumero.Text);
            primo(numero);
        }
        void primo(int numero)
        {
            int num = 0;
            for (int i = 1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                    num = num + 1;
            }
            if (num > 2)
                this.lbRespuesta.Text = "  no es Primo";
            else
                this.lbRespuesta.Text = "  es Primo";
        }
    }
}
