using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public bool Locado { get; set; }

        public Item() { }
        public Item(string descricao, decimal valor, bool locado)
        {
            Descricao = descricao;
            Valor = valor;
            Locado = locado;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizar = (Item)novoRegistro;

            Descricao = atualizar.Descricao;
            Valor = atualizar.Valor;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"descrição\" deve ser preenchido");

            if (Valor == null || Valor == 0)
                erros.Add("O campo \"Valor\" deve ser preenchido");

            return erros;
        }

        public override string ToString()
        {
            return $"Descrição:{Descricao}";
        }
    }
}
