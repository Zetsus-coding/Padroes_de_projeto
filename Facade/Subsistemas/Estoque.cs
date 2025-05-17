using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada.Subsistemas
{
    internal class Estoque
    {
        public Estoque()
        {
        }

        public bool VerificarEstoque(int qtd, int qtdDesejada) 
        { 
            if(qtdDesejada < qtd)
            {
                Console.WriteLine($"Quantidade informada ({qtdDesejada}) é maior do que estoque disponível do produto ({qtd})");
                return false;
            }
            Console.WriteLine("Quantidade informada está disponível");
            return true;
        }
    }
}
