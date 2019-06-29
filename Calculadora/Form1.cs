using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        private String numero1="";
        private String numero2="";
        private String operacao="";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button btnNumero = sender as Button;
            String numeroClicado = btnNumero.Text;

            txtBox.Text += numeroClicado;

        }

        private void botaoOperacaoEvento(object sender, EventArgs e)
        {
            String num1 = txtBox.Text;

            //Se nao houver numero no display encerra o metodo
            if (num1.Equals("")) return;

            //Se tem, guarda o numero na variavel numero1 e a operacao
            this.numero1 = num1;

            Button botaoOperacao = sender as Button;
            this.operacao = botaoOperacao.Text;

            txtBox.Text = "";
        }

        private void botaoLimparAcao(object sender, EventArgs e)
        {
            txtBox.Text = "";
        }

        private void botaoIgualAcao(object sender, EventArgs e)
        {
            //Se nao houver numero1, encerra o metodo
            if (this.numero1.Equals("")) return;

            //Se tiver numero1 mas nao tiver numero2, exibe o numero1 e encerra
            this.numero2 = txtBox.Text;
            if (this.numero2.Equals(""))
            {
                txtBox.Text = this.numero1;
                return;
            }

            double resultado=0;

            switch (this.operacao)
            {
                case "+":
                    resultado = Convert.ToDouble(numero1) + Convert.ToDouble(numero2);
                    break;

                case "-":
                    resultado = Convert.ToDouble(numero1) - Convert.ToDouble(numero2);
                    break;

                case "x":
                    resultado = Convert.ToDouble(numero1) * Convert.ToDouble(numero2);
                    break;

                case "/":
                    resultado = Convert.ToDouble(numero1) / Convert.ToDouble(numero2);
                    break;
            }

            txtBox.Text = resultado + "";
        }
    }
}
