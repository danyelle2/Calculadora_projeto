using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculadora_projeto
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void AddPlay(string number)
        {         
                textBox2.Text = textBox2.Text + number;            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPlay("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPlay("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPlay("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddPlay("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddPlay("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPlay("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddPlay("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddPlay("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AddPlay("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AddPlay("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text = "," ;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch (OperacaoAtual)
            {
               case Operacoes.Adicao:
                Resultado = Valor + Convert.ToDecimal(textBox2.Text);
                break;

                case Operacoes.Subtracao:
                 Resultado = Valor - Convert.ToDecimal(textBox2.Text);
                 break;

                 case
                  Operacoes.Multiplicacao:
                  Resultado = Valor * Convert.ToDecimal(textBox2.Text);
                  break;

                case
                     Operacoes.Divisao:

                    if (textBox2.Text == "0")

                    {
                        textBox2.Text = "Zero não é divisível."; 
                        return;
                    }

                    if (Convert.ToDecimal(textBox2.Text) != 0)

                        Resultado = Valor / Convert.ToDecimal(textBox2.Text);

                    break;
            }

            textBox2.Text = Convert.ToString(Resultado);
        }

               
        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length > 0)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private Operacoes OperacaoAtual { get; set; }
        private decimal Valor { get; set; }
        private decimal Resultado { get; set; }

        private enum Operacoes
        {

            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OperacaoAtual= Operacoes.Divisao;
            Valor = Convert.ToDecimal(textBox2.Text);
            textBox2.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OperacaoAtual=Operacoes.Multiplicacao;
            Valor = Convert.ToDecimal(textBox2.Text);
            textBox2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OperacaoAtual = Operacoes.Subtracao;
            Valor = Convert.ToDecimal(textBox2.Text);
            textBox2.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OperacaoAtual = Operacoes.Adicao;
            Valor = Convert.ToDecimal(textBox2.Text);
            textBox2.Text = "";
        }
    }
}
