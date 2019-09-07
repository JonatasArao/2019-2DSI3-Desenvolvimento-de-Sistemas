using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Real
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        bool virgulaAtiva = false, somaAtiva = false, subtraiAtiva = false, multiplicaAtiva = false,
            divideAtiva = false, opostoAtiva = false;
        double valor1, valor2, resultado;
        

        private void btn0_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "6";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            somaAtiva = true;
            virgulaAtiva = false;
            opostoAtiva = false;
            valor1 = double.Parse(txtTela.Text);
            txtTela.Clear();
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            subtraiAtiva = true;
            virgulaAtiva = false;
            opostoAtiva = false;
            valor1 = double.Parse(txtTela.Text);
            txtTela.Clear();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            multiplicaAtiva = true;
            virgulaAtiva = false;
            opostoAtiva = false;
            valor1 = double.Parse(txtTela.Text);
            txtTela.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            divideAtiva = true;
            virgulaAtiva = false;
            opostoAtiva = false;
            valor1 = double.Parse(txtTela.Text);
            txtTela.Clear();
        }

        private void btnSen_Click(object sender, EventArgs e)
        {
            virgulaAtiva = false;
            opostoAtiva = false;
            txtTela.Text = Math.Sin(double.Parse(txtTela.Text) * (Math.PI / 180)).ToString();
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            virgulaAtiva = false;
            opostoAtiva = false;
            txtTela.Text = Math.Cos(double.Parse(txtTela.Text) * (Math.PI / 180)).ToString();
        }

        private void btnTg_Click(object sender, EventArgs e)
        {
            virgulaAtiva = false;
            opostoAtiva = false;
            txtTela.Text = Math.Tan(double.Parse(txtTela.Text) * (Math.PI / 180)).ToString();
        }

        private void btnOposto_Click(object sender, EventArgs e)
        {
            if (!opostoAtiva && double.Parse(txtTela.Text) > 0)
            {
                txtTela.Text = "-" + txtTela.Text;
                opostoAtiva = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(txtTela.Text);
            virgulaAtiva = false;
            opostoAtiva = false;
            if (somaAtiva)
            {
                resultado = valor1 + valor2;
                txtTela.Text = resultado.ToString();
                somaAtiva = false;
            }
            if (subtraiAtiva)
            {
                resultado = valor1 - valor2;
                txtTela.Text = resultado.ToString();
                subtraiAtiva = false;
            }
            if (multiplicaAtiva)
            {
                resultado = valor1 * valor2;
                txtTela.Text = resultado.ToString();
                multiplicaAtiva = false;
            }
            if (divideAtiva)
            {
                resultado = valor1 / valor2;
                txtTela.Text = resultado.ToString();
                divideAtiva = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTela.Text = txtTela.Text + "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(virgulaAtiva == false)
            {
                if (txtTela.Text.Length == 0)
                {
                    txtTela.Text = txtTela.Text = "0,";
                }
                else
                {
                    txtTela.Text = txtTela.Text + ",";
                }
                virgulaAtiva = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
            virgulaAtiva = false;
            somaAtiva = false;
            subtraiAtiva = false;
            multiplicaAtiva = false;
            divideAtiva = false;
            opostoAtiva = false;
        }
    }
}
