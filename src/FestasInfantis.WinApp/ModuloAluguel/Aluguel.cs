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
        public Festa Festa { get; set; }
        public ValorEntradaEnum Sinal { get; set; }
        public string PorcentagemSaida { get; set; }
        public decimal PorcentagemEntrada { get; set; }
        public DateTime DataPagamento { get; set; }

        public Aluguel()
        {

        }
        public Aluguel(Cliente cliente, Tema tema, Festa festa, ValorEntradaEnum sinal, string saida, decimal entrada, DateTime pagamento)
        {
            Cliente = cliente;
            Tema = tema;
            Festa = festa;
            Sinal = sinal;
            PorcentagemSaida = saida;
            PorcentagemEntrada = entrada;
            DataPagamento = pagamento;
            cliente.ListarAlugueis(this);


        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Aluguel atualizar = (Aluguel)novoRegistro;

            Cliente = atualizar.Cliente;
            Tema = atualizar.Tema;
            Festa = atualizar.Festa;
            Sinal = atualizar.Sinal;
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
