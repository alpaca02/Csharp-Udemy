using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int tempo, horas, minutos, segundos, resto;

            Console.Write("Digite a duração em segundos: ");
            tempo = int.Parse(Console.ReadLine());

            horas = tempo / 3600;
            resto = tempo % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}