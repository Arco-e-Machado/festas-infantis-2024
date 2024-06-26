using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class DadosItens : RepositorioBaseEmArquivo<Item>, IRepositorioItem
    {
        public DadosItens(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Item> ObterRegistros()
        {
            return contexto.Itens;
        }
    }
}

