using Strategy.Impostos;
using Strategy.Interface;
using Strategy.Model;

namespace Strategy
{
    public class ImpostoFactory
    {
        public Orcamento CriarImposto(string[] tipoImposto, double valorOrcamento)
        {
            var orcamento = new Orcamento(valorOrcamento);
            var calculador = new CalculadorDeImpostos();

            foreach (var itemImposto in tipoImposto)
            {
                IImposto imposto = itemImposto switch
                {
                    "ICCC" => new ICCC(),
                    "ICMS" => new ICMS(),
                    "ISS" => new ISS(),
                    "FIXO" => new ValorFixo(),
                    _ => throw new ArgumentException("Tipo de imposto inválido."),
                };
               orcamento.Valor += calculador.RealizaCalculo(valorOrcamento, imposto);
            }

            return orcamento;
        }
    }
}
