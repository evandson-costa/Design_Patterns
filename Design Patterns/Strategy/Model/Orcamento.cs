namespace Strategy.Model
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public double Valor { get; set; }
        public IList<Item> Itens { get; private set; }
    }
}