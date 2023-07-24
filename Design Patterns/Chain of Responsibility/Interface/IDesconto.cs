using Strategy.Model;

namespace Chain_of_Responsibility.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}