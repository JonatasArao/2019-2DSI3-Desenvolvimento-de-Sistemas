using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            resultado = valor1 + valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            resultado = valor1 - valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            resultado = valor1 * valor2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;
            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);
            resultado = valor1 / valor2;
            txtResultado.Text = resultado.ToString();
        }
    }
}
