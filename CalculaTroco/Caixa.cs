using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaTroco
{
    class Caixa
    {
        public double Entrada { get; set; }
        public double Pagamento { get; set; }
        public double Troco { get; set; }
        public double Moedas { get; set; }

        public double CalculaTroco(double pagamento)
        {
            Troco = pagamento - Entrada;

            return Troco;
        }

       public string ContaNotas()
        {
            double contaTroco = Troco;
            
            while (contaTroco >= 5){
                if (contaTroco >= 50)
                {
                    contaTroco -= 50;
                    Console.Write("50, ");

                }else if(contaTroco >= 20)
                {
                    contaTroco -= 20;
                    Console.Write("20, ");
                }
                else if (contaTroco >= 10)
                {
                    contaTroco -= 10;
                    Console.Write("10, ");
                }
                else if (Troco >= 5)
                {
                    contaTroco -= 5;
                    Console.Write("5");

                    Moedas = contaTroco;

                    Console.Write(" e " + this.Moedas + " Centavos");
                }
               
            }

            return "";

        }
        
    }
}
