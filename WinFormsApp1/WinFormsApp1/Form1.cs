using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.clases;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ClsAutomobil carrito;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            carrito= new ClsAutomobil("Meches", 150);

            carrito.color = "blanco";
 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            String respuesta = carrito.EncenderMotor();
            labelDatos.Text = respuesta;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito.EstaEncendido())
            {
               
            }
            else
            {
                MessageBox.Show($"Lo lamento el carro {carrito.Marca} esta apagado");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
