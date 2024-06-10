using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloTema;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class Aluguel : EntidadeBase
    {
        public Cliente Cliente { get; set; }
        public Tema Tema { get; set; }
        public Festa Festa;
        public bool Status { get; set; }
        public decimal PorcentagemSaida { get; set; }
        public decimal PorcentagemEntrada { get; set; }
        public DateTime DataPagamento { get; set; }


        public Aluguel(Cliente cliente, Tema tema, Festa festa, bool status, decimal saida, decimal entrada, DateTime pagamento, Cliente repositorio)
        {
            Cliente = cliente;
            Tema = tema;
            Festa = festa;
            Status = status;
            PorcentagemSaida = saida;
            PorcentagemEntrada = entrada;
            DataPagamento = pagamento;
            repositorio.ListarAlugueis(this);


        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizar = (Aluguel)novoRegistro;

            Cliente = atualizar.Cliente;
            Tema = atualizar.Tema;
            Festa = atualizar.Festa;
            Status = atualizar.Status;
            PorcentagemEntrada = atualizar.PorcentagemEntrada;
            PorcentagemSaida = atualizar.PorcentagemSaida;
            DataPagamento = atualizar.DataPagamento;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
