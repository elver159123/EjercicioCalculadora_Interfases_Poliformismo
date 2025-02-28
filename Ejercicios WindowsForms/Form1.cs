using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form1 : Form
    {
        Matematicas mat;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum2.Text);
            mat = new Matematicas(num1, num2);
            calcularOperacion();
            
            
            
        }

        private void calcularOperacion()
        {
            if (sumar.Checked)
            {
                MessageBox.Show("La suma es: " + mat.suma());
                Result.Text = mat.suma().ToString();
            }
            if (restar.Checked)
            {
                MessageBox.Show("La resta es: " + mat.resta());
                Result.Text = mat.resta().ToString();
            }
            if (multiplicar.Checked)
            {
                MessageBox.Show("La multiplicacion es: " + mat.multiplicacion());
                Result.Text = mat.multiplicacion().ToString();
            }
            if (dividir.Checked)
            {
                MessageBox.Show("La division es: " + mat.division());
                Result.Text = mat.division().ToString();
            }
            if (modulo.Checked)
            {
                MessageBox.Show("el residuo es: " + mat.resto());
                Result.Text = mat.resto().ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.Show(); // Abre la ventana de forma no bloqueante
        }

    }
}
