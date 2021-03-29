using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1.clases
{
    class ClsAutomobil 
    {
        public string Marca { get; }
        public int vel_max { get; set; }
        private int velocidadActual { get; set;}

        private bool encendido = false;


        public string color { get; set; }

        public string Acelerar()
        {
            velocidadActual = velocidadActual + 10;
            if (velocidadActual > vel_max)
            {
                return "Lo lamento, llegastes a la velocidad maxima";
            }
            else
            {
                return $"vas a {velocidadActual} KPH";
            }
        }


        public bool EstaEncendido()
        {
            return encendido;
        }


        public ClsAutomobil(string marcaCarro, int velocidadMx)
        {
            this.Marca = marcaCarro;
            this.vel_max = velocidadMx;
        }

        public string EncenderMotor()
        {
            if (encendido)
            {
                return "El Carro ya esta Encendido";
            }else
            {
                encendido = true;
                velocidadActual = 0;
                return "Listo Carro encendido!!!";
            }


        }
    }
}
