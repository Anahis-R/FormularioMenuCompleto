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
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //AÑOS
            int edadAnio = DateTime.Today.Year - dtpEdad.Value.Year;
            txtAños.Text = Convert.ToString(edadAnio + " años de edad");
            //DIAS
            int edadDias = (DateTime.Today.Year - dtpEdad.Value.Year) * 365;
            edadDias = edadDias + (DateTime.Today.Month - dtpEdad.Value.Month) * 30;
            edadDias = edadDias + 1;
            edadDias = edadDias + DateTime.Today.Day - dtpEdad.Value.Day;
            txtDias.Text = Convert.ToString(edadDias + " días de edad");
        }
    }
}
