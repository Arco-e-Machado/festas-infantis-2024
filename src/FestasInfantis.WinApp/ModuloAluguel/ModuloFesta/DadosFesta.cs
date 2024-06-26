using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel.ModuloFesta
{
    public class DadosFesta : RepositorioBaseEmArquivo<Festa>, IRepositorioFestas
    {
        public DadosFesta(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Festa> ObterRegistros()
        {
            return contexto.Festas;
        }
    }
}
