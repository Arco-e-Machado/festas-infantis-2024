using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloItem
{
    public interface IRepositorioItem
    {
        void Cadastrar(Item NovoItem);
        bool Editar(int id, Item atualizarItem);
        bool Excluir(int id);
        Item SelecionarPorId(int id);
        List<Item> SelecionarTodos();
    }
}
