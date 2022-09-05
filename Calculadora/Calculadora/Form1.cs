using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calculadora
{

    public partial class Calculadora : Form
    {
        float valor1 = 0, valor2 = 0;
        public Calculadora()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {}
        private void textBox1_TextChanged(object sender, EventArgs e)
        {}

        //BOTAO DOS NUMEROS 0 AO 9
        private void botao_0(object sender, EventArgs e)
        {entrada1.Text += "0";}
        private void botao_1(object sender, EventArgs e)
        {entrada1.Text += "1";}
        private void botao_2(object sender, EventArgs e)
        {entrada1.Text += "2";}
        private void botao_3(object sender, EventArgs e)
        {entrada1.Text += "3";}
        private void botao_4(object sender, EventArgs e)
        {entrada1.Text += "4";}
        private void botao_5(object sender, EventArgs e)
        {entrada1.Text += "5";}
        private void botao_6(object sender, EventArgs e)
        {entrada1.Text += "6";}
        private void botao_7(object sender, EventArgs e)
        {entrada1.Text += "7";}
        private void botao_8(object sender, EventArgs e)
        {entrada1.Text += "8";}
        private void botao_9(object sender, EventArgs e)
        {entrada1.Text += "9";}
        //BOTAO DOS NUMEROS 0 AO 9 

        //BOTOES PARARELOS
        private void botao_ponto(object sender, EventArgs e)
        {entrada1.Text = entrada1.Text + ".";}
        private void botao_deletar(object sender, EventArgs e)
        {
            if (entrada1.Text.Length > 0)
            {entrada1.Text = entrada1.Text.Remove(entrada1.Text.Length - 1);}    
        }
        private void botao_limpar(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            entrada1.Text = "";
            labelopr.Text = null;
            textvalor1.Text = null;
        }
        private void botao_calcular(object sender, EventArgs e)
        {  
           if (valor1 != 0 && entrada1.Text != "")
            {
                switch (labelopr.Text)
                {
                    case "+":
                        valor2 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                        entrada1.Text = Convert.ToString(valor1 + valor2);
                        valor1 = 0;
                        valor2 = 0;
                        textvalor1.Text = null;
                        labelopr.Text = null;
                        break;
                    case "-":
                        valor2 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                        entrada1.Text = Convert.ToString(valor1 - valor2);
                        valor1 = 0;
                        valor2 = 0;
                        textvalor1.Text = null;
                        labelopr.Text = null;
                        break;
                    case "x":
                        valor2 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                        entrada1.Text = Convert.ToString(valor1 * valor2);
                        valor1 = 0;
                        valor2 = 0;
                        textvalor1.Text = null;
                        labelopr.Text = null;
                        break;
                    case "/":
                        valor2 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                        entrada1.Text = Convert.ToString(valor1 / valor2);
                        valor1 = 0;
                        valor2 = 0;
                        textvalor1.Text = null;
                        labelopr.Text = null;
                        break;
                    default:
                        break;
                }
            } 
        }
        //BOTOES PARARELOS

        //BOTOES DE OPERAÇÕES
        private void botao_menos(object sender, EventArgs e)
        {
            labelopr.Text = "-";
            if (entrada1.Text != "")
            {
                valor1 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                textvalor1.Text = entrada1.Text;
                entrada1.Text = "";
                labelopr.Text = "-";
            }     
        }
        private void botao_mais(object sender, EventArgs e)
        {
            labelopr.Text = "+";
            if (entrada1.Text != "") 
            {
                valor1 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                textvalor1.Text = entrada1.Text;
                entrada1.Text = "";
                labelopr.Text = "+";
            }
        }
        private void botao_vezes(object sender, EventArgs e)
        {
            labelopr.Text = "x";
            if (entrada1.Text != "")
            {
                valor1 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                textvalor1.Text = entrada1.Text;
                entrada1.Text = "";
                labelopr.Text = "x";
            }        
        }
        private void botao_dividir(object sender, EventArgs e)
        {
            labelopr.Text = "/";
            if (entrada1.Text != "")
            {
                valor1 = float.Parse(entrada1.Text, CultureInfo.InvariantCulture);
                textvalor1.Text = entrada1.Text;
                entrada1.Text = "";
                labelopr.Text = "/";
            }          
        }
        //BOTOES DE OPERAÇÕES   
    }
}