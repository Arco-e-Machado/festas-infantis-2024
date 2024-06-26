using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloCliente
{
    public interface IRepositorioCliente
    {
        void Cadastrar(Cliente novoCliente);
        bool Editar(int id, Cliente atualizarCliente);
        bool Excluir(int id);
        Cliente SelecionarPorId(int id);
        List<Cliente> SelecionarTodos();
    }
}
