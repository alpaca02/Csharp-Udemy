using System;
using System.Globalization;

namespace Programa {
    class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            string nome;
            double valor,pagamento;
            int horas;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Horas trabalhadas: ");
            horas = int.Parse(Console.ReadLine());

            pagamento = valor * horas;

            Console.WriteLine("O pagamento para " + nome + " deve ser " + pagamento.ToString("F2"));
        }
    }
}