using eAgenda.ConsoleApp.Compartilhado;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class Item : EntidadeBase
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item(string descricao,string nome, double valor)
        {
            Nome = nome;
            Descricao = descricao;
            Valor = valor;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Item atualizar = (Item)novoRegistro;

            Descricao = atualizar.Descricao;
            Nomve = atualizar.Nome;
            Valor = atualizar.Valor;

        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O campo \"nome\" deve ser preenchido")
            if (string.IsNullOrEmpty(Descricao.Trim()))
                erros.Add("O campo \"descrição\" deve ser preenchido");

            if (Valor == null || Valor == 0)
                erros.Add("O campo \"Valor\" deve ser preenchido");

            return erros;
        }
    }
}
