using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interface;

namespace Strategy.Impostos
{
    public class ICMS : IImposto
    {
        public double Calcula(double valorOrcamento)
        {
            return valorOrcamento * 0.1;
        }
    }
}
