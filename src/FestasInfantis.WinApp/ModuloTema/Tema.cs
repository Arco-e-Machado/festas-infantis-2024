using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public decimal ValorTotal { get; set; }
        public string Nome { get; set; }
        public Item Itens;
        public Aluguel Aluguel;

        public Tema(decimal valorTotal, string Nome, Item itens, Aluguel aluguel)
        {
            ValorTotal = valorTotal;
            Nome = Nome;
            Itens = itens;
            Aluguel = aluguel;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }
    }
}
