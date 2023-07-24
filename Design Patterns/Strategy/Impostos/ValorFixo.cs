using Strategy.Interface;

namespace Strategy.Impostos
{
    public class ValorFixo : IImposto
    {
        public double Calcula(double valorOrcamento)
        {
            return 50.00;
        }
    }
}
