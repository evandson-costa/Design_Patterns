using Chain_of_Responsibility.Interface;
using Strategy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility.Desconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
