using System;
using Fachada.Principal;

namespace Fachada
{
    class Program
    {
        static void Main(string[] args)
        {

            Facade fachada = new();
            fachada.Sistema(18, 5); // Café, 5, 19.99
        }
    }
}