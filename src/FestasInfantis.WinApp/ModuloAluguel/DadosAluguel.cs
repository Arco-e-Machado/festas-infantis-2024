using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class DadosAluguel : RepositorioBaseEmArquivo<Aluguel>, IRepositorioAluguel
    {
        public DadosAluguel(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Aluguel> ObterRegistros()
        {
            return contexto.Alugueis;
        }
    }
}
