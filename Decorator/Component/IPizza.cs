namespace Decorator.Component // COMPONENTE
{
    internal interface IPizza // Representa o component que poderá ser adicionado a outros objetos
    {
        decimal Preco();
        string AdicionaisPizza(); // Métodos de interface são sempre públicos
    }
}
