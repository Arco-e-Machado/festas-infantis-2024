using FestasInfantis.WinApp.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel
{
    public interface IRepositorioAluguel
    {
        void Cadastrar(Aluguel novoAluguel);
        bool Editar(int id, Aluguel atualizarAluguel);
        bool Excluir(int id);
        Aluguel SelecionarPorId(int id);
        List<Aluguel> SelecionarTodos();

    }
}
