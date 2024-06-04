using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloFesta
{
    public class ControladorFesta : ControladorBase
    {
        public override string TipoCadastro { get { return "Festa"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um nova festa"; } }

        public override string ToolTipEditar { get { return "Editar um festa existente"; } }

        public override string ToolTipExcluir { get { return "Excluir um festa existente"; } }

        public override void Adicionar()
        {
            throw new NotImplementedException();
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
