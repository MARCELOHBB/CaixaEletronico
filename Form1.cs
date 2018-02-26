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
    public partial class Form1 : Form
    {
        //Conta conta;
        Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*this.conta = new ContaCorrente();
            // this.conta = new ContaPoupanca(); TESTE PARA CONTA POUPANÇA
            this.conta.Titular = new Cliente();

            this.conta.Titular.Nome = "Victor";
            this.conta.Numero = 1;
            this.conta.Deposita(200.0);
            

            this.MostraConta();*/

            Conta contaDoVictor = new Conta();
            contaDoVictor.Titular = new Cliente();
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Numero = 1;
            contaDoVictor.Titular.idade = 19;

            Conta contaDoMario = new Conta();
            contaDoMario.Titular = new Cliente();
            contaDoMario.Titular.Nome = "Mario";
            contaDoMario.Numero = 2;
            contaDoMario.Titular.idade = 19;

            this.contas = new Conta[2];
            this.contas[0] = contaDoVictor;
            this.contas[1] = contaDoMario;

            foreach (Conta conta in this.contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
                destinoDaTransferencia.Items.Add(conta.Titular.Nome);
            }

        }

        private Conta BuscaContaSelecionada()
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private Conta BuscaContaSelecionadaTranfere()
        {
            int indiceSelecionado = destinoDaTransferencia.SelectedIndex;
            return this.contas[indiceSelecionado];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito = Convert.ToDouble(textoDoValorDoDeposito);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Deposita(valorDeposito);

            this.MostraConta(contaSelecionada);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque = Convert.ToDouble(textoDoValorDoSaque);
            Conta contaSelecionada = this.BuscaContaSelecionada();
            contaSelecionada.Saca(valorSaque);

            this.MostraConta(contaSelecionada);
        }

        private void MostraConta(Conta conta)
        {
            textoTitular.Text = conta.Titular.Nome;
            textoSaldo.Text = Convert.ToString(conta.Saldo);
            textoNumero.Text = Convert.ToString(conta.Numero);
        }

        private void textoTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Conta c1 = new Conta();
            c1.Deposita(200.0);
            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(125.0);
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);

            MessageBox.Show("valor total: " + t.ValorTotal);
        }

        public void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Conta contaSelecionada = BuscaContaSelecionada();

            this.MostraConta(contaSelecionada);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Conta contaSelecionada = this.BuscaContaSelecionada();
            int indiceSelecionado = destinoDaTransferencia.SelectedIndex;
            Conta contaRecebe = this.contas[indiceSelecionado];
            string textoDoValorTransfere = textoValor.Text;
            double valorTransfere = Convert.ToDouble(textoDoValorTransfere);

            contaSelecionada.Transfere(valorTransfere, contaRecebe);

            this.MostraConta(contaSelecionada);
        }
    }
}