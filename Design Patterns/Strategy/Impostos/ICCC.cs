using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interface;

namespace Strategy.Impostos
{
    public class ICCC : IImposto
    {
        public double Calcula(double valorOrcamento)
        {
            if (valorOrcamento < 1000)
            {
                return 0.05 * valorOrcamento;
            }
            else if (valorOrcamento >= 1000 && valorOrcamento <= 3000)
            {
                return 0.07 * valorOrcamento;
            }
            else
            {
                return 0.08 * valorOrcamento + 30.0;
            }
        }
    }
}
