using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace EJERCICIOCARRITO.clases
{
    class clsAutomovil
    {
        public int velocidadActual { get;  set; }
        private bool encendido = false;
        private bool apagado = false;

        public string Color { get; set; }
        
        public string Acelerar()
        {
            velocidadActual = velocidadActual + 5;
            return $"Vas a una velocidad de {velocidadActual} KMP";
        }
 
        public bool estaEncendido()
        {
            return encendido;
        }
        public clsAutomovil(string marcaCarro)
        {
     
        }

        public string encenderMotor()
        {
            if (encendido)
            {
                return "El carro ya esta encendido";
            }
            else
            {
                encendido = true;
                velocidadActual = 0;
                return "Listo el carro esta enciendido";
            }
        }
        public string DetenerAuto()
        {
            velocidadActual = 0;
            return $"La velocidad es de {velocidadActual }";
        }
        public string apagarMotor()
        {
            if (apagado)
            {
                return "El carro esta apagado";
            }
            else
            {
                return "El carro ya esta apagado";
            }
        }
    }

}
