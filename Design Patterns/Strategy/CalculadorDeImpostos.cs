using Strategy.Interface;

namespace Strategy
{
    public class CalculadorDeImpostos
    {
        public double RealizaCalculo(double valorOrcamento, IImposto imposto)
        {   
            return imposto.Calcula(valorOrcamento); 
        }
    }
}
