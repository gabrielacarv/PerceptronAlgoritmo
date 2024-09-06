using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NeuronioArtificial neuronio = new NeuronioArtificial(0.5);

            List<Entradas> lista = new List<Entradas>
            {
                new Entradas { Entrada1 = 0.8, Entrada2 = 0.7, ResultadoEsperado = 1 },
                new Entradas { Entrada1 = -0.6, Entrada2 = 0.3, ResultadoEsperado = 0 },
                new Entradas { Entrada1 = -0.1, Entrada2 = -0.8, ResultadoEsperado = 0 },
                new Entradas { Entrada1 = 0.8, Entrada2 = -0.45, ResultadoEsperado = 1 }
            };

            neuronio.Treinar(lista);

            List<Entradas> novosCasos = new List<Entradas>
            {
                new Entradas { Entrada1 = 0.5, Entrada2 = 0.4 },
                new Entradas { Entrada1 = -0.3, Entrada2 = 0.2 },
                new Entradas { Entrada1 = 0.9, Entrada2 = -0.2 },
                new Entradas { Entrada1 = 0.1, Entrada2 = -0.9 },
                new Entradas { Entrada1 = -0.4, Entrada2 = 0.7 }
            };


            Console.WriteLine("==================================== Os 5 novos casos para testar ===================================");
            Console.WriteLine();
            foreach (var caso in novosCasos)
            {
                string resultado = neuronio.Peguntar(caso.Entrada1, caso.Entrada2);
                Console.WriteLine($"                        Entrada 1: {caso.Entrada1,4:F1} | Entrada 2: {caso.Entrada2,4:F1} -> Resultado: {resultado,6:F1}");
            }
            Console.WriteLine();
            Console.WriteLine("======================================================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Digite os parametros de entrada:");

            double [] X = new double [2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"Entrada {i + 1}: ");
                string input = Console.ReadLine().Replace(',', '.');
                if (double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                {
                    X[i] = valor;
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Tente novamente.");
                    i--;
                }
            }

            Console.WriteLine();
            string resultado2 = neuronio.Peguntar(X[0], X[1]);
            Console.WriteLine($"Entrada 1: {X[0],4:F1} | Entrada 2: {X[1],4:F1} -> Resultado: {resultado2,6:F1}");

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
