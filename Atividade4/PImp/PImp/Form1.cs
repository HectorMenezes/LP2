using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PImp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntVeri_Click(object sender, EventArgs e)
        {
            string nome;
            double salBruto;
            int numFilhos;
            string sexo;
            string casado = "Solteiro(a)";

            double aliquotaINSS = 0;
            double descINSS = 0;
            double aliquotaIRPF;
            double descIRPF;
            double salFam;
            double salLiq;
            if(! ( mTxtNomeFunc.Text != String.Empty &&
                Double.TryParse(mTxtSalBruto.Text, out salBruto) &&
                int.TryParse(mTxtNumFilhos.Text, out numFilhos) &&
                (rbF.Checked || rbM.Checked)
                ))
            {
                MessageBox.Show("Entrada(s) inválida(s)");
            }else if(salBruto <= 0)
            {
                MessageBox.Show("O salário bruto precisa ser maior que 0");
            }
            else
            {
                nome = mTxtNomeFunc.Text;
          
                if (cbCasado.Checked)
                    casado = (rbF.Checked? "casada": "casado");

                mTxtDados.Text = "Os descontos do salario " + (rbF.Checked? " da Sra. ": " do Sr. ")+ nome + " que é " + casado + " e que tem " + numFilhos + " filho(s) são:";
                if (salBruto <= 800.47)
                    aliquotaINSS = 7.65;
                else if (salBruto <= 1050)
                    aliquotaINSS = 8.65;
                else if (salBruto <= 1400.77)
                    aliquotaINSS = 9.00;
                else if (salBruto <= 2801.56)
                    aliquotaINSS = 11.00;
                else
                    descINSS = 308.17;
                if(aliquotaINSS != 0)
                {
                    descINSS = salBruto * (aliquotaINSS / 100);
                    mTxtAliqINSS.Text = aliquotaINSS.ToString() + "%";
                }
                else
                {
                    mTxtAliqINSS.Text = "Teto";
                }
                mTxtDescINSS.Text = descINSS.ToString("N2");

                if (salBruto <= 1257.12)
                    aliquotaIRPF = 0;
                else if (salBruto <= 2512.08)
                    aliquotaIRPF = 15.00;
                else
                    aliquotaIRPF = 27.5;
                descIRPF = salBruto * (aliquotaIRPF / 100);
                mTxtAliqIRPF.Text = aliquotaIRPF.ToString() + "%";
                mTxtDescIRPF.Text = descIRPF.ToString("N2");

                if (salBruto <= 435.52)
                    salFam = 22.33 * numFilhos;
                else if (salBruto <= 654.61)
                    salFam = 15.74 * numFilhos;
                else
                    salFam = 0;
                mTxtSalFam.Text = salFam.ToString("N2");

                salLiq = salBruto - descINSS - descIRPF + salFam;
                mTxtSalLiq.Text = salLiq.ToString("N2");

            }

        }

        private void mTxtDados_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtSalLiq_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtSalFam_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtDescIRPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtAliqIRPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtDescINSS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mTxtAliqINSS_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cbCasado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SalFami_Click(object sender, EventArgs e)
        {

        }

        private void DescIRPF_Click(object sender, EventArgs e)
        {

        }

        private void lblDescINSS_Click(object sender, EventArgs e)
        {

        }

        private void lblSalLiq_Click(object sender, EventArgs e)
        {

        }

        private void lblAliqIRPF_Click(object sender, EventArgs e)
        {

        }

        private void lblAliqINSS_Click(object sender, EventArgs e)
        {

        }

        private void lblDados_Click(object sender, EventArgs e)
        {

        }
    }
}
