using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbTexto_MouseMove(object sender, MouseEventArgs e)
        {
            lbTexto.BackColor = Color.Cyan;
            lbTexto.Cursor = Cursors.Hand;
        }

        private void lbTexto_MouseLeave(object sender, EventArgs e)
        {
            lbTexto.BackColor = System.Drawing.SystemColors.Control;
            lbTexto.Cursor = Cursors.Arrow;
        }
    }
}
