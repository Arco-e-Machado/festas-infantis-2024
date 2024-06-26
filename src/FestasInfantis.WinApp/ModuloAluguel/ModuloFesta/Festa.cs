using eAgenda.ConsoleApp.Compartilhado;
using FestasInfantis.WinApp.ModuloTema;
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
        Tema Tema { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

        public Festa()
        {
            
        }
        public Festa(string endereco,Tema tema, DateTime data, DateTime inicio, DateTime fim)
        {
            Endereco = endereco;
            Tema = tema;
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
        public override string ToString()
        {
            return Tema.ToString();
        }
    }
}
