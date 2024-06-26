using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel.ModuloFesta
{
    public interface IRepositorioFestas
    {
        void Cadastrar(Festa novaFesta);
        bool Editar(int id, Festa atualizarFesta);
        bool Excluir(int id);
        Festa SelecionarPorId(int id);
        List<Festa> SelecionarTodos();
    }
}
