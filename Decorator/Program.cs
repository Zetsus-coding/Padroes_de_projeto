using Decorator.Component;
using Decorator.ConcreteComponent;
using Decorator.ConcreteDecorator;


namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizzaBase = new Pizza("Margherita");

            var info = pizzaBase.AdicionaisPizza() + "; Valor: R$" + pizzaBase.Preco();
            IPizza pizzaExtras = pizzaBase;

            Console.WriteLine(info);

            // ---------------------------------- V DECORATOR V -----------------------------------------


            // Massa
            Console.WriteLine("\nDeseja uma massa diferente (R$ 5)? Fina; Grossa; Padrão");
            string? tipoMassa = Console.ReadLine();
            
            if (tipoMassa == "Fina") // Sem tratamento de outras opções
            {
               pizzaExtras = new MassaEspecialDecorator(pizzaExtras, "Fina");
            }
            else if(tipoMassa == "Grossa")
            {
                pizzaExtras = new MassaEspecialDecorator(pizzaExtras, "Grosa");
            }

            // Adicionais
            Console.WriteLine("\nDeseja adicionais (R$ 3.5/adic.)?");
            if(Int32.TryParse(Console.ReadLine(), out int cont)) // "Sem tratamento"
            {
                if (cont > 0) 
                {
                    pizzaExtras = new AdicionaisDecorator(pizzaExtras, cont);
                }
            }

            // Resultado
            Console.WriteLine("Pedido final: " + pizzaExtras.AdicionaisPizza());
            Console.WriteLine("Pedido final: " + pizzaExtras.Preco());

        }
    }
}