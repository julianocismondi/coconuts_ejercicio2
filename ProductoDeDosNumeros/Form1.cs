using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoDeDosNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void producto()
        {
           int numero1 = Convert.ToInt32(textBox1.Text); //primer valor ingresado por el usuario.

           int numero2 = Convert.ToInt32(textBox2.Text); //segundo valor ingresado por el usuario.

           int producto = 0;

            while(numero2 != 0)   //comprueba si el segundo valor es distinto a cero.
            {
                producto += numero1; //asigna e incrementa el valor de la variable producto con el primer valor ingresado por el usuario.
                numero2 -= 1; //asigna y decrementa en 1 el valor del segundo valor ingresado por el usuario.
            
            }

            textBox3.Text = producto.ToString(); //muestra el resultado en "Resultado".

        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
