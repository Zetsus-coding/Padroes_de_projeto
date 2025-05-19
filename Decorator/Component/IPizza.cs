using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Component // COMPONENTE
{
    internal interface IPizza // Representa o component que poderá ser adicionado a outros objetos
    {
        decimal Preco();
        string SaborPizza(); // Métodos de interface são sempre públicos
    }
}
