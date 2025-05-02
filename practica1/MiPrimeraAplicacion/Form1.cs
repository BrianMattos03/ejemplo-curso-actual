using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimeraAplicacion
{
    public partial class MiPrimeraAplicacion: Form
    {
        public MiPrimeraAplicacion()
        {
            InitializeComponent();
        }

        private void MiPrimeraAplicacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void MiPrimeraAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau..");
        }
    }
}
