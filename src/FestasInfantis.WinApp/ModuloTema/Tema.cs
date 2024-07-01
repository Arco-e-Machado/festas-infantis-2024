using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel;
using FestasInfantis.WinApp.ModuloItem;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class Tema : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal valorTotal { get; set; }
        public List<Item> Itens { get; set; }


        public Tema() { }
        public Tema(string nome, decimal Total, List<Item> itens)
        {
            Nome = nome;
            valorTotal = Total;
            Itens = itens;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" não pode estar vazio");


            return erros;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Tema atualizar = (Tema)novoRegistro;

            Nome = atualizar.Nome;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
