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

        private void CadastroDeConta_Load(object sender, EventArgs e)
        {

            this.tipoConta.Items.Add("Conta Corrente");
            this.tipoConta.Items.Add("Conta Poupança");
            this.tipoConta.Items.Add("Conta Investimento");
        }

        private void tipoConta_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta novaConta;
            if (tipoConta.Text.Equals("Conta Poupança"))
            {
                novaConta = new ContaPoupanca();
            }
            else if (tipoConta.Text.Equals("Conta Corrente"))
            {
                novaConta = new ContaCorrente();
            }
            else
            {
                novaConta = new ContaInvestimento();
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
