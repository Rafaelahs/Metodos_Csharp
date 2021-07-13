using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            //matematica calculadora = new matematica();
            //// caixatex.Text = calculadora.adicao(10, 20).ToString();
            //int resultado = calculadora.multiplicacao(2, 5);
            //caixatex.Text = resultado.ToString();

            matematica calcula = new matematica();
            int resultado = calcula.operacoes(2, 3, "adicao");
            caixatex.Text = resultado.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
