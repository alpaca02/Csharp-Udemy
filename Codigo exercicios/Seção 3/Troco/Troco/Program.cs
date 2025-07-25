using System;
using System.Globalization;

namespace Programa {
    class program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double preco, troco, pagamento;
            int quantidade;

            Console.Write("Preço unitário do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade comprada: ");
            quantidade = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - (preco * quantidade) ;

            Console.WriteLine("Troco: "+troco.ToString("F2"));

            if (troco < 0) {
                Console.WriteLine("Dinheiro insuficiente");
            }
        }
    }
}