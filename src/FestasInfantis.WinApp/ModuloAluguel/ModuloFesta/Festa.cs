using eAgenda.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestasInfantis.WinApp.ModuloAluguel.ModuloFesta
{
    public class Festa : EntidadeBase
    {
        public string Endereco { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraTermino { get; set; }

        public Festa(string endereco, DateTime data, TimeSpan inicio, TimeSpan fim)
        {
            Endereco = endereco;
            Data = data;
            HoraInicio = inicio;
            HoraTermino = fim;
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Festa atualizar = (Festa)novoRegistro;
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}
