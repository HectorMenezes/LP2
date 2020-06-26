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
namespace Aula9
{
    public partial class NomesFrm : Form
    {
        public NomesFrm()
        {
            InitializeComponent();
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            int n = 8;
            string[] listaDeNomes = new string[n];
            int[] numeroDeCaractes = new int[n];
            for (int i = 0; i < n; i++)
            {
                listaDeNomes[i] = Interaction.InputBox("Insira o nome " + (i + 1), "Digitação de dados");
                string nomeSemEspaco = "";
                foreach (char x in listaDeNomes[i])
                {
                    if (!Char.IsWhiteSpace(x))
                        nomeSemEspaco += x;
                }
                int num = 0;
                foreach (char x in nomeSemEspaco)
                {
                    num++;
                }
                numeroDeCaractes[i] = num;
            }
            lbxNomes.BeginUpdate();
            for (int i = 0; i < n; i++)
            {
                string mensagem = "";

                mensagem += "O nome " + listaDeNomes[i] + " tem " + numeroDeCaractes[i] + " caracteres\n";
                lbxNomes.Items.Add(mensagem);
            }
            lbxNomes.EndUpdate();
        }
    }
}
