using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Subsistemas;
using Fachada.Subsistemas;

namespace Fachada.Facade
{
    internal class Facade
    {
        private Estoque estoque;
        private Pagamento pagamento;
        private Transporte transporte;
        private Produto produto;

        public Facade() 
        { 
            estoque = new();
            pagamento = new();
            transporte = new();
            produto = new("Café", 5, 19.99);
        }

        // 2 informações da compra (v. pago e qtd. desejada)
        public void Sistema(double pagmento, int qtdDesejada)  
        {
            //produto.DefinirProduto();

        }
    }
}
