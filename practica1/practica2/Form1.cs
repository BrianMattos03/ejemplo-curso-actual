using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento click, Atencion");
            this.BackColor = Color.Blue;

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    MouseEventArgs click = (MouseEventArgs)e;
            
        //    if (click.Button == MouseButtons.Left)
        //        MessageBox.Show("Preciono el boton Izquierdo");
        //    else if (click.Button == MouseButtons.Right)
        //        MessageBox.Show("Preciono el boton Derecho");
        //    else if (click.Button == MouseButtons.Middle)
        //        MessageBox.Show("Preciono el boton del Medio");
                
        //}

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Preciono el boton Izquierdo");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Preciono el boton Derecho");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Preciono el boton del Medio");
        }
    }
}
