using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public double Valor { get; set; }

        public Item(string descricao, double valor, string tema)
        {
            Descricao = descricao;
            Valor = valor;
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
    }
}
