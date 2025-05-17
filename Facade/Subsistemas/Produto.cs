using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada.Subsistemas
{
    internal class Produto
    {
        public string? nome;
        public int quantidade;
        //public string? quantidadeString; // Necessário para conversão?
        public double valorProduto;
        
        public Produto(string name, int quant, double vlr) 
        {
            nome = name;
            quantidade = quant;
            valorProduto = vlr;
        }

        //public void DefinirProduto() // Definir as 3 informações de produto (nome, valor e qtd)
        //{
        //    // Nome produto
        //    Console.WriteLine("Por favor, informe o nome do produto ");
        //    nome = Console.ReadLine(); // Sem tratamento de null

        //    if (string.IsNullOrWhiteSpace(nome))
        //    {
        //        Console.WriteLine("Nome do produto não informado ou inválido.");
        //        // Você pode pedir novamente ou tratar como erro
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Nome informado: {nome}");
        //    }

        //    // Quantidade produto
        //    Console.WriteLine($"\nPor favor, informe a quantidade de \"{nome}\" em estoque, neste momento ");
        //    if (Int32.TryParse(Console.ReadLine(), out quantidade))
        //    {
        //        Console.WriteLine($"Quantidade ({quantidade}) adicionada com sucesso");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Valor inválido! Digite um número inteiro.");
        //    }

        //    // Valor do produto
        //    Console.WriteLine($"\nPor favor, informe o valor de {nome} ");
        //    if (Double.TryParse(Console.ReadLine(), NumberStyles.Any, new CultureInfo("pt-BR"), out valorProduto))
        //    {
        //        Console.WriteLine($"Valor ({valorProduto}) informado com sucesso");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Valor inválido! Informe um valor válido");
        //    }
        //}
    }
}
