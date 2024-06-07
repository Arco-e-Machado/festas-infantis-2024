using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {

        RepositorioItem repositorioItem;
        TabelaItemControl tabelaItem;

        public ControladorItem(RepositorioItem repositorio)
        {
            repositorioItem = repositorio;
        }
        public override string TipoCadastro { get { return "Item"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Item"; } }

        public override string ToolTipEditar { get { return "Edição um novo Item"; } }

        public override string ToolTipExcluir { get { return "Excluir um novo Item"; } }

        public override void Adicionar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Item novoItem = telaItem.Item;

            repositorioItem.Cadastrar(novoItem);

            CarregarItens();
        }

        private void CarregarItens()
        {
            List<Item> items = repositorioItem.SelecionarTodos();

            tabelaItem.AtualizarRegistros(items);


        }

        public override void Editar()
        {
            TelaItemForm telaItem = new TelaItemForm();

            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                              "Não é possível realizar esta ação sem um registro selecionado.",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning
                         ); return;
            }

            telaItem.Item = itemSelecionado;
            DialogResult resultado = telaItem.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Item itemEditado = telaItem.Item;

            repositorioItem.Editar(idSelecionado, itemEditado);
            CarregarItens();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaItem.ObterRegistroSelecionado();

            Item itemSelecionado = repositorioItem.SelecionarPorId(idSelecionado);

            if (itemSelecionado == null)
            {
                MessageBox.Show(
                               "Não é possível realizar esta ação sem um registro selecionado.",
                              "Aviso",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning
                          ); return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{itemSelecionado.Id}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            repositorioItem.Excluir(idSelecionado);
            CarregarItens();
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItem == null)
                tabelaItem = new TabelaItemControl();

            CarregarItens();

            return tabelaItem;
        }
    }
}
