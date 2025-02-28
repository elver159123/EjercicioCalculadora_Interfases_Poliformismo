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
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = label1.Text;
            int edad = int.Parse(IngEdad.Text);

            Pclss p = new Pclss(nombre, edad);

            Crud crud = new Crud();

            crud.agregarObjeto(p);

            MessageBox.Show("Registro exitoso");
        }

        private void btnMostrar_click(object sender, EventArgs e)
        {
            Crud c= new Crud();

            foreach(var p in c.lista)
            {
                MessageBox.Show(p.nombre);
            }
        }
    }
}
