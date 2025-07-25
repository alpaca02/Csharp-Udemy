using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double distancia, gasolina, consumo;

            Console.Write("Distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine(),CI);
            Console.Write("Combustivel gasto: ");
            gasolina = double.Parse(Console.ReadLine(),CI);
            
            consumo = distancia / gasolina;

            Console.WriteLine("Consumo medio = "+consumo.ToString("F3",CI));
        }
    }
}
