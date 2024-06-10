using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.Compartilhado
{
    public interface IControladorClienteAluguel
    {
        string ToolTipVisualizarAluguel { get; }

        void VisualizarAluguel();
    }
}
