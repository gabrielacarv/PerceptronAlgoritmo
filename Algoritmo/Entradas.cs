using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    public class Entradas
    {
        public Entradas() { }

        public double Entrada1 { get; set; }
        public double Entrada2 { get; set; }
        public int ResultadoEsperado { get; set; }

        public Entradas(double entrada1, double entrada2, int resultadoEsperado)
        {
            Entrada1 = entrada1;
            Entrada2 = entrada2;
            ResultadoEsperado = resultadoEsperado;
        }
    }
}
