using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fachada.Subsistemas
{
    internal class Transporte
    {
        public void Envio(string produto)
        {
            Console.WriteLine($"Processo de envio do produto ({produto}) foi iniciado, aguarde a um email com mais detalhes");
        }
    }
}
