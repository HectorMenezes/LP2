using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace P0030481921028
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int n = 8;
            double[,] m = new double[n, 4];
            double[] mes = new double[n];
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double mesA = 0;
                string texto = Interaction.InputBox("Insira os valores das 4 semanas, do mês " + (i+1) + ", separados por espaço.");
                string[] sValores = texto.Split(' ');
                for (int j = 0; j < 4; j++)
                {
                    if(sValores.Length<4||!double.TryParse(sValores.ElementAt(j), out m[i, j]))
                    {
                        MessageBox.Show("Valores inválidos, inseira novamente!");
                        i--;
                        break;
                    }
                    else
                    {
                        mesA += m[i, j];
                    }
                }
                mes[i] = mesA;
                total += mesA;
            }
            lbxDados.BeginUpdate();
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < 4; j++)
                {
                     lbxDados.Items.Add("Total do mês: " + (i + 1) + " semana: " + (j+1) + " R$" + m[i,j]);
                     
                }
                lbxDados.Items.Add(">>> Total mês: " + mes[i] );
                lbxDados.Items.Add("---------------------");
            }
            lbxDados.Items.Add("Total Geral: R$" + total);
            
            lbxDados.EndUpdate();
        }
    }
}
