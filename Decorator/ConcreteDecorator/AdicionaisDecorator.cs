using Decorator.Component;
using Decorator.Decorator;

namespace Decorator.ConcreteDecorator
{
    internal class AdicionaisDecorator : PizzaDecorator
    {
        private readonly int cont = 0;
        public AdicionaisDecorator(IPizza pizza, int cont) : base(pizza)
        {
            this.cont = cont;
        }
        public override decimal Preco()
        {
            var preco = base.Preco();
            preco += (3.5m * cont);
            return preco;
        }

        public override string AdicionaisPizza()
        {
            var sabor = base.AdicionaisPizza();
            sabor += $"; Com {cont} adicionais";
            return sabor;
        }
    }
}
