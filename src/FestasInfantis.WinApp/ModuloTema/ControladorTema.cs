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
        IRepositorioTema repositorioTema;
        IRepositorioItem repositorioItem;
        TabelaTemaControl tabelaTema;

        public ControladorTema(IRepositorioTema rTema, IRepositorioItem rItens)
        {
            repositorioTema = rTema;
            repositorioItem = rItens;
        }
        public override string TipoCadastro { get { return "Tema"; } }

        public override string ToolTipAdicionar { get { return "Adicionar um novo tema"; } }

        public override string ToolTipEditar { get { return "Editar um tema existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um tema exista"; } }

        public override void Adicionar()
        {
            TelaTemaFrom telaTema = new TelaTemaFrom();

            CarregarItens(telaTema);

            DialogResult resultado = telaTema.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Tema novoTema = telaTema.Tema;

            repositorioTema.Cadastrar(novoTema);

            CarregarTema();
        }

        public void CarregarTema()
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
            if(tabelaTema == null)
                tabelaTema = new TabelaTemaControl();

            CarregarTema();

            return tabelaTema;
        }

        public void CarregarItens(TelaTemaFrom telaTema)
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            telaTema.MostrarItens(itens);
        }
    }
}
