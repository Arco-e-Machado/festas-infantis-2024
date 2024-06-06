using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloFesta;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public string Cliente { get; set; }
        public string Tema { get; set; }
        public bool Status { get; set; }
        public double porcentagemSaida { get; set; }
        public double porcentagemEntrada { get; set; }
        public DateTime DataPagamento { get; set; }

        public Festa Festa;

        public Aluguel(Cliente cliente, Tema tema, Festa festa)
        {
            
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizar = (Aluguel)novoRegistro;

            Cliente = atualizar.Cliente;
            Tema = atualizar.Tema;
            Festa = atualizar.Festa;
            Status = atualizar.Status;
            porcentagemEntrada = atualizar.porcentagemEntrada;
            porcentagemSaida = atualizar.porcentagemSaida;
            DataPagamento = atualizar.DataPagamento;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
