using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtRaio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, altura;
            if (double.TryParse(txtAltura.Text, out altura) && double.TryParse(txtRaio.Text, out raio))
            {
                if (altura < 0 || raio < 0)
                    MessageBox.Show("Valores inválidos");
                else
                {
                    txtResultado.Text = (Math.PI * Math.Pow(raio, 2) * altura).ToString();
                }
            }
            else
                MessageBox.Show("Valores inválidos");
        }
    }
}
