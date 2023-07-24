using Strategy;
using Strategy.Model;

namespace Design_Patterns
{
    public class StrategyImposto
    {
        public Orcamento RetornaOrcamentoCalculado(double valorOrcamento, string[] tipoImposto)
        {
            var impostoFactory = new ImpostoFactory();
            return impostoFactory.CriarImposto(tipoImposto, valorOrcamento);
        }
    }
}
