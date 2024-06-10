using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase, IControladorClienteAluguel
    {
        RepositorioCliente repositorioCliente;
        TabelaClienteControl tabelaCliente;

        public ControladorCliente(RepositorioCliente repositorio)
        {
            repositorioCliente = repositorio;
        }

        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cadastro cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cadastro cliente"; } }

        public string ToolTipVisualizarAluguel {get{ return "Visualizar Aluguéis do Cliente"; }}

        public override void Adicionar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Cliente novoCliente = telaCliente.Cliente;

            repositorioCliente.Cadastrar(novoCliente);

            CarregarClientes();

        }

        public override void Editar()
        {
            TelaClienteForm telaCliente = new TelaClienteForm();

            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                              "Não é possível realizar esta ação sem um registro selecionado.",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning
                         ); return;
            }

            telaCliente.Cliente = clienteSelecionado;
            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Cliente clienteEditado = telaCliente.Cliente;

            repositorioCliente.Editar(clienteEditado.Id, clienteEditado);
            CarregarClientes();

        }

        public override void Excluir()
        {
            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                               "Não é possível realizar esta ação sem um registro selecionado.",
                              "Aviso",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning
                          ); return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Você deseja realmente excluir o registro \"{clienteSelecionado.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado != DialogResult.Yes) return;

            repositorioCliente.Excluir(clienteSelecionado.Id);
            CarregarClientes();

        } 

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        public void VisualizarAluguel()
        {
            TelaClienteAluguelForm telaAluguel = new TelaClienteAluguelForm();

            int idSelecionado = tabelaCliente.ObterRegistroSelecionado();

            Cliente clienteSelecionado = repositorioCliente.SelecionarPorId(idSelecionado);

            if (clienteSelecionado == null)
            {
                MessageBox.Show(
                              "Não é possível realizar esta ação sem um registro selecionado.",
                             "Aviso",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Warning
                         ); return;
            }
            DialogResult resultado = telaAluguel.ShowDialog();

            if (resultado != DialogResult.OK) return;

        }

        private void CarregarClientes()
        {
            List<Cliente> cliente = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(cliente);
        }
    }
}
