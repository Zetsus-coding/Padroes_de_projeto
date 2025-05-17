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

        public bool ChecarPagamento(double pagamento, int valorProduto)
        {
            Console.WriteLine("Pagamento sendo processado...");

            if(pagamento < valorProduto)
            {
                Console.WriteLine($"Falha em processar o pagamento: saldo insuficiente - Valor do produto: {valorProduto}; Valor pago: {pagamento}");
                Console.WriteLine($"Ainda faltam: R${pagamento - valorProduto}");
                return false;
            }
            Console.WriteLine("Pagamento processado com sucesso");
            Console.WriteLine($"Troco: {valorProduto - pagamento}");
            return true;
        }
    }
}
