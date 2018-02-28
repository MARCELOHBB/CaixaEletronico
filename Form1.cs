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
        private int quantidadeDeContas;

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

            /*Conta contaDoVictor = new ContaCorrente();
            contaDoVictor.Titular = new Cliente();
            quantidadeDeContas++;
            contaDoVictor.Titular.Nome = "Victor";
            contaDoVictor.Numero = 1;
            contaDoVictor.Titular.idade = 19;

            Conta contaDoMario = new ContaCorrente();
            contaDoMario.Titular = new Cliente();
            quantidadeDeContas++;
            contaDoMario.Titular.Nome = "Mario";
            contaDoMario.Numero = 2;
            contaDoMario.Titular.idade = 19;

            this.contas = new Conta[3];
            this.contas[0] = contaDoVictor;
            this.contas[1] = contaDoMario;

            foreach (Conta conta in this.contas)
            {
                comboContas.Items.Add(conta);
                destinoDaTransferencia.Items.Add(conta);
            }*/
            this.contas = new Conta[10];
        }

        public void AdicionaConta(Conta conta)
        {
            if (this.quantidadeDeContas == this.contas.Length)
            {
                Conta[] novo = new Conta[this.contas.Length * 2];
                for (int i = 0; i < this.quantidadeDeContas; i++)
                {
                    novo[i] = this.contas[i];
                }
                this.contas = novo;
            }
            this.contas[this.quantidadeDeContas] = conta;
            this.quantidadeDeContas ++;
            comboContas.Items.Add(conta.Titular.Nome);
        }

        public void RemoveConta(Conta c)
        {
            comboContas.Items.Remove(c.Titular.Nome);
            comboContas.Items.Remove(c);
            int i;
            for (i = 0; i < this.quantidadeDeContas; i++)
            {
                if (this.contas[i] == c)
                {
                    break;
                }
            }
            while (i + 1 <= this.quantidadeDeContas)
            {
                this.contas[i] = this.contas[i + 1];
                i++;
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
            //contaSelecionada.Saca(valorSaque);

            try
            {
                contaSelecionada.Saca(valorSaque);
                MessageBox.Show("Dinheiro Liberado");
            }
            catch (SaldoInsuficienteExcepition exe)
            {
                MessageBox.Show("Saldo insuficiente");
            }
            catch (System.ArgumentException exe)
            {
                MessageBox.Show("Valor do saque inválido.");
            }

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
            Conta c1 = new ContaCorrente();
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

        private void button5_Click(object sender, EventArgs e)
        {
            CadastroDeConta formularioDeCadastro = new CadastroDeConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta conta = this.contas[indiceSelecionado];
            this.RemoveConta(conta);
        }
    }
}