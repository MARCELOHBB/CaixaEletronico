namespace CaixaEletronico
{
    class Cliente
    {
        public string Nome { get; set; }
        public string rg;
        public string cpf;
        public string endereco;
        public int idade;
        public bool EEmancipado { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public bool PodeAbrirContaSozinho
        {
            get
            {
                var maiorDeIdade = this.EhMaiorDeIdade();
                var emancipado = this.EEmancipado;
                var possuiCPF = !string.IsNullOrEmpty(this.cpf);
                return (maiorDeIdade || emancipado) && possuiCPF;
            }
        }
    }
}