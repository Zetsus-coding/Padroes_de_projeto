using Decorator.Component;

namespace Decorator.ConcreteComponent // 
{

    internal class Pizza : IPizza // COMPONENTE CONCRETO - Implementa da interfaze IPizza
    {

        private string? Sabor { get; set; } // Propriedade

        public Pizza (string sabor) // Construtor
        {
            Sabor = sabor;
        }

        public decimal Preco() // Valor padrão
        {
            var preco = 20;
            return preco;
        }

        public string AdicionaisPizza() // Pizza padrão
        {
            var opcao = $"Pizza {Sabor}" ;
            return opcao;
        }
    }
}

/*
switch (sabor)
{
    case 1:
        pizza = "Pizza 1:  Calabresa";
        break;

    case 2:
        pizza = "Pizza 2: Vegetariana";
        break;

    case 3:
        pizza = "Pizza 3: Marguerita";
        break;

    default:
        pizza = "Pizza padrão: Mussarela";
        break;
}
*/
