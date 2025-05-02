using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
                tb1.BackColor = Color.Red;
            else
                tb1.BackColor = System.Drawing.SystemColors.Control;
                
            
        }

        private void tb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tb2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tb2.Text.Length + " Caracteres ");
        }
    }
}
