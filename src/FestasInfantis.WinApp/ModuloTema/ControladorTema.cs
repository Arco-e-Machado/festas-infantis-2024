using eAgenda.WinApp.Compartilhado;
using FestasInfantis.WinApp.ModuloItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        RepositorioTema repositorioTema;
        TabelaTemaControl tabelaTema;

        public ControladorTema(RepositorioTema repositorio)
        {
            repositorioTema = repositorio;
        }
        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Adicionar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema exista"; } }

        public override void Adicionar()
        {
            TelaTemaFrom telaTema = new TelaTemaFrom();

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tema novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            CarregarTema();
        }

        private void CarregarTema()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTema.AtualizarRegistros(temas);
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override UserControl ObterListagem()
        {
            throw new NotImplementedException();
        }
    }
}
