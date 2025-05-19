using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Component;

namespace Decorator.Decorator
{
    internal class PizzaDecorator : IPizza // DECORATOR
    {
        private readonly IPizza _pizza; // * Referência ao component

        public PizzaDecorator(IPizza pizza) // * Referência ao component (injeção da instância do tipo IPizza)
        {
            _pizza = pizza;
        }

        // Utiliza essa referência (^) para sobreescrever os comportamentos;
        // Os concrete decorator são a "extensão" deste decorator e também vão sobreescrever os métodos

        public decimal Preco()
        {
            var preco = _pizza.Preco();
            return preco;
        }

        public string SaborPizza()
        {
            var sabor = _pizza.SaborPizza();
            return sabor;
        }
    }
}
