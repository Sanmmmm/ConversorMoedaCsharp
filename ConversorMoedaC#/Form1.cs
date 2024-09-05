using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversorMoedaC_
{
    public partial class Form1 : Form
    {
        double dolar = 5.47;
        double euro = 6.54;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox2.Text = "";
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false; 
                radioButton4.Checked = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                double valor = double.Parse(textBox1.Text);
                double resultado;

                resultado = valor / dolar;
                textBox2.Text = Convert.ToString(Math.Round(resultado, 2));
            }
            else MessageBox.Show("Preencha o campo vazio!");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double valor = double.Parse(textBox1.Text);
                double resultado;

                resultado = valor * dolar;
                textBox2.Text = Convert.ToString(Math.Round(resultado, 2));
            }
            else MessageBox.Show("Preencha o campo vazio!");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (textBox1.Text != "")
            {
                double valor = double.Parse(textBox1.Text);
                double resultado;

                resultado = valor / euro;
                textBox2.Text = Convert.ToString(Math.Round(resultado, 2));
            }
            else MessageBox.Show("Preencha o campo vazio!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double valor = double.Parse(textBox1.Text);
                double resultado;

                resultado = valor * euro;
                textBox2.Text = Convert.ToString(Math.Round(resultado, 2));
            }
            else MessageBox.Show("Preencha o campo vazio!");
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
        }
    }
}
