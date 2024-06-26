using FestasInfantis.WinApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class DadosTema : RepositorioBaseEmArquivo<Tema>, IRepositorioTema
    {
        public DadosTema(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Tema> ObterRegistros()
        {
            return contexto.Temas;
        }
    }
}
