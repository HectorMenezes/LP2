using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace Aula9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string valor = "";
            for (int x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado: " + (x + 1), "Entrada de dados");
                if(int.TryParse(valor, out vetor[x])){
                    auxiliar = vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número inválido");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            double[] qtd = new double[10];
            double[] precos = new double[10];
            string qtdA = "";
            string precoA = "";
            double faturamento = 0;
            for (int i = 0; i < 10; i++)
            {
                qtd[i] = -1;
                precos[i] = -1;
                qtdA = Interaction.InputBox("Digite a quantidade de mercadoria vendida: ", "Entrada de dados");
                if(!double.TryParse(qtdA, out qtd[i]))
                {
                    MessageBox.Show("Valor inválido");
                    i--;
                }
                else
                {
                    while (precos[i] < 0)
                    {
                        precoA = Interaction.InputBox("Digite o preço da mercadoria vendida: ", "Entrada de dados");
                        if (!double.TryParse(precoA, out precos[i]))
                        {
                            MessageBox.Show("Valor inválido");
                            precos[i] = -1;
                        }
                    }
                    faturamento += qtd[i] * precos[i];

                }
            }
            MessageBox.Show("O faturamento foi de: " + faturamento);
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string auxiliar = "";
            string valor = "";
            for (int x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite o dado da posição " + (x + 1), "Digitação de dados");
                if (!int.TryParse(valor, out vetor[x]))
                {
                    MessageBox.Show("Valor inválido");
                    x--;

                }
            }
            Array.Reverse(vetor);
            for (int x = 0; x < 20; x++)
            {
                auxiliar += vetor[x] + "\n";
            }
            MessageBox.Show(auxiliar);
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0; 
            Int32 N = Alunos.Length; 
            for (I = 0; I < N - 1; I++) 
                Total += Alunos[I].Length;
            MessageBox.Show(Total.ToString());
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            ArrayList l = new ArrayList();
            l.Add("Ana");
            l.Add("André");
            l.Add("Débora");
            l.Add("Fátima");
            l.Add("João");
            l.Add("Janete");
            l.Add("Otávio");
            l.Add("Marcelo");
            l.Add("Thais");


            l.Remove("Otávio");
            string lista = "";
            foreach (string x in l)
            {
                lista += x + "\n";
            }
            MessageBox.Show(lista);
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            double[,] matriz = new double[20, 3];
            double[] medias = new double[20];
            int i, j;
            for (i = 0; i < 20; i++)
                medias[i] = 0;
            
            
            for ( i = 0; i< 20; i++)
            {
                string notas = Interaction.InputBox("Digite as 3 notas do aluno " + (i + 1) + "sepadas por espaço", "Digitação de dados");
                String[] matrizNotas = notas.Split(' ');
                
                for( j = 0; j<3; j++)
                {
                    if (!Double.TryParse(matrizNotas[j], out matriz[i, j]))
                    {
                        MessageBox.Show("Números inválidos, insira todos os 3 novamente.");
                        i--;
                        break;
                    }
                    else
                        medias[i]+=matriz[i, j]/3;
                }
                
            }
            string mensagem = "";
            for(i = 0; i<20; i++)
            {
                mensagem += "Aluno " + (i + 1) + ": média: " + medias[i] + "\n";
            }
            MessageBox.Show(mensagem);
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            NomesFrm form = new NomesFrm();
            form.Show();
           
         
        }
    }  
}
