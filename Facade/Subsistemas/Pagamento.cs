using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada.Subsistemas
{
    internal class Pagamento
    {
        public Pagamento()
        {
        }

        public bool ChecarPagamento(double valorProduto, double pagamento)
        {
            Console.WriteLine("Pagamento sendo processado...");

            if(pagamento < valorProduto)
            {
                Console.WriteLine($"Falha em processar o pagamento: saldo insuficiente - Valor do produto: {valorProduto}; Valor pago: {pagamento}");
                Console.WriteLine($"Ainda faltam: R${Math.Round(valorProduto - pagamento, 2)})");
                return false;
            }
            Console.WriteLine("Pagamento processado com sucesso");
            return true;
        }
    }
}
