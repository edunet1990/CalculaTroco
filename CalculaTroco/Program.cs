using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaTroco
{
    class Program
    {
        static void Main(string[] args)
        {
            Caixa c = new Caixa();

            Console.Write("Digite o valor da compra: ");
            c.Entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite o valor para pagar: ");
            c.Pagamento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           

            c.Troco = c.CalculaTroco(c.Pagamento);

            Console.WriteLine("O troco é: " + c.Troco.ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("Notas disponíveis para troco: ");
            c.ContaNotas();
            

            Console.ReadLine();
        }
    }
}
