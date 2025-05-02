using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class DatosPersonales: Form
    {
        public DatosPersonales()
        {
            InitializeComponent();
        }

        private void txbEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txbApellido.Text == "")
                txbApellido.BackColor = Color.Red;
            else
                txbApellido.BackColor = Color.White;
            if (txbNombre.Text == "")
                txbNombre.BackColor = Color.Red;
            else
                txbNombre.BackColor = Color.White;
            if (txbEdad.Text == "")
                txbEdad.BackColor = Color.Red;
            else
                txbEdad.BackColor = Color.White;
            if (txbDireccion.Text == "")
                txbDireccion.BackColor = Color.Red;
            else
                txbDireccion.BackColor = Color.White;

            int con = 0;
            if (txbApellido.BackColor != Color.Red)
                con++;
            if (txbNombre.BackColor != Color.Red)
                con++;
            if (txbEdad.BackColor != Color.Red)
                con++;
            if (txbDireccion.BackColor != Color.Red)
                con++;

            if(con == 4)
                txbResultado.Text = "Apellido y Nombre: " + txbApellido.Text + ' ' + txbNombre.Text + Environment.NewLine + "Edad: " + txbEdad.Text + Environment.NewLine + "Direccion: " + txbDireccion.Text;
                con = 0;


        }
    }
}
