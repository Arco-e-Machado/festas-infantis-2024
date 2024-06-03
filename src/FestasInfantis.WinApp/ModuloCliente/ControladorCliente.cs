using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {
        public override string TipoCadastro { get { return "Clientes"; } }

        public override string ToolTipAdicionar { get { return "Cadastrar um novo cliente"; } }

        public override string ToolTipEditar { get { return "Editar um cadastro cliente"; } }

        public override string ToolTipExcluir { get { return "Excluir um cadastro cliente"; } }

        public override void Adicionar()
        {
            TelaCadastroForm telaCliente = new TelaCadastroForm();

            DialogResult resultado = telaCliente.ShowDialog();

            if (resultado == DialogResult.OK) return;

            Cliente novoCliente = telaCliente.Cliente;

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
