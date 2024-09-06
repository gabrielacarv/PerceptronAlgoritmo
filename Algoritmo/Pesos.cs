using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    public class Pesos
    {
        public double W1 { get; set; }
        public double W2 { get; set; }

        public Pesos(double w1, double w2)
        {
            W1 = w1;
            W2 = w2;
        }

        public Pesos()
        {
            GerarAleatorio();
        }

        private void GerarAleatorio()
        {
            Random random = new Random();

            W1 = random.NextDouble() * 2 - 1;
            W2 = random.NextDouble() * 2 - 1;
        }
    }
}
