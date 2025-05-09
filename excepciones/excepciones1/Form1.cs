using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excepciones1
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Porfavor cargar solo números...");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por Cero.");
            }
            finally
            {

            }
            
            
            
            
        }

        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(tbxN1.Text);
                b = int.Parse(tbxN2.Text);
                r = a / b;
                return r;
            }   
            catch (Exception ex)
            {
                //guardar registro de error en un archivo
                throw ex;
            }
        }
    }
}
