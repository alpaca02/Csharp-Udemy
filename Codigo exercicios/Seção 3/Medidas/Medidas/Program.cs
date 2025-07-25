﻿using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double a, b, c, quadrado, triangulo, trapezio;

            Console.Write("Digite a medida A: ");
            a = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida B: ");
            b = double.Parse(Console.ReadLine(), CI);
            Console.Write("Digite a medida C: ");
            c = double.Parse(Console.ReadLine(), CI);

            quadrado = Math.Pow(a, 2);
            triangulo = (a * b) / 2.0;
            trapezio = ((a + b) * c) / 2.0;

            Console.WriteLine("AREA DO QUADRADO " + quadrado.ToString("F4"), CI);
            Console.WriteLine("AREA DO TRIANGULO " + triangulo.ToString("F4"), CI);
            Console.WriteLine("AREA DO TRAPEZIO " + trapezio.ToString("F4"), CI);
        }
    }
}