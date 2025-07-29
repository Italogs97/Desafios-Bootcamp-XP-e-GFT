namespace DesafioEstacionamento
{
    public abstract class EstacionamentoBase
    {
        protected decimal precoInicial;
        protected decimal precoPorHora;

        protected EstacionamentoBase(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public abstract void AdicionarVeiculo();
        public abstract void RemoverVeiculo();
        public abstract void EditarVeiculo();
        public abstract void ListarVeiculos();
    }
}