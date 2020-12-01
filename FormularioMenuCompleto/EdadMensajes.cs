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
    public partial class EdadMensajes : Form
    {
        public EdadMensajes()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtEdad.Text);
            if (!(edad >= 15 && edad <= 80))
            {
                MessageBox.Show("INGRESAR UNA EDAD CORRECTA ENTRE 15 Y 80 AÑOS", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdad.Focus();
                return;
            }
            else if (edad >= 15 && edad <= 17)
            {
                lbRespuesta.Text =  this.txtNom.Text + " eres menor de edad ";
            }
            else if (edad >= 18 && edad <= 25)
            {
                lbRespuesta.Text =  this.txtNom.Text + " puedes votar en las elecciones 2021 ";

            }
            else if (edad >= 26 && edad <= 30)
            {
                lbRespuesta.Text =  this.txtNom.Text + " ya debes casarte ";

            }
            else if (edad >= 31 && edad <= 50)
            {
                lbRespuesta.Text =  this.txtNom.Text + " trabaja, duerme y disfruta ";

            }
            else if (edad > 50)
            {
                lbRespuesta.Text = this.txtNom.Text + " ya casi llegas a la tercera edad ";

            }
        }
    }
}
