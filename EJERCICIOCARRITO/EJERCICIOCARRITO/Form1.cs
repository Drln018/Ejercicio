using EJERCICIOCARRITO.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace EJERCICIOCARRITO
{
    public partial class Form1 : Form
    {
        clsAutomovil carrito;
        public Form1()
        {
            InitializeComponent();
        }
        SoundPlayer bocina = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Bocina.wav");
        SoundPlayer sEncender = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Encender.wav");
        SoundPlayer sAcelerar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Acelerar.wav");
        SoundPlayer sFrenar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Frenar.wav");
        SoundPlayer sApagar = new SoundPlayer(@"C:/Users/13237/OneDrive/Desktop/SONIDOS/Apagar.wav");
        private bool primera = false;
        private bool segunda = false;
        private bool tercera = false;

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            carrito = new clsAutomovil("Meches");
            carrito.Color = "blanco";
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            //carrito.encenderMotor();
            //MessageBox.Show("Carro encendido");
            //MessageBox.Show($"Marca {carrito.marca}");
            //MessageBox.Show($"velocida max = {carrito.vel_max}"
            this.sEncender.Play();
            string respuesta = carrito.encenderMotor();
            labelDatos.Text = respuesta;
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            this.sAcelerar.Play();
            labelVelocidad.Text = carrito.Acelerar();
            if (carrito.estaEncendido())
            {
                if (primera)
                {
                    vPrimera();
                }
                else
                {
                    if (segunda)
                    {
                        vSegunda();
                    }
                    else
                    {
                        if (tercera)
                        {
                            vTercera();
                        }
 
                    }
                }
            }

            else
            {
                MessageBox.Show($"Lo lamento el carro{carrito} esta apagado");
            }
        }

        private void buttonFrenar_Click(object sender, EventArgs e)
        {
            this.sFrenar.Play();
            labelVelocidad.Text = carrito.DetenerAuto();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            this.sApagar.Play();
            labelApagar.Text = carrito.apagarMotor();
            labelDatos.Text = "";
            labelVelocidad.Text = "";
        }

        private void buttonBocina_Click(object sender, EventArgs e)
        {
            this.bocina.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            segunda = true;
        }
        public void vSegunda()
        {
            if (carrito.velocidadActual > 35)
            {
                labelVelocidad.Text = "Lo lamento llegaste a la velocidad maxima debes de cambiar a tercera";
            }
            else
            {
                labelVelocidad.Text = $"Vas en segunda a una velocidad de {carrito.velocidadActual } KPH";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            primera = true;
        }

        public void vPrimera()
        {
            labelVelocidad.Text = carrito.Acelerar();
            if (carrito.velocidadActual > 20)
            {
                labelVelocidad.Text = "Lo lamento llegaste a la velocidad maxima debes de cambiar a segunda";
            }
            else
            {
                labelVelocidad.Text = $"Vas en segunda a una velocidad de {carrito.velocidadActual } KPH";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tercera = true;
        }

        public void vTercera()
        {
            if (carrito.velocidadActual > 45)
            {
                labelVelocidad.Text = "Lo lamento llegaste a la velocidad maxima debes de cambiar a cuarta";
            }
            else
            {
                labelVelocidad.Text = $"Vas en segunda a una velocidad de {carrito.velocidadActual } KPH";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReproducir_Click(object sender, EventArgs e)
        {

        }
    }
}
