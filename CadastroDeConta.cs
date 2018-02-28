using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CadastroDeConta : Form
    {
        private Form1 aplicacaoPrincipal;

        public CadastroDeConta(Form1 aplicacaoPrincipal)
        {
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta = null;
            if (tipoDeConta.Text == "Poupanca")
            {
                novaConta = new ContaPoupanca();
            }
            else
            {
                novaConta = new ContaCorrente();
            }
           
            Cliente novocliente = new Cliente();
            novaConta.Titular = novocliente;
            novaConta.Titular.Nome = titularConta.Text;
            novaConta.Numero = Convert.ToInt32(numeroDaConta.Text);
            novaConta.Titular.idade = Convert.ToInt32(numeroDaIdade.Text);
            novaConta.Titular.rg = numeroDoRg.Text;
            novaConta.Titular.cpf = numeroDoCpf.Text;
            novaConta.Titular.endereco = Endereço.Text;
            this.aplicacaoPrincipal.AdicionaConta(novaConta);
            MessageBox.Show("conta criada");
        }
    }
}
