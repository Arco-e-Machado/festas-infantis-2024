using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel.ModuloPagamento
{
    public class ConfiguracaoPagamento
    {
        public decimal ValorEntrada { get; set; }
        public decimal ValorTema { get; set; }
        public decimal ValorComDesconto { get; set; }
        public decimal ValorPendente { get; set; }
        public decimal ValorPercentualCliente { get; set; }

        public ConfiguracaoPagamento()
        {

        }

        public ConfiguracaoPagamento(
            decimal valorEntrada,
            decimal valorTema,
            decimal valorComDesconto,
            decimal valorPendente,
            decimal valorPercentualCliente)
        {
            ValorEntrada = valorEntrada;
            ValorTema = valorTema;
            ValorComDesconto = valorComDesconto;
            ValorPendente = valorPendente;
            ValorPercentualCliente = valorPercentualCliente;
        }
    }
}
