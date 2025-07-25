using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double x, y,soma;

            Console.Write("Digite o valor de X: ");
            x= double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y:");
            y= double.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("Soma: "+soma);
        }
    }
}