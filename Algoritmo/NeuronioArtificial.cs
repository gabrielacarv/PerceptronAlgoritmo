using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo
{
    public class NeuronioArtificial
    {
        public Pesos pesos { get; private set; }
        public double o {  get; set; }
        public double taxaAprendizado { get; set; }

        public NeuronioArtificial(double ptaxaAprendizado)
        {
            o = 0.0;
            pesos = new Pesos();
            //pesos = new Pesos(0.8, -0.5);
            taxaAprendizado = ptaxaAprendizado;
            this.taxaAprendizado = taxaAprendizado;
        }

        public void Treinar(List<Entradas> listaEntradas)
        {
            foreach (var item in listaEntradas)
            {
                o = item.Entrada1 * pesos.W1 + item.Entrada2 + pesos.W2;
                
                if (FuncaoClassificacao(o) != item.ResultadoEsperado)
                {
                    int erro = CalcularErro(FuncaoClassificacao(o), item.ResultadoEsperado);
                    pesos.W1 = RecalcularNovoPeso(pesos.W1, erro, item.Entrada1);
                    pesos.W2 = RecalcularNovoPeso(pesos.W2, erro, item.Entrada2);
                }
            }
        }
        
        private int FuncaoClassificacao(double o)
        {
            if(o >= 0) return 1; return 0;
        }

        private int CalcularErro(int resultado, int esperado)
        {
            int erro = resultado - esperado;
            return erro;
        }

        private double RecalcularNovoPeso(double w, int erro, double x1)
        {
            double newW = w + taxaAprendizado * erro * x1; 
            return newW;
        }

        public string Peguntar(double x1, double x2)
        {
            double saídaLinear = x1* pesos.W1 + x2 + pesos.W2;
            int previsão = FuncaoClassificacao(saídaLinear);
            return previsão == 1 ? "laranja" : "maçã";
        }
    }
}
