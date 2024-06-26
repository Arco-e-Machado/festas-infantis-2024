using FestasInfantis.WinApp.Compartilhado;


namespace FestasInfantis.WinApp.ModuloCliente
{
    public class DadosCliente : RepositorioBaseEmArquivo<Cliente>, IRepositorioCliente
    {
        public DadosCliente(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Cliente> ObterRegistros()
        {
            return contexto.Clientes;
        }
    }
}