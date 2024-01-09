using System;
using System.Windows.Forms;

namespace com.bancodobrasil
{
    public partial class BB : Form
    {
        private double valor1 = 0;
        private double valor2 = 0;
        private string operacao = null;

        public BB()
        {
            InitializeComponent();
        }

        private void AdicionarNumero(string numero)
        {
            textBox1.Text += numero;
        }
        private void BB_Load(object sender, EventArgs e)
        {

        }

        private void RealizarCalculo()
        {
            if (double.TryParse(textBox1.Text, out valor2))
            {
                switch (operacao)
                {
                    case "soma":
                        textBox1.Text = (valor1 + valor2).ToString();
                        break;
                    case "sub":
                        textBox1.Text = (valor1 - valor2).ToString();
                        break;
                    case "mult":
                        textBox1.Text = (valor1 * valor2).ToString();
                        break;
                    case "div":
                        if (valor2 != 0)
                            textBox1.Text = (valor1 / valor2).ToString();
                        else
                            MessageBox.Show("Divisão por zero não permitida.");
                        break;
                    case "exp":
                        textBox1.Text = Math.Pow(valor1, valor2).ToString();
                        break;
                }
            }
        }

        // Eventos dos botões numéricos

        private void button1_Click_1(object sender, EventArgs e) => AdicionarNumero("1");
        private void button2_Click(object sender, EventArgs e) => AdicionarNumero("2");
        private void button3_Click(object sender, EventArgs e) => AdicionarNumero("3");
        private void button4_Click(object sender, EventArgs e) => AdicionarNumero("4");
        private void button5_Click(object sender, EventArgs e) => AdicionarNumero("5");
        private void button6_Click(object sender, EventArgs e) => AdicionarNumero("6");
        private void button7_Click(object sender, EventArgs e) => AdicionarNumero("7");
        private void button8_Click(object sender, EventArgs e) => AdicionarNumero("8");
        private void button9_Click(object sender, EventArgs e) => AdicionarNumero("9");
        private void button10_Click(object sender, EventArgs e) => AdicionarNumero("0");

        // Eventos dos botões de operação

        private void BotaoOperacao(string oper)
        {
            if (double.TryParse(textBox1.Text, out valor1))
            {
                textBox1.Clear();
                operacao = oper;
            }
        }

        private void button11_Click(object sender, EventArgs e) => BotaoOperacao("soma");
        private void button12_Click(object sender, EventArgs e) => BotaoOperacao("sub");
        private void button13_Click(object sender, EventArgs e) => BotaoOperacao("mult");
        private void button14_Click(object sender, EventArgs e) => BotaoOperacao("div");
        private void button18_Click(object sender, EventArgs e) => BotaoOperacao("exp");

        // Evento do botão igual

        private void button15_Click(object sender, EventArgs e) => RealizarCalculo();

        // Outros eventos dos botões

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            valor1 = valor2 = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(double.Parse(textBox1.Text))).ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Pow(double.Parse(textBox1.Text), 2).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = (double.Parse(textBox1.Text) * -1).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / double.Parse(textBox1.Text)).ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sin(double.Parse(textBox1.Text)).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Cos(double.Parse(textBox1.Text)).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Tan(double.Parse(textBox1.Text)).ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            int num = 1;
            for (int i = 1; i <= int.Parse(textBox1.Text); i++)
            {
                num = num * i;
            }

            textBox1.Text = num.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.E.ToString();
        }


        private void button28_Click(object sender, EventArgs e) 
        {
            if(!textBox1.Text.Contains(","))
            {
                AdicionarNumero(",");
            }
            
        }
        

        private void button29_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "soma":

                    textBox1.Text = (valor1 + valor1 * double.Parse(textBox1.Text)/100).ToString();
                    break;
                case "sub":

                    textBox1.Text = (valor1 - valor1 * double.Parse(textBox1.Text) / 100).ToString();
                    break;
                case "mult":

                    textBox1.Text = (valor1 * valor1 * double.Parse(textBox1.Text) / 100).ToString();
                    break;
                case "div":

                    textBox1.Text = (valor1 / valor1 * double.Parse(textBox1.Text) / 100).ToString();
                    break;


            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else
            {
                textBox1.Text = string.Empty; 
            }

        }
    }
}
