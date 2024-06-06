using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public decimal ValorTotal { get; set; }
        public string TemaNome { get; set; }
        public Item Itens;
        public Aluguel Aluguel;

        public Tema(decimal valorTotal, string temaNome, Item itens, Aluguel aluguel)
        {
            ValorTotal = valorTotal;
            TemaNome = temaNome;
            Itens = itens;
            Aluguel = aluguel;
        }
    }
}
