using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloAluguel.ModuloFesta;
using FestasInfantis.WinApp.ModuloCliente;
using FestasInfantis.WinApp.ModuloItem;
using FestasInfantis.WinApp.ModuloTema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        IRepositorioAluguel repositorioAluguel;
        IRepositorioCliente repositorioClientes;
        IRepositorioTema repositorioTemas;
        IRepositorioFestas repositorioFestas;

        TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel a, IRepositorioCliente c, IRepositorioTema t, IRepositorioFestas f)
        {
            repositorioAluguel = a;
            repositorioClientes = c;
            repositorioTemas = t;
            repositorioFestas = f;
        }
        public override string TipoCadastro { get { return "Aluguel"; } }

        public override string ToolTipAdicionar { get { return "Adicionar um novo alugue"; } }

        public override string ToolTipEditar { get { return "Editar um aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um aluguel existente"; } }

        public override void Adicionar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            CarregarDados(telaAluguel);

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Aluguel novoAluguel = telaAluguel.Aluguel;

            repositorioAluguel.Cadastrar(novoAluguel);

            CarregarAlugueis();
        }

        public override void Editar()
        {
            TelaAluguelForm telaAluguel = new TelaAluguelForm();

            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            CarregarDados(telaAluguel);

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                              "Não é possível realizar esta ação sem um registro selecionado.",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning
                         ); return;
            }

            telaAluguel.Aluguel = aluguelSelecionado;

            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Aluguel aluguelEditado = telaAluguel.Aluguel;

            repositorioAluguel.Editar(idSelecionado, aluguelEditado);
            CarregarAlugueis();
        }

        public override void Excluir()
        {
            int idSelecionado = tabelaAluguel.ObterRegistroSelecionado();

            Aluguel aluguelSelecionado = repositorioAluguel.SelecionarPorId(idSelecionado);

            if (aluguelSelecionado == null)
            {
                MessageBox.Show(
                               "Não é possível realizar esta ação sem um registro selecionado.",
                              "Aviso",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning
                          ); return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{aluguelSelecionado.Id}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            repositorioAluguel.Excluir(idSelecionado);
            CarregarAlugueis();

        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        void CarregarDados(TelaAluguelForm tela)
        {
            List<Cliente> clientes = repositorioClientes.SelecionarTodos();

            List<Tema> temas = repositorioTemas.SelecionarTodos();

            tela.MostrarDados(clientes, temas);
        }
    }
}
