using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.Compartilhado
{
    public interface IControladorAluguel
    {
        string ToolTipVisualizarAluguel { get; }
        string ToolTipConcluirAluguel { get; }
        string ToolTipConfigurarDesconto { get; }

        void VisualizarAluguel();
        void ConcluirAluguel();
        void ConfigurarDesconto();
    }
}
