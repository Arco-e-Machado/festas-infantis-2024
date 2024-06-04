using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        public override string TipoCadastro { get { return "Item"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo Item"; } }

        public override string ToolTipEditar { get { return "Edição um novo Item"; } }

        public override string ToolTipExcluir { get { return "Excluir um novo Item"; } }

        public override void Adicionar()
        {

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
