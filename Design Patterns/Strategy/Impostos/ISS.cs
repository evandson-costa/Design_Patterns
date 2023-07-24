using Strategy.Interface;

namespace Strategy.Impostos
{
    public class ISS : IImposto
    {
        public double Calcula(double valorOrcamento)
        {
            return valorOrcamento * 0.06;
        }
    }
}
