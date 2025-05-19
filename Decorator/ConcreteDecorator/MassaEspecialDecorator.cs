using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    internal class MassaEspecialDecorator : PizzaDecorator
    {
        public readonly string tipoMassa;

        public MassaEspecialDecorator(IPizza pizza, string massa) : base(pizza)
        {
            
            tipoMassa = massa;
        }

        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += 5;
            return preco;
        }

        public override string AdicionaisPizza()
        {
            var sabor = base.AdicionaisPizza();
            sabor += $"; Massa especial ({tipoMassa})";
            return sabor;
        }
    }
}
