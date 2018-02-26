using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }

        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }

    }
}
