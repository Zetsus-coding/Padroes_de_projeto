﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fachada.Subsistemas;

namespace Fachada.Principal
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
        public void RealizarPedido(double valorPago, int qtdDesejada)  
        {
            //produto.DefinirProduto();
            if(estoque.VerificarEstoque(produto.quantidade, qtdDesejada)) 
            { 
                if(pagamento.ChecarPagamento(produto.valorProduto, valorPago))
                {
                    transporte.Envio(produto.nome);
                }
            }
            Console.WriteLine("\nFinalizando programa devido ao erro");
        }
    }
}
